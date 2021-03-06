USE [QLNhanKhau_DB]
GO
/****** Object:  Table [dbo].[CauHinhChung]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHinhChung](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TuKhoa] [nvarchar](150) NOT NULL,
	[GiaTri] [ntext] NOT NULL,
 CONSTRAINT [PK_CauHinhChung] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucDuong]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucDuong](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](250) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_ThietLapDuong] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucKhuPho]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucKhuPho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](150) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_ThietLapKhuPho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucKhuVuc]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucKhuVuc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](250) NOT NULL,
	[MaKhuPho] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_DanhMucKhuVuc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucToDanPho]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucToDanPho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](150) NOT NULL,
	[MaKhuVuc] [int] NOT NULL,
	[MaKhuPho] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_DanhMucToDanPho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoKhau]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoKhau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](250) NOT NULL,
	[DiaChi] [nvarchar](500) NOT NULL,
	[MaToDanPho] [int] NOT NULL,
	[MaKhuVuc] [int] NOT NULL,
	[MaTinhTrangNhaO] [int] NOT NULL,
	[MaLoaiHoSo] [int] NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[NgayCapNhat] [date] NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_HoKhau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHoSo]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHoSo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](250) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiHoSo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDung] [nvarchar](250) NOT NULL,
	[TenDangNhap] [nvarchar](150) NOT NULL,
	[MatKhau] [nvarchar](150) NOT NULL,
	[ChucVu] [nvarchar](150) NOT NULL,
	[QuyenHan] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanKhau]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanKhau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaChuHo] [int] NOT NULL,
	[TenVietTat] [nvarchar](50) NOT NULL,
	[TenDayDu] [nvarchar](250) NOT NULL,
	[NgaySinh] [char](10) NULL,
	[ThangSinh] [char](10) NULL,
	[NamSinh] [nchar](10) NOT NULL,
	[GioiTinh] [nvarchar](150) NOT NULL,
	[CMND] [char](10) NOT NULL,
	[HoKhauThuongTru] [nvarchar](250) NOT NULL,
	[DenTuNoi] [nvarchar](250) NOT NULL,
	[NgheNghiep] [nvarchar](150) NOT NULL,
	[QuanHeChuHo] [nvarchar](150) NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[NgayCapNhat] [date] NULL,
 CONSTRAINT [PK_NhanKhau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TinhTrangCuTru]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangCuTru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrangCuTru] [nvarchar](250) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_TinhTrangCuTru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinhTrangNhaO]    Script Date: 1/29/2016 3:03:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangNhaO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrangNhaO] [nvarchar](250) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_TinhTrangNhaO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DanhMucDuong] ADD  CONSTRAINT [DF_ThietLapDuong_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DanhMucKhuPho] ADD  CONSTRAINT [DF_DanhMucKhuPho_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DanhMucKhuVuc] ADD  CONSTRAINT [DF_DanhMucKhuVuc_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DanhMucToDanPho] ADD  CONSTRAINT [DF_DanhMucToDanPho_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HoKhau] ADD  CONSTRAINT [DF_HoKhau_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[LoaiHoSo] ADD  CONSTRAINT [DF_LoaiHoSo_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [DF_NguoiDung_IsActived]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[TinhTrangCuTru] ADD  CONSTRAINT [DF_TinhTrangCuTru_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[TinhTrangNhaO] ADD  CONSTRAINT [DF_TinhTrangNhaO_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DanhMucKhuVuc]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucKhuVuc_DanhMucKhuPho] FOREIGN KEY([MaKhuPho])
REFERENCES [dbo].[DanhMucKhuPho] ([Id])
GO
ALTER TABLE [dbo].[DanhMucKhuVuc] CHECK CONSTRAINT [FK_DanhMucKhuVuc_DanhMucKhuPho]
GO
ALTER TABLE [dbo].[DanhMucToDanPho]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucToDanPho_DanhMucKhuPho] FOREIGN KEY([MaKhuPho])
REFERENCES [dbo].[DanhMucKhuPho] ([Id])
GO
ALTER TABLE [dbo].[DanhMucToDanPho] CHECK CONSTRAINT [FK_DanhMucToDanPho_DanhMucKhuPho]
GO
ALTER TABLE [dbo].[DanhMucToDanPho]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucToDanPho_DanhMucKhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[DanhMucKhuVuc] ([Id])
GO
ALTER TABLE [dbo].[DanhMucToDanPho] CHECK CONSTRAINT [FK_DanhMucToDanPho_DanhMucKhuVuc]
GO
ALTER TABLE [dbo].[HoKhau]  WITH CHECK ADD  CONSTRAINT [FK_HoKhau_DanhMucKhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[DanhMucKhuVuc] ([Id])
GO
ALTER TABLE [dbo].[HoKhau] CHECK CONSTRAINT [FK_HoKhau_DanhMucKhuVuc]
GO
ALTER TABLE [dbo].[HoKhau]  WITH CHECK ADD  CONSTRAINT [FK_HoKhau_DanhMucToDanPho] FOREIGN KEY([MaToDanPho])
REFERENCES [dbo].[DanhMucToDanPho] ([Id])
GO
ALTER TABLE [dbo].[HoKhau] CHECK CONSTRAINT [FK_HoKhau_DanhMucToDanPho]
GO
ALTER TABLE [dbo].[HoKhau]  WITH CHECK ADD  CONSTRAINT [FK_HoKhau_LoaiHoSo] FOREIGN KEY([MaLoaiHoSo])
REFERENCES [dbo].[LoaiHoSo] ([Id])
GO
ALTER TABLE [dbo].[HoKhau] CHECK CONSTRAINT [FK_HoKhau_LoaiHoSo]
GO
ALTER TABLE [dbo].[HoKhau]  WITH CHECK ADD  CONSTRAINT [FK_HoKhau_TinhTrangNhaO] FOREIGN KEY([MaTinhTrangNhaO])
REFERENCES [dbo].[TinhTrangNhaO] ([Id])
GO
ALTER TABLE [dbo].[HoKhau] CHECK CONSTRAINT [FK_HoKhau_TinhTrangNhaO]
GO
ALTER TABLE [dbo].[NhanKhau]  WITH CHECK ADD  CONSTRAINT [FK_NhanKhau_HoKhau] FOREIGN KEY([MaChuHo])
REFERENCES [dbo].[HoKhau] ([Id])
GO
ALTER TABLE [dbo].[NhanKhau] CHECK CONSTRAINT [FK_NhanKhau_HoKhau]
GO
