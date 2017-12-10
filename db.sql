USE [master]
GO
/****** Object:  Database [QuanLyDoAnTotNghiep]    Script Date: 12/10/2017 4:15:13 PM ******/
CREATE DATABASE [QuanLyDoAnTotNghiep]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyDoAnTotNghiep', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyDoAnTotNghiep.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyDoAnTotNghiep_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyDoAnTotNghiep_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyDoAnTotNghiep].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyDoAnTotNghiep]
GO
/****** Object:  Table [dbo].[BaoCaoTienDo]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoCaoTienDo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDDeTai] [int] NULL,
	[IDSinhVien] [int] NULL,
	[LanBaoCao] [int] NULL,
	[NgayBaoCao] [datetime] NULL,
	[NoiDung] [ntext] NULL,
	[KetQua] [nvarchar](256) NULL,
	[File] [varchar](50) NULL,
	[IDSVDKDT] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BienBanBaoVe]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BienBanBaoVe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDSinhVien] [int] NULL,
	[IDDeTai] [int] NULL,
	[IDHoiDong] [int] NULL,
	[NgayBaoVe] [datetime] NULL,
	[ThoiGianVao] [datetime] NULL,
	[ThoiGianRa] [datetime] NULL,
	[DiemHD1] [float] NULL,
	[DiemHD2] [float] NULL,
	[DiemHD3] [float] NULL,
	[DiemHD4] [float] NULL,
	[DiemHD5] [float] NULL,
	[DiemPhanBien] [float] NULL,
	[DiemHuongDan] [float] NULL,
	[DiemTrungBinh] [float] NULL,
	[NgayTao] [datetime] NULL,
	[IDNguoiTao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BoMon]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoMon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhoa] [int] NULL,
	[TenBoMon] [nvarchar](256) NULL,
	[Status] [bit] NULL,
	[IDcc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenNganh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhoa] [int] NULL,
	[TenChuyenNganh] [nvarchar](256) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeTai]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeTai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDeTai] [nvarchar](256) NULL,
	[IDChuyenNganh] [int] NULL,
	[IDGVDeXuat] [int] NULL,
	[MoTa] [ntext] NULL,
	[NoiDung] [ntext] NULL,
	[DoKho] [int] NULL,
	[TrangThai] [nvarchar](256) NULL,
	[NgayTao] [datetime] NULL,
	[IDNguoiTao] [int] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[MaHienThi] [bigint] NOT NULL,
	[HoTen] [nvarchar](256) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[HocVi] [nvarchar](256) NULL,
	[HocHam] [nvarchar](256) NULL,
	[IDKhoa] [int] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoiDong]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoiDong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHD] [nvarchar](256) NULL,
	[IDKhoa] [int] NULL,
	[NgayThanhLap] [datetime] NULL,
	[NamHoc] [varchar](15) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoiDongGiaoVien]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiDongGiaoVien](
	[MaHD] [int] NOT NULL,
	[MaGV] [int] NOT NULL,
	[ViTri] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](256) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[HoTen] [nvarchar](256) NULL,
	[Lop] [varchar](10) NULL,
	[IDChuyenNganh] [int] NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[Email] [nvarchar](256) NULL,
	[TCTL] [int] NULL,
	[DiemTBTL] [float] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK__SinhVien__3214EC27C8FC9776] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVienDangKyDeTai]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVienDangKyDeTai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDSinhVien] [int] NULL,
	[LanDangKy] [int] NULL,
	[IDDeTai] [int] NULL,
	[NgayDangKy] [datetime] NULL,
	[ChinhThuc] [bit] NULL,
	[IDHoiDong] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/10/2017 4:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHienThi] [bigint] NULL,
	[MatKhau] [varchar](20) NULL,
	[TenTaiKhoan] [nvarchar](256) NULL,
	[Role] [int] NULL,
	[IDRef] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [idx_lastname]    Script Date: 12/10/2017 4:15:13 PM ******/
CREATE NONCLUSTERED INDEX [idx_lastname] ON [dbo].[BoMon]
(
	[IDKhoa] ASC,
	[IDcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_lastnamea]    Script Date: 12/10/2017 4:15:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [idx_lastnamea] ON [dbo].[BoMon]
(
	[IDKhoa] ASC,
	[IDcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SinhVienDangKyDeTai]    Script Date: 12/10/2017 4:15:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SinhVienDangKyDeTai] ON [dbo].[SinhVienDangKyDeTai]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SinhVienDangKyDeTai_INDEX]    Script Date: 12/10/2017 4:15:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [SinhVienDangKyDeTai_INDEX] ON [dbo].[SinhVienDangKyDeTai]
