USE [master]
GO
/****** Object:  Database [QuanLyDoAnTotNghiep]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[BaoCaoTienDo]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[BienBanBaoVe]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[BoMon]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[DeTai]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[HoiDong]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[HoiDongGiaoVien]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[SinhVienDangKyDeTai]    Script Date: 1/3/2018 10:24:43 AM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/3/2018 10:24:43 AM ******/
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
SET IDENTITY_INSERT [dbo].[BaoCaoTienDo] ON 

INSERT [dbo].[BaoCaoTienDo] ([ID], [IDDeTai], [IDSinhVien], [LanBaoCao], [NgayBaoCao], [NoiDung], [KetQua], [File], [IDSVDKDT], [TrangThai]) VALUES (7, 14, 1000, 1, CAST(N'2017-12-10 10:20:39.170' AS DateTime), N'sdffs', N'jklkk', N'ìuudhsjfhsdiuyfo', 25, 2)
INSERT [dbo].[BaoCaoTienDo] ([ID], [IDDeTai], [IDSinhVien], [LanBaoCao], [NgayBaoCao], [NoiDung], [KetQua], [File], [IDSVDKDT], [TrangThai]) VALUES (8, 14, 1000, 2, CAST(N'2017-12-10 10:21:08.983' AS DateTime), N'sdffs', NULL, N'ìuudhsjfhsdiuyfo', 25, NULL)
INSERT [dbo].[BaoCaoTienDo] ([ID], [IDDeTai], [IDSinhVien], [LanBaoCao], [NgayBaoCao], [NoiDung], [KetQua], [File], [IDSVDKDT], [TrangThai]) VALUES (13, 14, 1000, 3, CAST(N'2018-01-02 15:09:04.677' AS DateTime), N'............', NULL, N'.............', 25, NULL)
SET IDENTITY_INSERT [dbo].[BaoCaoTienDo] OFF
SET IDENTITY_INSERT [dbo].[BoMon] ON 

INSERT [dbo].[BoMon] ([ID], [IDKhoa], [TenBoMon], [Status], [IDcc]) VALUES (10, 1, N'1', 1, 1)
SET IDENTITY_INSERT [dbo].[BoMon] OFF
SET IDENTITY_INSERT [dbo].[ChuyenNganh] ON 

INSERT [dbo].[ChuyenNganh] ([ID], [IDKhoa], [TenChuyenNganh], [Status]) VALUES (1, 1, N'Công nghệ phần mềm', 0)
INSERT [dbo].[ChuyenNganh] ([ID], [IDKhoa], [TenChuyenNganh], [Status]) VALUES (2, 1, N'Hệ thống thông tin', 0)
INSERT [dbo].[ChuyenNganh] ([ID], [IDKhoa], [TenChuyenNganh], [Status]) VALUES (3, 1, N'An toàn thông tin', 0)
INSERT [dbo].[ChuyenNganh] ([ID], [IDKhoa], [TenChuyenNganh], [Status]) VALUES (4, 1, N'Đa phương tiện', 0)
INSERT [dbo].[ChuyenNganh] ([ID], [IDKhoa], [TenChuyenNganh], [Status]) VALUES (5, 1, N'Mạng máy tính', 0)
SET IDENTITY_INSERT [dbo].[ChuyenNganh] OFF
SET IDENTITY_INSERT [dbo].[DeTai] ON 

INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (13, N'Soi Lô AUTO1111', 1, 13, N'vailo', N'sdssdsdsd', 5, N'0', CAST(N'2018-01-02 23:20:18.157' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (14, N'Ahihihi[[[[[[[', 1, 13, N'vai', N'sdssdsdsd', 4, N'0', CAST(N'2018-01-03 00:23:23.157' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (15, N'Ahihihi', 2, 13, N'vai', N'sdssdsdsd', 5, N'0', CAST(N'2018-01-02 23:37:30.543' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (16, N'Ahihihi', 2, 13, N'vai', N'sdssdsdsd', 5, N'0', CAST(N'2018-01-02 23:39:55.397' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (17, N'ssssssssss', 2, 13, N'sssssssssss', N'ssssssssss', 4, N'0', CAST(N'2018-01-02 23:42:12.277' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (18, N'awdfrhgjmhytr', 2, 13, N'rgthjmghgrfe', N'gh,jjuthrew', 3, N'0', CAST(N'2018-01-02 23:43:10.180' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (19, N'ASDFGHJ', 2, 13, N'WERGTHYJ', N'WERGTHJ', 2, N'0', CAST(N'2018-01-02 23:45:53.847' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (20, N'DDDD', 2, 13, N'DDDDD', N'DDDDD', 3, N'0', CAST(N'2018-01-02 23:46:11.397' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (21, N'hhhhhhhhhhhhhh', 2, 13, N'rtryjuk', N'TYJKwergth', 2, N'0', CAST(N'2018-01-03 00:29:12.477' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (22, N'dddd', 2, 13, N'dddddddd', N'dddddddddd', 3, N'0', CAST(N'2018-01-03 00:12:13.370' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (23, N'cr', 2, 13, N'6u76iki', N'5y6ui', 4, N'0', CAST(N'2018-01-03 00:13:01.270' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (24, N'ghjm', 2, 13, N'kl;', N'nm', 3, N'0', CAST(N'2018-01-03 00:16:42.807' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (25, N'rrrrrrrrrr', 2, 13, N'rrrrrrrrrrr', N'rrrrrrrrrrrrrr', 4, N'0', CAST(N'2018-01-03 00:16:56.863' AS DateTime), NULL, 1)
INSERT [dbo].[DeTai] ([ID], [TenDeTai], [IDChuyenNganh], [IDGVDeXuat], [MoTa], [NoiDung], [DoKho], [TrangThai], [NgayTao], [IDNguoiTao], [Status]) VALUES (26, N'd', 2, 13, N'frgggg', N'fegbf', 3, N'0', CAST(N'2018-01-03 00:28:51.170' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[DeTai] OFF
SET IDENTITY_INSERT [dbo].[GiaoVien] ON 

INSERT [dbo].[GiaoVien] ([ID], [MaHienThi], [HoTen], [NgaySinh], [GioiTinh], [HocVi], [HocHam], [IDKhoa], [Status]) VALUES (13, 123456, N'Lê Trung Thực', CAST(N'1996-03-03 00:00:00.000' AS DateTime), 0, N'vvv', N'vvv', 1, 1)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
SET IDENTITY_INSERT [dbo].[HoiDong] ON 

INSERT [dbo].[HoiDong] ([ID], [TenHD], [IDKhoa], [NgayThanhLap], [NamHoc], [Status]) VALUES (1, N'Hội đồng bảo vệ 1', 1, CAST(N'2017-06-02 00:00:00.000' AS DateTime), N'2017-2018', 0)
INSERT [dbo].[HoiDong] ([ID], [TenHD], [IDKhoa], [NgayThanhLap], [NamHoc], [Status]) VALUES (2, N'Hội đồng bảo vệ 2', 1, CAST(N'2017-06-14 00:00:00.000' AS DateTime), N'2017-2018', 0)
INSERT [dbo].[HoiDong] ([ID], [TenHD], [IDKhoa], [NgayThanhLap], [NamHoc], [Status]) VALUES (3, N'Hội đồng bảo vệ 3 ', 1, CAST(N'2017-02-06 00:00:00.000' AS DateTime), N'2017-2018', 0)
INSERT [dbo].[HoiDong] ([ID], [TenHD], [IDKhoa], [NgayThanhLap], [NamHoc], [Status]) VALUES (4, N'Hội đồng bảo vệ 4', 1, CAST(N'2017-08-02 00:00:00.000' AS DateTime), N'2017-2018', 0)
INSERT [dbo].[HoiDong] ([ID], [TenHD], [IDKhoa], [NgayThanhLap], [NamHoc], [Status]) VALUES (5, N'Hội đồng bảo vệ 5', 1, CAST(N'2017-09-09 00:00:00.000' AS DateTime), N'2017-2018', 0)
SET IDENTITY_INSERT [dbo].[HoiDong] OFF
SET IDENTITY_INSERT [dbo].[Khoa] ON 

INSERT [dbo].[Khoa] ([ID], [TenKhoa], [Status]) VALUES (1, N'Công nghệ thông tin', 0)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [Status]) VALUES (2, N'Chế tạo máy', 0)
INSERT [dbo].[Khoa] ([ID], [TenKhoa], [Status]) VALUES (3, N'Ô tô', 0)
SET IDENTITY_INSERT [dbo].[Khoa] OFF
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([ID], [HoTen], [Lop], [IDChuyenNganh], [GioiTinh], [NgaySinh], [Email], [TCTL], [DiemTBTL], [Status]) VALUES (1000, N'Pham Huu Mai', N'13C', 1, 1, CAST(N'1996-01-01 00:00:00.000' AS DateTime), N'mai@gmail.com', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
SET IDENTITY_INSERT [dbo].[SinhVienDangKyDeTai] ON 

INSERT [dbo].[SinhVienDangKyDeTai] ([ID], [IDSinhVien], [LanDangKy], [IDDeTai], [NgayDangKy], [ChinhThuc], [IDHoiDong], [TrangThai]) VALUES (25, 1000, 1, 14, CAST(N'2017-12-09 19:32:06.507' AS DateTime), 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[SinhVienDangKyDeTai] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([ID], [MaHienThi], [MatKhau], [TenTaiKhoan], [Role], [IDRef]) VALUES (16, 1, N'123', N'123', 1, 1000)
INSERT [dbo].[TaiKhoan] ([ID], [MaHienThi], [MatKhau], [TenTaiKhoan], [Role], [IDRef]) VALUES (17, 2, N'124', N'123', 2, 13)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
/****** Object:  Index [idx_lastname]    Script Date: 1/3/2018 10:24:43 AM ******/
CREATE NONCLUSTERED INDEX [idx_lastname] ON [dbo].[BoMon]
(
	[IDKhoa] ASC,
	[IDcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_lastnamea]    Script Date: 1/3/2018 10:24:43 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [idx_lastnamea] ON [dbo].[BoMon]
(
	[IDKhoa] ASC,
	[IDcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SinhVienDangKyDeTai]    Script Date: 1/3/2018 10:24:43 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SinhVienDangKyDeTai] ON [dbo].[SinhVienDangKyDeTai]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SinhVienDangKyDeTai_INDEX]    Script Date: 1/3/2018 10:24:43 AM ******/
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
