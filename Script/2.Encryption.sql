CONNECT AD_N5/123;
/
--tao ham giai ma
CREATE OR REPLACE FUNCTION FUNC_DECRYPT(input in varchar2)  
RETURN VARCHAR2
IS
    decrypted_raw RAW (2000); -- stores decrypted binary text
    key_bytes_raw raw(128) := utl_i18n.string_to_raw('NHOM05');
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN  
    decrypted_raw := DBMS_CRYPTO.Decrypt
    (
        src => HEXTORAW(input),
        typ => encryption_type,
        key => key_bytes_raw
    );
    RETURN UTL_I18N.RAW_TO_CHAR(decrypted_raw, 'AL32UTF8');  
END; 
/