(
	[IDSinhVien] ASC,
	[IDDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoTienDo_DeTai] FOREIGN KEY([IDDeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[BaoCaoTienDo] CHECK CONSTRAINT [FK_BaoCaoTienDo_DeTai]
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoTienDo_SinhVien] FOREIGN KEY([IDSinhVien])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[BaoCaoTienDo] CHECK CONSTRAINT [FK_BaoCaoTienDo_SinhVien]
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoTienDo_SinhVienDangKyDeTai] FOREIGN KEY([IDSVDKDT])
REFERENCES [dbo].[SinhVienDangKyDeTai] ([ID])
GO
ALTER TABLE [dbo].[BaoCaoTienDo] CHECK CONSTRAINT [FK_BaoCaoTienDo_SinhVienDangKyDeTai]
GO
ALTER TABLE [dbo].[BienBanBaoVe]  WITH CHECK ADD FOREIGN KEY([IDDeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[BienBanBaoVe]  WITH CHECK ADD FOREIGN KEY([IDHoiDong])
REFERENCES [dbo].[HoiDong] ([ID])
GO
ALTER TABLE [dbo].[BienBanBaoVe]  WITH CHECK ADD  CONSTRAINT [FK__BienBanBa__IDSin__31EC6D26] FOREIGN KEY([IDSinhVien])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[BienBanBaoVe] CHECK CONSTRAINT [FK__BienBanBa__IDSin__31EC6D26]
GO
ALTER TABLE [dbo].[BienBanBaoVe]  WITH CHECK ADD  CONSTRAINT [FK_BienBanBaoVe_TaiKhoan] FOREIGN KEY([IDNguoiTao])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[BienBanBaoVe] CHECK CONSTRAINT [FK_BienBanBaoVe_TaiKhoan]
GO
ALTER TABLE [dbo].[ChuyenNganh]  WITH CHECK ADD FOREIGN KEY([IDKhoa])
REFERENCES [dbo].[Khoa] ([ID])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD FOREIGN KEY([IDChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([ID])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD FOREIGN KEY([IDGVDeXuat])
REFERENCES [dbo].[GiaoVien] ([ID])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [FK_DeTai_TaiKhoan] FOREIGN KEY([IDNguoiTao])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [FK_DeTai_TaiKhoan]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Khoa] FOREIGN KEY([IDKhoa])
REFERENCES [dbo].[Khoa] ([ID])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Khoa]
GO
ALTER TABLE [dbo].[HoiDong]  WITH CHECK ADD FOREIGN KEY([IDKhoa])
REFERENCES [dbo].[Khoa] ([ID])
GO
ALTER TABLE [dbo].[HoiDongGiaoVien]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([ID])
GO
ALTER TABLE [dbo].[HoiDongGiaoVien]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoiDong] ([ID])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK__SinhVien__IDChuy__4222D4EF] FOREIGN KEY([IDChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK__SinhVien__IDChuy__4222D4EF]
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai]  WITH CHECK ADD  CONSTRAINT [FK__SinhVienD__IDSin__44FF419A] FOREIGN KEY([IDSinhVien])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai] CHECK CONSTRAINT [FK__SinhVienD__IDSin__44FF419A]
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai]  WITH CHECK ADD  CONSTRAINT [FK_SinhVienDangKyDeTai_DeTai] FOREIGN KEY([IDDeTai])
REFERENCES [dbo].[DeTai] ([ID])
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai] CHECK CONSTRAINT [FK_SinhVienDangKyDeTai_DeTai]
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai]  WITH CHECK ADD  CONSTRAINT [FK_SinhVienDangKyDeTai_HoiDong] FOREIGN KEY([IDHoiDong])
REFERENCES [dbo].[HoiDong] ([ID])
GO
ALTER TABLE [dbo].[SinhVienDangKyDeTai] CHECK CONSTRAINT [FK_SinhVienDangKyDeTai_HoiDong]
GO
USE [master]
GO
ALTER DATABASE [QuanLyDoAnTotNghiep] SET  READ_WRITE 
GO
