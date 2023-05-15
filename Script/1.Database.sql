CONNECT AD_N5/123;

DROP TABLE NHANVIEN CASCADE CONSTRAINTS ;
DROP TABLE PHONGBAN CASCADE CONSTRAINTS ;
DROP TABLE DEAN CASCADE CONSTRAINTS ;
DROP TABLE PHANCONG CASCADE CONSTRAINTS ;


CREATE TABLE NHANVIEN
(
    MANV VARCHAR2(10) PRIMARY KEY,
    TENNV VARCHAR (50),
    PHAI VARCHAR2 (10),
    NGAYSINH DATE,
    DIACHI VARCHAR2 (50),
    SODT VARCHAR2(10),
    LUONG VARCHAR2(255),
    PHUCAP VARCHAR2(255),
    VAITRO VARCHAR2(50),
    MANQL VARCHAR2 (10),
    PHG VARCHAR2 (10)
);
CREATE TABLE PHONGBAN
(
    MAPB VARCHAR2(10) PRIMARY KEY,
    TENPB VARCHAR2(50),
    TRPHG VARCHAR2(10)
);
create table DEAN (
    MADA varchar2(10)PRIMARY KEY,
    TENDA varchar2(10),
    NGAYBD date,
    PHONG varchar2(10)
);
CREATE TABLE PHANCONG
(
    MANV VARCHAR2(10) ,
    MADA VARCHAR2(10) ,
    THOIGIAN DATE ,
    PRIMARY KEY (MANV,MADA)
);

ALTER TABLE PHONGBAN
ADD CONSTRAINT FK_PHONGBAN_NHANVIEN
FOREIGN KEY (TRPHG)
REFERENCES NHANVIEN(MANV);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_NHANVIEN
FOREIGN KEY (MANQL)
REFERENCES NHANVIEN (MANV);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_PHONGBAN
FOREIGN KEY (PHG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE DEAN
ADD CONSTRAINT FK_DEAN_PHONGBAN
FOREIGN KEY (PHONG)
REFERENCES PHONGBAN(MAPB);

--
-- KHOA NGOAI CUA PHANCONG
ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANVIEN
FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_DEAN
FOREIGN KEY(MADA)
REFERENCES DEAN(MADA);

/
CREATE OR REPLACE FUNCTION FUNC_ENCRYPT (input IN VARCHAR2)
RETURN VARCHAR2
IS
    key_bytes_raw RAW(128);
    encrypted_raw RAW(2000); -- stores encrypted binary text
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    key_bytes_raw := UTL_I18N.STRING_TO_RAW('NHOM05');
    encrypted_raw := DBMS_CRYPTO.ENCRYPT 
    (
        src => UTL_I18N.STRING_TO_RAW (input, 'AL32UTF8'),
        typ => encryption_type,
        key => key_bytes_raw
    );
    RETURN RAWTOHEX(encrypted_raw);
END;

--tao trigger ma hoa du lieu truoc khi insert tren bang Nhanvien
/
CREATE OR REPLACE TRIGGER ENCRYPT_INSERT_NHANVIEN
BEFORE INSERT ON NHANVIEN 
FOR EACH ROW
DECLARE
BEGIN
    :new.LUONG := FUNC_ENCRYPT(:new.LUONG);
    :new.PHUCAP := FUNC_ENCRYPT(:new.PHUCAP);
END;
/
--tao trigger ma hoa du lieu khi update LUONG hoac PHUCAP tren bang Nhanvien
CREATE OR REPLACE TRIGGER ENCRYPT_UPDATE_NHANVIEN
BEFORE UPDATE ON NHANVIEN
FOR EACH ROW
WHEN (new.LUONG != old.LUONG OR new.PHUCAP != old.PHUCAP)
DECLARE
BEGIN
    IF (:new.LUONG != :old.LUONG) THEN
        :new.LUONG := FUNC_ENCRYPT(:new.LUONG);
    ELSIF (:new.PHUCAP != :old.PHUCAP) THEN
        :new.PHUCAP := FUNC_ENCRYPT(:new.PHUCAP);
    ELSE 
        BEGIN
            :new.LUONG := FUNC_ENCRYPT(:new.LUONG);
            :new.PHUCAP := FUNC_ENCRYPT(:new.PHUCAP);
        END;
    END IF;
END;