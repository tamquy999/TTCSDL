USE [master]
GO
/****** Object:  Database [TTCSDL]    Script Date: 04/01/2021 8:34:12 SA ******/
CREATE DATABASE [TTCSDL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTCSDL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TTCSDL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TTCSDL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TTCSDL_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TTCSDL] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTCSDL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTCSDL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTCSDL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTCSDL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTCSDL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTCSDL] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTCSDL] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TTCSDL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTCSDL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTCSDL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTCSDL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTCSDL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTCSDL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTCSDL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTCSDL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTCSDL] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTCSDL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTCSDL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTCSDL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTCSDL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTCSDL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTCSDL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTCSDL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTCSDL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTCSDL] SET  MULTI_USER 
GO
ALTER DATABASE [TTCSDL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTCSDL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTCSDL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTCSDL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TTCSDL] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TTCSDL] SET QUERY_STORE = OFF
GO
USE [TTCSDL]
GO
/****** Object:  Table [dbo].[BACSY]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BACSY](
	[MABS] [char](10) NOT NULL,
	[NGAYSINH] [date] NULL,
	[HOTEN] [nvarchar](50) NULL,
	[CHUCVU] [nvarchar](20) NULL,
	[HOCHAM] [nvarchar](20) NULL,
	[HOCVI] [nvarchar](20) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[MATKHAU] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MABS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETTIEM]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETTIEM](
	[MAPHIEUTIEM] [char](10) NOT NULL,
	[MAVACCINE] [char](10) NOT NULL,
	[GIABAN] [int] NULL,
	[MUITHU] [int] NULL,
	[NGAYTIEMNHACLAI] [date] NULL,
	[LIEULUONG] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTIEM] ASC,
	[MAVACCINE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [char](10) NOT NULL,
	[CHIETKHAU] [float] NULL,
	[NGAYTHU] [date] NULL,
	[TONGTIEN] [bigint] NULL,
	[MAGH] [char](10) NOT NULL,
	[MATHUNGAN] [char](10) NOT NULL,
	[MAPHIEUTIEM] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [char](10) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](4) NULL,
	[TIEUSU] [nvarchar](250) NULL,
	[MAGH] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIVC](
	[MALOAIVC] [char](10) NOT NULL,
	[LOAIVACCINE] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAIVC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIGIAMHO]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIGIAMHO](
	[MAGH] [char](10) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTIEM]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTIEM](
	[MAPHIEUTIEM] [char](10) NOT NULL,
	[NGAYTIEM] [date] NULL,
	[MAKH] [char](10) NOT NULL,
	[MABS] [char](10) NULL,
	[DATIEM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTIEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUNGAN]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUNGAN](
	[MATHUNGAN] [char](10) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[TRINHDO] [nvarchar](20) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[PASSWORD] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHUNGAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VACCINE]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VACCINE](
	[MAVACCINE] [char](10) NOT NULL,
	[TENVACCINE] [varchar](50) NULL,
	[NHASX] [nvarchar](50) NULL,
	[NGAYSX] [date] NULL,
	[HANSD] [date] NULL,
	[SOLO] [varchar](50) NULL,
	[SOLUONGCOSAN] [int] NULL,
	[DONGIA] [int] NULL,
	[MALOAIVC] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAVACCINE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETTIEM]  WITH CHECK ADD FOREIGN KEY([MAPHIEUTIEM])
REFERENCES [dbo].[PHIEUTIEM] ([MAPHIEUTIEM])
GO
ALTER TABLE [dbo].[CHITIETTIEM]  WITH CHECK ADD FOREIGN KEY([MAPHIEUTIEM])
REFERENCES [dbo].[PHIEUTIEM] ([MAPHIEUTIEM])
GO
ALTER TABLE [dbo].[CHITIETTIEM]  WITH CHECK ADD FOREIGN KEY([MAVACCINE])
REFERENCES [dbo].[VACCINE] ([MAVACCINE])
GO
ALTER TABLE [dbo].[CHITIETTIEM]  WITH CHECK ADD FOREIGN KEY([MAVACCINE])
REFERENCES [dbo].[VACCINE] ([MAVACCINE])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAGH])
REFERENCES [dbo].[NGUOIGIAMHO] ([MAGH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAGH])
REFERENCES [dbo].[NGUOIGIAMHO] ([MAGH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAPHIEUTIEM])
REFERENCES [dbo].[PHIEUTIEM] ([MAPHIEUTIEM])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAPHIEUTIEM])
REFERENCES [dbo].[PHIEUTIEM] ([MAPHIEUTIEM])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MATHUNGAN])
REFERENCES [dbo].[THUNGAN] ([MATHUNGAN])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MATHUNGAN])
REFERENCES [dbo].[THUNGAN] ([MATHUNGAN])
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD FOREIGN KEY([MAGH])
REFERENCES [dbo].[NGUOIGIAMHO] ([MAGH])
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD FOREIGN KEY([MAGH])
REFERENCES [dbo].[NGUOIGIAMHO] ([MAGH])
GO
ALTER TABLE [dbo].[PHIEUTIEM]  WITH CHECK ADD FOREIGN KEY([MABS])
REFERENCES [dbo].[BACSY] ([MABS])
GO
ALTER TABLE [dbo].[PHIEUTIEM]  WITH CHECK ADD FOREIGN KEY([MABS])
REFERENCES [dbo].[BACSY] ([MABS])
GO
ALTER TABLE [dbo].[PHIEUTIEM]  WITH CHECK ADD FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[PHIEUTIEM]  WITH CHECK ADD FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[VACCINE]  WITH CHECK ADD FOREIGN KEY([MALOAIVC])
REFERENCES [dbo].[LOAIVC] ([MALOAIVC])
GO
ALTER TABLE [dbo].[VACCINE]  WITH CHECK ADD FOREIGN KEY([MALOAIVC])
REFERENCES [dbo].[LOAIVC] ([MALOAIVC])
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD CHECK  (([GIOITINH]=N'Nam' OR [GIOITINH]=N'Nữ'))
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD CHECK  (([GIOITINH]=N'Nam' OR [GIOITINH]=N'Nữ'))
GO
/****** Object:  StoredProcedure [dbo].[sp_AddMaGHtoKH]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_AddMaGHtoKH] (@MAGH CHAR(10))
AS
BEGIN
    UPDATE KHACHHANG SET MAGH = @MAGH WHERE MAKH IN (
	    SELECT kh.MAKH
	    FROM NGUOIGIAMHO gh INNER JOIN HOADON hd INNER JOIN PHIEUTIEM pt INNER JOIN KHACHHANG kh
	    ON kh.MAKH = pt.MAKH ON pt.MAPHIEUTIEM = hd.MAPHIEUTIEM ON hd.MAGH = gh.MAGH
	    WHERE gh.MAGH = @MAGH )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckPaymentStatus]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_CheckPaymentStatus] (@MAPHIEUTIEM CHAR(10))
AS
BEGIN
    DECLARE @returnVal int
	IF EXISTS (SELECT * FROM dbo.PHIEUTIEM pt INNER JOIN dbo.HOADON hd ON hd.MAPHIEUTIEM = pt.MAPHIEUTIEM WHERE pt.MAPHIEUTIEM = @MAPHIEUTIEM)
	BEGIN
	    SET @returnVal = 1
	END
	ELSE SET @returnVal = 0
	RETURN @returnVal
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CountVCTheoLoaiVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CountVCTheoLoaiVC]
AS
BEGIN
	SELECT VACCINE.MALOAIVC AS 'Loai', SUM(SOLUONGCOSAN) AS 'SoLuong'
FROM dbo.VACCINE INNER JOIN dbo.LOAIVC ON LOAIVC.MALOAIVC = VACCINE.MALOAIVC
GROUP BY VACCINE.MALOAIVC
ORDER BY VACCINE.MALOAIVC ASC
END


--Lay list vaccine duoc dung nhieu nhat trong mot khoang thoi gian
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDon]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_DeleteHoaDon] (@MAHOADON CHAR(10))
AS
BEGIN
    DELETE FROM dbo.HOADON WHERE MAHOADON = @MAHOADON
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeletePhieuTiem]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_DeletePhieuTiem] (@MAPHIEUTIEM CHAR(10))
AS	
BEGIN
    DELETE dbo.PHIEUTIEM WHERE MAPHIEUTIEM = @MAPHIEUTIEM
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllHoaDonInfo]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetAllHoaDonInfo]
AS
BEGIN
    SELECT hd.MAHOADON, hd.TONGTIEN, hd.CHIETKHAU, hd.NGAYTHU, ngh.HOTEN AS NGUOIGH, ngh.DIACHI, ngh.SDT, tn.HOTEN AS THUNGAN
	FROM dbo.THUNGAN tn INNER JOIN dbo.HOADON hd INNER JOIN dbo.NGUOIGIAMHO ngh
	ON ngh.MAGH = hd.MAGH
	ON hd.MATHUNGAN = tn.MATHUNGAN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllLichSuTiem]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllLichSuTiem] (@MAKH CHAR(10))
AS
BEGIN
	SELECT pt.NGAYTIEM, vc.TENVACCINE, lvc.LOAIVACCINE, vc.NHASX, ctt.MUITHU, ctt.LIEULUONG, ctt.NGAYTIEMNHACLAI, vc.DONGIA
    FROM dbo.KHACHHANG kh INNER JOIN dbo.PHIEUTIEM pt INNER JOIN dbo.CHITIETTIEM ctt INNER JOIN dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc
	ON VC.MALOAIVC = lvc.MALOAIVC
    ON vc.MAVACCINE = ctt.MAVACCINE
    ON ctt.MAPHIEUTIEM = pt.MAPHIEUTIEM
    ON pt.MAKH = kh.MAKH
    WHERE kh.MAKH = @MAKH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllVaccine]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_GetAllVaccine]
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDoanhThuTheoNgayINTIME]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetDoanhThuTheoNgayINTIME](@NgayDau DATE, @NgayCuoi DATE)
AS
BEGIN
    SELECT NGAYTHU AS "Ngay", SUM(TONGTIEN) AS "Tien"
	FROM dbo.HOADON
	WHERE NGAYTHU BETWEEN @NgayDau AND @NgayCuoi
	GROUP BY(NGAYTHU)
	ORDER BY NGAYTHU ASC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHoaDonINTIME_TK]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[sp_GetHoaDonINTIME_TK]  (@NgayDau DATE, @NgayCuoi DATE)
AS
BEGIN
    SELECT NGAYTHU AS "Ngay", TONGTIEN AS "Tien"
	FROM dbo.HOADON
	WHERE NGAYTHU BETWEEN @NgayDau AND @NgayCuoi
	ORDER BY NGAYTHU ASC
END


--//////////////////////////////////////////////////////////////////////////

-- Cac PROC Report cho ThanhToan:

--get Thong Tin tu Hoa Don bang MaHoaDon
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaPhieuTiemFromHD]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_GetMaPhieuTiemFromHD] (@MAHOADON CHAR(10))
AS
BEGIN
    SELECT MAPHIEUTIEM FROM dbo.HOADON WHERE MAHOADON = @MAHOADON
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMostUsedVaccineINTIME]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetMostUsedVaccineINTIME] (@NgayDau DATE, @NgayCuoi DATE)
AS
BEGIN	
		SELECT MAVACCINE AS 'MaVC', COUNT(MAVACCINE) AS 'SoLuong'
		FROM dbo.PHIEUTIEM INNER JOIN dbo.CHITIETTIEM ON CHITIETTIEM.MAPHIEUTIEM = PHIEUTIEM.MAPHIEUTIEM
		WHERE CHITIETTIEM.MAPHIEUTIEM IN
		(SELECT DISTINCT MAPHIEUTIEM FROM dbo.HOADON WHERE NGAYTHU BETWEEN @NgayDau AND @NgayCuoi)
		GROUP BY MAVACCINE
		ORDER BY SoLuong DESC
END


--Get hoa don trong 1 khoang thoi gian
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPhieuTiemsInfo]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_GetPhieuTiemsInfo] 
AS
BEGIN
    SELECT pt.MAPHIEUTIEM, kh.MAKH, kh.TENKH, kh.NGAYSINH, kh.GIOITINH, kh.TIEUSU, pt.NGAYTIEM, pt.DATIEM
	FROM dbo.PHIEUTIEM pt INNER JOIN dbo.KHACHHANG kh
	ON kh.MAKH = pt.MAKH
	ORDER BY pt.MAPHIEUTIEM DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTenThuNgan]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_GetTenThuNgan] (@MATHUNGAN char(10))
AS
BEGIN
	SELECT HOTEN FROM THUNGAN WHERE MATHUNGAN = @MATHUNGAN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTenVCTuMaVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetTenVCTuMaVC](@MaVC CHAR(10))
AS
BEGIN
	SELECT TENVACCINE AS 'TenVC'
	FROM dbo.VACCINE
	WHERE MAVACCINE = @MaVC
END


--Lay Doanh Thu Theo Ngay:
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVCFromPhieuTiem]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_GetVCFromPhieuTiem] (@MAPHIEUTIEM CHAR(10))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, lvc.LOAIVACCINE, vc.NHASX, ctt.MUITHU, ctt.LIEULUONG, ctt.NGAYTIEMNHACLAI, vc.DONGIA
    FROM dbo.PHIEUTIEM pt INNER JOIN dbo.CHITIETTIEM ctt INNER JOIN dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc
	ON lvc.MALOAIVC = vc.MALOAIVC
    ON vc.MAVACCINE = ctt.MAVACCINE
    ON ctt.MAPHIEUTIEM = pt.MAPHIEUTIEM
    WHERE ctt.MAPHIEUTIEM = @MAPHIEUTIEM
END



--Dem so Vaccine cua moi LOAIVC:
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTT]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_InsertCTT] (@MAPHIEUTIEM CHAR(10),@MAVACCINE CHAR(10), @GIABAN INT, @MUITHU INT, @NGAYNHACLAI DATE, @LIEULUONG FLOAT)
AS
BEGIN
    INSERT INTO dbo.CHITIETTIEM
    (
        MAPHIEUTIEM,
        MAVACCINE,
        GIABAN,
        MUITHU,
        NGAYTIEMNHACLAI,
        LIEULUONG
    )
    VALUES
    (   @MAPHIEUTIEM,        -- MAPHIEUTIEM - char(10)
        @MAVACCINE,        -- MAVACCINE - char(10)
        @GIABAN,         -- GIABAN - int
        @MUITHU,         -- MUITHU - int
        @NGAYNHACLAI, -- NGAYTIEMNHACLAI - date
        @LIEULUONG        -- LIEULUONG - float
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHD]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_InsertHD] (@MAHOADON CHAR(10), @CHIETKHAU FLOAT, @NGAYTHU DATE, @TONGTIEN BIGINT, @MAGH CHAR(10), @MATHUNGAN CHAR(10), @MAPHIEUTIEM CHAR(10))
AS
BEGIN
    INSERT INTO dbo.HOADON
    (
        MAHOADON,
        CHIETKHAU,
        NGAYTHU,
        TONGTIEN,
        MAGH,
        MATHUNGAN,
        MAPHIEUTIEM
    )
    VALUES
    (   @MAHOADON,        -- MAHOADON - char(10)
        @CHIETKHAU,       -- CHIETKHAU - float
        @NGAYTHU, -- NGAYTHU - date
        @TONGTIEN,         -- TONGTIEN - bigint
        @MAGH,        -- MAGH - char(10)
        @MATHUNGAN,        -- MATHUNGAN - char(10)
        @MAPHIEUTIEM         -- MAPHIEUTIEM - char(10)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertKH]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_InsertKH] (@MAKH CHAR(10), @TENKH CHAR(10), @NGAYSINH DATE, @GIOITINH NVARCHAR(4), @TIEUSU NVARCHAR(250), @MAGH CHAR(10))
AS
BEGIN
    INSERT INTO dbo.KHACHHANG
    (
        MAKH,
        TENKH,
        NGAYSINH,
        GIOITINH,
        TIEUSU,
        MAGH
    )
    VALUES
    (   @MAKH,        -- MAKH - char(10)
        @TENKH,       -- TENKH - nvarchar(20)
        @NGAYSINH, -- NGAYSINH - date
        @GIOITINH,       -- GIOITINH - nvarchar(4)
        @TIEUSU,       -- TIEUSU - nvarchar(250)
        @MAGH         -- MAGH - char(10)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNGH]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_InsertNGH] (@MAGH CHAR(10), @HOTEN NVARCHAR(50), @DIACHI NVARCHAR(100), @SDT VARCHAR(20))
AS
BEGIN
    INSERT INTO dbo.NGUOIGIAMHO
    (
        MAGH,
        HOTEN,
        DIACHI,
        SDT
    )
    VALUES
    (   @MAGH,  -- MAGH - char(10)
        @HOTEN, -- HOTEN - nvarchar(50)
        @DIACHI, -- DIACHI - nvarchar(100)
        @SDT   -- SDT - varchar(20)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPhieuTiem]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_InsertPhieuTiem] (@MAPHIEUTIEM CHAR(10), @NGAYTIEM DATE, @MAKH CHAR(10), @MABS CHAR(10)) 
AS
BEGIN
    INSERT INTO dbo.PHIEUTIEM
    (
        MAPHIEUTIEM,
        NGAYTIEM,
        MAKH,
        MABS
    )
    VALUES
    (   @MAPHIEUTIEM,        -- MAPHIEUTIEM - char(10)
        @NGAYTIEM, -- NGAYTIEM - date
        @MAKH,        -- MAKH - char(10)
        @MABS         -- MABS - char(10)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_IsVCInStock]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_IsVCInStock] (@MAVACCINE CHAR(10))
AS
BEGIN
	DECLARE @returnVal int
	IF EXISTS (SELECT MAVACCINE FROM VACCINE WHERE MAVACCINE = @MAVACCINE)
	BEGIN
	    SET @returnVal = 1
	END
	ELSE SET @returnVal = 0
	RETURN @returnVal
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchAllVaccine]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_SearchAllVaccine] (@Value NVARCHAR(100))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
    WHERE vc.MAVACCINE LIKE N'%' + @Value + '%'
    OR vc.TENVACCINE LIKE N'%' + @Value + '%'
    OR vc.NHASX LIKE N'%' + @Value + '%'
    OR vc.NGAYSX LIKE N'%' + @Value + '%'
    OR vc.HANSD  LIKE N'%' + @Value + '%'
    OR vc.SOLO LIKE N'%' + @Value + '%'
    OR vc.SOLUONGCOSAN LIKE N'%' + @Value + '%'
    OR lvc.LOAIVACCINE LIKE N'%' + @Value + '%'
    OR vc.DONGIA LIKE N'%' + @Value + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchByLoaiVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SearchByLoaiVC] (@Value NVARCHAR(100))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
    WHERE lvc.LOAIVACCINE LIKE N'%' + @Value + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchByMaVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SearchByMaVC] (@Value NVARCHAR(100))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
    WHERE vc.MAVACCINE LIKE N'%' + @Value + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchByNhaSX]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SearchByNhaSX] (@Value NVARCHAR(100))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
    WHERE vc.NHASX LIKE N'%' + @Value + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchByTenVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SearchByTenVC] (@Value NVARCHAR(100))
AS
BEGIN
    SELECT vc.MAVACCINE, vc.TENVACCINE, vc.NHASX, vc.NGAYSX, vc.HANSD, vc.SOLO, vc.SOLUONGCOSAN, vc.DONGIA, lvc.LOAIVACCINE
	FROM dbo.VACCINE vc INNER JOIN dbo.LOAIVC lvc ON lvc.MALOAIVC = vc.MALOAIVC
    WHERE vc.TENVACCINE LIKE N'%' + @Value + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateHoaDonInfo]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_UpdateHoaDonInfo] (@MAHOADON CHAR(10), @NGAYTHU DATE, @NGUOIGH NVARCHAR(50), @DIACHI NVARCHAR(100), @SDT VARCHAR(20))
AS
BEGIN
    UPDATE dbo.HOADON SET NGAYTHU = @NGAYTHU WHERE MAHOADON = @MAHOADON
	UPDATE dbo.NGUOIGIAMHO SET HOTEN = @NGUOIGH, DIACHI = @DIACHI, SDT = @SDT WHERE MAGH IN
	(
		SELECT HD.MAGH FROM dbo.NGUOIGIAMHO ngh INNER JOIN dbo.HOADON hd ON hd.MAGH = ngh.MAGH WHERE hd.MAHOADON = @MAHOADON
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePhieuTiemInfo]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_UpdatePhieuTiemInfo] (@MAPHIEUTIEM CHAR(10), @NGAYTIEM DATE, @TENKH NVARCHAR(50), @NGAYSINH DATE, @GIOITINH NVARCHAR(4), @TIEUSU NVARCHAR(250))
AS
BEGIN
    UPDATE dbo.PHIEUTIEM SET NGAYTIEM = @NGAYTIEM WHERE MAPHIEUTIEM = @MAPHIEUTIEM
	UPDATE dbo.KHACHHANG SET TENKH = @TENKH, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, TIEUSU = @TIEUSU WHERE MAKH IN
	(
		SELECT kh.MAKH FROM dbo.KHACHHANG kh INNER JOIN  dbo.PHIEUTIEM pt ON pt.MAKH = kh.MAKH WHERE pt.MAPHIEUTIEM = @MAPHIEUTIEM
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_getInforHoaDon]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_getInforHoaDon] (@maHD CHAR(10))
AS
BEGIN	
	SELECT 
		CHIETKHAU AS 'ChietKhau', 
		NGAYTHU AS 'NgayThu', 
		TONGTIEN AS 'TongTien',
		MAPHIEUTIEM AS 'MaPhieuTiem',
		MATHUNGAN AS 'MaThuNgan'
	FROM dbo.HOADON
	WHERE MAHOADON = @maHD
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetInforNGH]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetInforNGH](@maHD CHAR(10))
AS
BEGIN
	SELECT HOTEN AS 'HoTen', DIACHI AS 'DiaChi', SDT AS 'SDT'
	FROM	dbo.NGUOIGIAMHO INNER JOIN dbo.HOADON ON HOADON.MAGH = NGUOIGIAMHO.MAGH
	WHERE
	(
		MAHOADON = @maHD
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetMaVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetMaVC](@maPhieuTiem CHAR(10))
AS
BEGIN
	SELECT DISTINCT MAVACCINE AS 'MaVC'
	FROM dbo.CHITIETTIEM 
	WHERE MAPHIEUTIEM = @maPhieuTiem
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetNgayTiem]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetNgayTiem](@maPhieuTiem CHAR(10))
AS
BEGIN
	SELECT NGAYTIEM AS 'NgayTiem'
	FROM dbo.PHIEUTIEM
	WHERE MAPHIEUTIEM = @maPhieuTiem
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetTen_GiaVC]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetTen_GiaVC] (@maVC CHAR(10))
AS
BEGIN
    SELECT TENVACCINE AS 'TenVC', DONGIA AS 'DonGiaVC'
	FROM dbo.VACCINE
	WHERE MAVACCINE = @maVC
END


--get Ten Thu Ngan bang MaThuNgan:
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetTenBenhNhan]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetTenBenhNhan](@maPhieuTiem CHAR(10))
AS
BEGIN
	SELECT DISTINCT TENKH AS 'TenBN'
	FROM dbo.PHIEUTIEM INNER JOIN dbo.KHACHHANG ON	KHACHHANG.MAKH = PHIEUTIEM.MAKH
	WHERE MAPHIEUTIEM = @maPhieuTiem
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetTenBS]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetTenBS](@maPhieuTiem CHAR(10))
AS
BEGIN
SELECT HOTEN AS 'HoTenBS'
FROM dbo.BACSY INNER JOIN dbo.PHIEUTIEM ON PHIEUTIEM.MABS = BACSY.MABS
WHERE MAPHIEUTIEM = @maPhieuTiem
END
GO
/****** Object:  StoredProcedure [dbo].[spRP_GetTenThuNgan]    Script Date: 04/01/2021 8:34:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spRP_GetTenThuNgan] (@maTN CHAR(10))
AS
BEGIN
    SELECT HOTEN AS 'HoTenTN'
	FROM dbo.THUNGAN
	WHERE MATHUNGAN = @maTN 
END


--Get ten Benh nhan bang MaPhieuTiem:
GO
USE [master]
GO
ALTER DATABASE [TTCSDL] SET  READ_WRITE 
GO
