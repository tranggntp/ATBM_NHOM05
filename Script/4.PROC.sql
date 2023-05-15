CONNECT AD_N5/123;

--PROC UPDATE TT CA NHAN CUA MINH 
CREATE OR REPLACE PROCEDURE usp_NhanVien_UpdateThongTin (updated_DiaChi in varchar2, updated_SDT in varchar2, updated_NgaySinh in varchar2)
AS
BEGIN
  UPDATE AD_N5.NHANVIEN
  SET NGAYSINH = TO_DATE(updated_NgaySinh,'mm//dd/yyyy');
  UPDATE AD_N5.NHANVIEN
  SET DIACHI = updated_DiaChi;
  UPDATE AD_N5.NHANVIEN
  SET SODT = updated_SDT;
END;
/
grant execute on AD_N5.usp_NhanVien_UpdateThongTin to RL_NHANVIEN

--PROC TDA THEM 1 DEAN MOI
/
CREATE OR REPLACE PROCEDURE usp_TruongDeAn_ThemDeAn (mada in varchar2,tenda in varchar2, ngay in varchar2, phong in varchar2)
AS
BEGIN
    INSERT INTO AD_N5.DEAN VALUES(mada,tenda,TO_DATE(ngay ,'mm//dd/yyyy'),phong);
END;
/
grant execute on AD_N5.usp_TruongDeAn_ThemDeAn to RL_TRUONGDEAN;
/