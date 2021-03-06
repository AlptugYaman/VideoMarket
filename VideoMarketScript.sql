USE [master]
GO
/****** Object:  Database [VideoMarket]    Script Date: 20.09.2015 13:08:16 ******/
CREATE DATABASE [VideoMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoMarket', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.BESIKTAS\MSSQL\DATA\VideoMarket.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoMarket_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.BESIKTAS\MSSQL\DATA\VideoMarket_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoMarket] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoMarket] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VideoMarket] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VideoMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoMarket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VideoMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoMarket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoMarket] SET  MULTI_USER 
GO
ALTER DATABASE [VideoMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoMarket] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [VideoMarket]
GO
/****** Object:  UserDefinedDataType [dbo].[adres]    Script Date: 20.09.2015 13:08:16 ******/
CREATE TYPE [dbo].[adres] FROM [varchar](150) NULL
GO
/****** Object:  StoredProcedure [dbo].[sp_DinamikTablo]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DinamikTablo]
@Tablo varchar(20) 
as 
execute ('select * from ' + @Tablo)

GO
/****** Object:  Table [dbo].[Filmler]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Filmler](
	[FilmNo] [int] IDENTITY(1,1) NOT NULL,
	[FilmAd] [varchar](50) NOT NULL,
	[FilmTurNo] [int] NOT NULL,
	[Yonetmen] [varchar](50) NULL,
	[Oyuncular] [varchar](150) NULL,
	[Ozet] [varchar](150) NULL,
	[Varmi] [bit] NOT NULL,
	[Miktar] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FilmNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FilmSatis]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmSatis](
	[SatisNo] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[FilmNo] [int] NOT NULL,
	[MusteriNo] [int] NOT NULL,
	[Adet] [int] NOT NULL,
	[BirimFiyat] [money] NOT NULL,
	[Silindi] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SatisNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FilmTurleri]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FilmTurleri](
	[FilmTurNo] [int] IDENTITY(1,1) NOT NULL,
	[TurAd] [varchar](50) NOT NULL,
	[Aciklama] [varchar](100) NULL,
	[Silindi] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FilmTurNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [varchar](20) NOT NULL,
	[MusteriSoyad] [varchar](20) NOT NULL,
	[Telefon] [varchar](20) NULL,
	[Adres] [varchar](150) NULL,
	[Silindi] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_DetayliFilmler]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_DetayliFilmler]
(FilminAdi,FilmTuru,Yapimci,Artistler,Stok)
as
select FilmAd,TurAd,Yonetmen,Oyuncular,Miktar from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo =Filmler.FilmTurNo


GO
/****** Object:  View [dbo].[vw_DetayliSatis]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vw_DetayliSatis] -- Encryption erişimi engellemek.
as
select FilmAd, MusteriAd + ' ' + MusteriSoyad as Müşteri, Adet, BirimFiyat, (Adet*BirimFiyat) as Tutar, (Adet*BirimFiyat*18/100) As KDV , ((Adet*BirimFiyat)+(Adet*BirimFiyat*18/100)) as KDVliTutar from FilmSatis as fs inner join Filmler as f on f.FilmNo = fs.FilmNo inner join Musteriler as m on fs.MusteriNo = m.MusteriNo 

GO
/****** Object:  View [dbo].[vw_Filmler]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Filmler]
AS
SELECT        dbo.Filmler.FilmNo, dbo.Filmler.FilmAd, dbo.FilmTurleri.TurAd, dbo.Filmler.Yonetmen, dbo.Filmler.Oyuncular, dbo.Filmler.Miktar
FROM            dbo.Filmler INNER JOIN
                         dbo.FilmTurleri ON dbo.Filmler.FilmTurNo = dbo.FilmTurleri.FilmTurNo


GO
/****** Object:  View [dbo].[vw_MusteriRehber]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_MusteriRehber]
as
Select MusteriAd + ' ' + MusteriSoyad as Musteri, Telefon from Musteriler


GO
/****** Object:  View [dbo].[vw_SatislarByMusteri]    Script Date: 20.09.2015 13:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_SatislarByMusteri]
AS
SELECT        dbo.Musteriler.MusteriAd + ' ' + dbo.Musteriler.MusteriSoyad AS Müşteri, SUM(dbo.FilmSatis.Adet * dbo.FilmSatis.BirimFiyat) AS Tutar
FROM            dbo.Filmler INNER JOIN
                         dbo.FilmSatis ON dbo.Filmler.FilmNo = dbo.FilmSatis.FilmNo INNER JOIN
                         dbo.Musteriler ON dbo.FilmSatis.MusteriNo = dbo.Musteriler.MusteriNo
GROUP BY dbo.Musteriler.MusteriAd + ' ' + dbo.Musteriler.MusteriSoyad


GO
SET IDENTITY_INSERT [dbo].[Filmler] ON 

INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (1, N'Orta Direk Şaban', 1, N'Kartal Tibet', N'Kemal Sunal', NULL, 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (2, N'Matrix', 6, N'Wachowski brothers', N'Keanu Reeves', N'Sanal Dünya', 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (3, N'Rocky 4', 4, N'Sylvester Stallone', N'Sylvester Stallone', N'', 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (4, N'Hangover', 1, N'Todd Philips', N'Zach Galifianakis', N'', 1, 5)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (5, N'Terminator', 6, N'James Cameron', N'Arnold Schwarzenegger', N'', 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (6, N'Gladyator', 8, N'Ridley Scot', N'Russel Crove', NULL, 0, 0)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (7, N'Truva', 8, N'Wolfgan Pettersen', N'Brad Pitt, Orlando Bloom', NULL, 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (8, N'Titanic', 9, N'James Cameron', N'Leonardo Di Caprio, Kate Winslet', N'', 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (9, N'Hızlı ve Öfkeli 7', 4, N'James Wan', N'Win Diesel', NULL, 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (10, N'Oceans Eleven', 4, N'Steven Spielberg', N'Brad Pitt, George Clooney', NULL, 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (11, N'Leon', 2, N'Luck Besson', N'Jean Reno, Natalie Portman', NULL, 1, 10)
INSERT [dbo].[Filmler] ([FilmNo], [FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Varmi], [Miktar]) VALUES (12, N'Yeşil Yol', 2, N'Tom Hanks', N'Tom Hanks', NULL, 0, 10)
SET IDENTITY_INSERT [dbo].[Filmler] OFF
SET IDENTITY_INSERT [dbo].[FilmSatis] ON 

INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (1, CAST(0x0000A478012D24CC AS DateTime), 9, 2, 1, 15.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (2, CAST(0x0000A478012D5747 AS DateTime), 11, 1, 3, 12.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (3, CAST(0x0000A478012D91CB AS DateTime), 1, 3, 1, 18.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (4, CAST(0x0000A478012DACFC AS DateTime), 1, 2, 3, 16.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (5, CAST(0x0000A479012DCFFF AS DateTime), 7, 4, 2, 14.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (6, CAST(0x0000A479012DEF13 AS DateTime), 3, 1, 1, 15.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (7, CAST(0x0000A479012E31B4 AS DateTime), 6, 4, 4, 9.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (8, CAST(0x0000A479012E9811 AS DateTime), 9, 1, 5, 8.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (9, CAST(0x0000A479012EB944 AS DateTime), 7, 3, 2, 15.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (10, CAST(0x0000A47A0129F722 AS DateTime), 5, 4, 2, 14.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (11, CAST(0x0000A47A0129F722 AS DateTime), 5, 2, 3, 13.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (12, CAST(0x0000A47A0129F722 AS DateTime), 8, 1, 1, 15.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (13, CAST(0x0000A47A0129F722 AS DateTime), 4, 3, 4, 12.0000, 0)
INSERT [dbo].[FilmSatis] ([SatisNo], [Tarih], [FilmNo], [MusteriNo], [Adet], [BirimFiyat], [Silindi]) VALUES (14, CAST(0x0000A47A0129F684 AS DateTime), 4, 1, 5, 11.0000, 0)
SET IDENTITY_INSERT [dbo].[FilmSatis] OFF
SET IDENTITY_INSERT [dbo].[FilmTurleri] ON 

INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (1, N'Komedi', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (2, N'Dram', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (3, N'Korku', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (4, N'Action', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (5, N'Romantik Komedi', N'hem komik hem romantik', 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (6, N'Bilim Kurgu', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (7, N'Polisiye', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (8, N'Savaş', N'kan, hırs ve entrikalar', 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (9, N'Aşk', NULL, 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (10, N'Animasyon', N'', 0)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (11, N'AAAAA', N'BBB', 1)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (12, N'aaaaaa', N'bbbbb', 1)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (13, N'222222222', N'111111111', 1)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (14, N'qw', N'aq', 1)
INSERT [dbo].[FilmTurleri] ([FilmTurNo], [TurAd], [Aciklama], [Silindi]) VALUES (15, N'aq1', N'aq1', 1)
SET IDENTITY_INSERT [dbo].[FilmTurleri] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAd], [MusteriSoyad], [Telefon], [Adres], [Silindi]) VALUES (1, N'Ali', N'Uçar', N'5334545478', N'Güngören - İstanbul', 0)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAd], [MusteriSoyad], [Telefon], [Adres], [Silindi]) VALUES (2, N'Yusuf', N'Cesur', N'5325545471', N'Fatih - İstanbul', 0)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAd], [MusteriSoyad], [Telefon], [Adres], [Silindi]) VALUES (3, N'Nazım', N'Tüfekçi', N'2163454547', N'Kadıköy - İstanbul', 0)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAd], [MusteriSoyad], [Telefon], [Adres], [Silindi]) VALUES (4, N'Ayşe', N'Koşar', N'2123454542', N'Bakırköy - İstanbul', 0)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAd], [MusteriSoyad], [Telefon], [Adres], [Silindi]) VALUES (6, N'Alptuğ ;))', N'Yaman', N'5419400596', N'Yenibosna - İstanbul', 0)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
ALTER TABLE [dbo].[Filmler] ADD  DEFAULT ((1)) FOR [Varmi]
GO
ALTER TABLE [dbo].[Filmler] ADD  DEFAULT ((10)) FOR [Miktar]
GO
ALTER TABLE [dbo].[FilmSatis] ADD  DEFAULT (getdate()) FOR [Tarih]
GO
ALTER TABLE [dbo].[FilmSatis] ADD  DEFAULT ((1)) FOR [Adet]
GO
ALTER TABLE [dbo].[FilmSatis] ADD  DEFAULT ((0)) FOR [BirimFiyat]
GO
ALTER TABLE [dbo].[FilmSatis] ADD  CONSTRAINT [DF_FilmSatis_Silindi]  DEFAULT ((0)) FOR [Silindi]
GO
ALTER TABLE [dbo].[FilmTurleri] ADD  CONSTRAINT [DF_FilmTurleri_Silindi]  DEFAULT ((0)) FOR [Silindi]
GO
ALTER TABLE [dbo].[Musteriler] ADD  CONSTRAINT [DF_Musteriler_Silindi]  DEFAULT ((0)) FOR [Silindi]
GO
ALTER TABLE [dbo].[Filmler]  WITH CHECK ADD  CONSTRAINT [FK_Filmler_FilmTurleri] FOREIGN KEY([FilmTurNo])
REFERENCES [dbo].[FilmTurleri] ([FilmTurNo])
GO
ALTER TABLE [dbo].[Filmler] CHECK CONSTRAINT [FK_Filmler_FilmTurleri]
GO
ALTER TABLE [dbo].[FilmSatis]  WITH CHECK ADD  CONSTRAINT [FK_FilmSatis_Filmler] FOREIGN KEY([FilmNo])
REFERENCES [dbo].[Filmler] ([FilmNo])
GO
ALTER TABLE [dbo].[FilmSatis] CHECK CONSTRAINT [FK_FilmSatis_Filmler]
GO
ALTER TABLE [dbo].[FilmSatis]  WITH CHECK ADD  CONSTRAINT [FK_FilmSatis_Musteriler] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[Musteriler] ([MusteriNo])
GO
ALTER TABLE [dbo].[FilmSatis] CHECK CONSTRAINT [FK_FilmSatis_Musteriler]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Filmler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "FilmTurleri"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Filmler'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Filmler'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[26] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Filmler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FilmSatis"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Musteriler"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2895
         Alias = 1365
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_SatislarByMusteri'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_SatislarByMusteri'
GO
USE [master]
GO
ALTER DATABASE [VideoMarket] SET  READ_WRITE 
GO
