USE [QuanLyDoAnTotNghiep]
GO
/****** Object:  Table [dbo].[BaoCaoTienDo]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[BienBanBaoVe]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[BoMon]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[DeTai]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[HoiDong]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[HoiDongGiaoVien]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[SinhVienDangKyDeTai]    Script Date: 12/10/2017 4:19:57 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/10/2017 4:19:57 PM ******/
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
