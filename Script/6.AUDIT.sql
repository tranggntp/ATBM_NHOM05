ALTER SYSTEM SET audit_trail=DB, extended scope=spfile;
shutdown immediate;
startup;

--
-- STANDARD AUDIT TREN TAT CA CAC BANG
AUDIT ALL ON AD_N5.NHANVIEN BY ACCESS;
AUDIT ALL ON AD_N5.PHANCONG BY ACCESS;
AUDIT ALL ON AD_N5.DEAN BY ACCESS;
AUDIT ALL ON AD_N5.PHONGBAN BY ACCESS;

--
-- THEO DOI CAC HANH VI THANH CONG VA KHONG THANH CONG
AUDIT ALL WHENEVER SUCCESSFUL;
AUDIT ALL WHENEVER NOT SUCCESSFUL;


SELECT USERNAME, EXTENDED_TIMESTAMP, OBJ_NAME, ACTION_NAME, SQL_TEXT
FROM DBA_AUDIT_TRAIL
WHERE OBJ_NAME = 'NHANVIEN';


--------Fine - Grained Auditing
--Cau a: audit tren cot THOIGIAN cua bang PHANCONG
Connect AD_N5/123;
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'AD_N5',
  object_name        => 'PHANCONG',
  policy_name        => 'AUDIT_UPDATE_THOIGIAN_PC');
END;
/
-- tao policy
/
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'AD_N5',
   object_name        => 'PHANCONG',
   policy_name        => 'AUDIT_UPDATE_THOIGIAN_PC',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'THOIGIAN',
   audit_condition => 'SUBSTR(SYS_CONTEXT(''USERENV'', ''SESSION_USER''),-5) != MANV',
   audit_column_opts => dbms_fga.all_columns);
END;
/

GRANT UPDATE ON AD_N5.PHANCONG TO RL_TRUONGPHONG;
/
--
--/
--CONNECT TP_NV022/123;
--UPDATE AD_N5.PHANCONG 
--SET MANV= 'NV002', THOIGIAN = TO_DATE('2019-01-09', 'YYYY-MM-DD')
--WHERE MADA = 'DA001';
--/
--Connect AD_N5/123;
--SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP
--FROM UNIFIED_AUDIT_TRAIL 
--WHERE AUDIT_TYPE = 'FineGrainedAudit' AND OBJECT_SCHEMA = 'AD_N5';
--/
--cau b: Audit doc tren LUONG va PHUCAP cua nguoi khac
--drop policy truoc khi tao
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'AD_N5',
  object_name        => 'NHANVIEN',
  policy_name        => 'AUDIT_XEM_LUONG_PHUCAP_NGUOIKHAC');
END;
/
--tao policy
BEGIN
    DBMS_FGA.ADD_POLICY (
    object_schema => 'AD_N5',
    object_name => 'NHANVIEN',
    policy_name => 'AUDIT_XEM_LUONG_PHUCAP_NGUOIKHAC',
    audit_condition => 'SUBSTR(SYS_CONTEXT(''USERENV'', ''SESSION_USER''),-5) != MANV',
    audit_column =>  'LUONG, PHUCAP',
    statement_types => 'SELECT',
    enable => TRUE,
    audit_trail =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED
    );
END;
/
----cau lenh test
--CONNECT TC_NV023/123; 
--SELECT * FROM AD_N5.NHANVIEN;
--/
--CONNECT AD_N5/123;
--SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP
--FROM UNIFIED_AUDIT_TRAIL 
--WHERE AUDIT_TYPE = 'FineGrainedAudit' AND OBJECT_NAME = 'NHANVIEN'





/
Connect AD_N5/123;
--cau c: 
--drop policy truoc khi tao
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'AD_N5',
  object_name        => 'NHANVIEN',
  policy_name        => 'AUDIT_XEM_LUONG_PHUCAP_VAI_TRO_KHONG_LA_TC');
END;
/
connect AD_N5/123;

--tao policy
BEGIN
    DBMS_FGA.ADD_POLICY (
    object_schema => 'AD_N5',
    object_name => 'NHANVIEN',
    policy_name => 'AUDIT_XEM_LUONG_PHUCAP_VAI_TRO_KHONG_LA_TC',
    audit_condition =>'SUBSTR(SYS_CONTEXT(''USERENV'', ''SESSION_USER''),3) != ''TC''',
    audit_column =>  'LUONG, PHUCAP',
    statement_types => 'UPDATE,SELECT',
    enable => TRUE,
    audit_trail =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED
    );
END;
/
--CONNECT AD_N5/123;
--SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP
--FROM UNIFIED_AUDIT_TRAIL 
--WHERE AUDIT_TYPE = 'FineGrainedAudit' AND FGA_POLICY_NAME = 'AUDIT_XEM_LUONG_PHUCAP_VAI_TRO_KHONG_LA_TC'
