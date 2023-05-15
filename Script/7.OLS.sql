--chay sys

SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security';
SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS';
EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
shutdown IMMEDIATE;
startup;
/
ALTER USER lbacsys IDENTIFIED BY 0 ACCOUNT UNLOCK 
ALTER PLUGGABLE DATABASE test_ols OPEN READ WRITE; 
select * from v$services; 
alter session set container=test_ols; 
/
--THEM
CREATE USER AD_N5 IDENTIFIED BY 123 CONTAINER = CURRENT; 
GRANT CONNECT,RESOURCE TO AD_N5; 
GRANT UNLIMITED TABLESPACE TO AD_N5; 
GRANT SELECT ANY DICTIONARY TO AD_N5; 
GRANT EXECUTE ON sa_components TO AD_N5 WITH GRANT OPTION;
GRANT EXECUTE ON sa_user_admin TO AD_N5 WITH GRANT OPTION;
GRANT EXECUTE ON sa_label_admin TO AD_N5 WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO AD_N5 WITH GRANT OPTION;
GRANT EXECUTE ON sa_audit_admin TO AD_N5 WITH GRANT OPTION;
GRANT EXECUTE ON SA_SESSION TO AD_N5 WITH GRANT OPTION;
GRANT LBAC_DBA TO AD_N5;
GRANT EXECUTE ON sa_sysdba TO AD_N5;
GRANT EXECUTE ON to_lbac_data_label TO AD_N5;
GRANT INHERIT PRIVILEGES ON USER SYS TO LBACSYS;
GRANT region_policy_DBA TO AD_N5;

--chay AD_N5


BEGIN
SA_SYSDBA.DROP_POLICY(
    policy_name => 'region_policy'
);
END;
/
BEGIN
SA_SYSDBA.CREATE_POLICY(
    policy_name => 'region_policy',
    column_name => 'region_label',
    default_options => 'read_control, write_control, update_control'
);
END;
/

EXEC SA_SYSDBA.ENABLE_POLICY ('region_policy');
/
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',20,'NV','Nhan Vien'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',40,'TP','Truong Phong'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('region_policy',60,'GD','Giam Doc'); 
--tao compartment 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',100,'MB','Mua Ban'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',120,'SX','San Xuat'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('region_policy',140,'GC','Gia Cong'); 

--tao group 
EXECUTE SA_COMPONENTS.CREATE_GROUP('region_policy',20,'MB','Mien Bac'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('region_policy',40,'MT','Mien Trung'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('region_policy',60,'MN','Mien Nam'); 



--CHAY SYS
SELECT * FROM dba_sa_levels; 
SELECT * FROM DBA_SA_COMPARTMENTS; 
SELECT * FROM DBA_SA_GROUPS; 
SELECT * FROM DBA_SA_GROUP_HIERARCHY

EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('region_policy','ad_n5','FULL,PROFILE_ACCESS'); 

--CHAY AD_N5

CREATE TABLE THONGBAO ( 
id NUMBER(10) NOT NULL, 
noidung VARCHAR2(1000), 
ngaylap Date,
vitridiali VARCHAR2(30), 
linhvuc VARCHAR2(30), 
capbac VARCHAR2(30), 
CONSTRAINT THONGBAO_PK PRIMARY KEY (id)); 
--NHẬP LIỆU 
--có gì thay đổi giá trị mấy này nha cho phù hợp nha
INSERT INTO THONGBAO VALUES ( 1, 'Thong bao 1', TO_DATE('2022/12/16 ', 'yyyy/mm/dd '),'Mien Bac','Mua Ban','Giam Doc');
INSERT INTO THONGBAO VALUES ( 2, 'Thong bao 2', TO_DATE('2023/12/16 ', 'yyyy/mm/dd '),'Mien Nam','San Xuat','Truong Phong');
INSERT INTO THONGBAO VALUES ( 3, 'Thong bao 3', TO_DATE('2021/1/11 ', 'yyyy/mm/dd '),'Mien Trung','Gia Cong','Nhan Vien');

/
CREATE OR REPLACE FUNCTION get_thongbao_label (
    p_vitridiali IN VARCHAR2,
    p_linhvuc IN VARCHAR2,
    p_capbac IN VARCHAR2)
RETURN varchar --LBACSYS.LBAC_LABEL
AS
    v_label VARCHAR2(80);
BEGIN
    IF p_capbac = 'Giam Doc' THEN
        v_label := 'GD:';
    ELSIF p_capbac = 'Truong Phong' THEN
        v_label := 'TP:';
    ELSE
        v_label := 'NV:';
    END IF;
    
    IF p_linhvuc = 'Mua Ban' THEN
        v_label := v_label || 'MB:';
    ELSIF p_linhvuc = 'San Xuat' THEN
        v_label := v_label || 'SX:';
    ELSIF p_linhvuc = 'Gia Cong' THEN
        v_label := v_label || 'GC:';
    END IF;
    
    IF p_vitridiali = 'Mien Bac' THEN
        v_label := v_label || 'MB';
    ELSIF p_vitridiali = 'Mien Trung' THEN
        v_label := v_label || 'MT';
    ELSIF p_vitridiali = 'Mien Nam' THEN
        v_label := v_label || 'MN';
    END IF;
    
    RETURN CHAR_TO_LABEL('region_policy',v_label);
    
END get_thongbao_label;
/

BEGIN
SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('region_policy','AD_N5','THONGBAO'); 
SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    policy_name => 'region_policy',
    schema_name => 'AD_N5',
    table_name => 'THONGBAO',
    table_options => 'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL',
    predicate => NULL);
END;
/
DECLARE
    CURSOR CUR IS SELECT capbac,linhvuc, vitridiali,id FROM THONGBAO;
    custype VARCHAR(30);
    reg VARCHAR(30);
    cred VARCHAR(30);
    p int;
BEGIN
    OPEN CUR;
    LOOP
        FETCH cur into custype, reg,cred,p;
        IF cur%NOTFOUND THEN
            EXIT;
        END IF;
        
        UPDATE THONGBAO
            SET region_label = get_thongbao_label(custype,reg,cred)
            where id = p;
    END LOOP;
    CLOSE CUR;
END; 
/
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','AD_N5','GD:MB,SX,GC:MB,MT,MN');
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','giamdoc1','GD:MB,SX,GC:MB,MT,MN'); -- GIAM DOC
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','truongphong1','TP:SX:MN'); -- TRUONG PHONG
    SA_USER_ADMIN.SET_USER_LABELS('region_policy','giamdoc2','GD:MB,SX,GC:MB'); --GIAM DOC
END;

--chay sys
/
CREATE USER giamdoc1 IDENTIFIED BY 123; 
CREATE USER truongphong1 IDENTIFIED BY 123; 
GRANT CONNECT TO giamdoc1, truongphong1;

--connect vao user
CONNNECT giamdoc1/123;
SELECT * FROM AD_N5.THONGBAO;