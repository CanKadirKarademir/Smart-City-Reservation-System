USE [master]
GO
/****** Object:  Database [TheEyeDB]    Script Date: 29.11.2019 02:08:22 ******/
CREATE DATABASE [TheEyeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TheEyeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\TheEyeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TheEyeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\TheEyeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TheEyeDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TheEyeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TheEyeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TheEyeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TheEyeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TheEyeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TheEyeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TheEyeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TheEyeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TheEyeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TheEyeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TheEyeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TheEyeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TheEyeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TheEyeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TheEyeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TheEyeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TheEyeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TheEyeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TheEyeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TheEyeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TheEyeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TheEyeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TheEyeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TheEyeDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TheEyeDB] SET  MULTI_USER 
GO
ALTER DATABASE [TheEyeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TheEyeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TheEyeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TheEyeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TheEyeDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TheEyeDB', N'ON'
GO
ALTER DATABASE [TheEyeDB] SET QUERY_STORE = OFF
GO
USE [TheEyeDB]
GO
/****** Object:  Table [dbo].[CarParks]    Script Date: 29.11.2019 02:08:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarParks](
	[CarParkID] [int] IDENTITY(1,1) NOT NULL,
	[CarParkMax] [int] NULL,
	[CarParkDisabled] [bit] NULL,
	[CarParkWashing] [nvarchar](50) NULL,
	[CarParkTire] [nvarchar](50) NULL,
	[CarParkFloor] [tinyint] NULL,
	[CompanyID] [int] NULL,
 CONSTRAINT [PK_CarParks] PRIMARY KEY CLUSTERED 
(
	[CarParkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CompanyPhone] [nchar](11) NULL,
	[CompanyMail] [nvarchar](50) NULL,
	[CompanyAdress] [nvarchar](200) NULL,
	[CompanyCity] [nvarchar](50) NULL,
	[CompanyDistrict] [nvarchar](50) NULL,
	[CompanyTime] [date] NULL,
	[CompanyType] [nvarchar](50) NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[MedicineID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineName] [nvarchar](50) NULL,
	[MedicinePrescription] [nvarchar](50) NULL,
	[MedicineType] [nvarchar](50) NULL,
	[MedicinePiece] [nvarchar](50) NULL,
	[CompanyID] [int] NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[MedicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetrolStation]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetrolStation](
	[PetrolID] [int] IDENTITY(1,1) NOT NULL,
	[PetrolFuelType] [nvarchar](50) NULL,
	[PetrolMarkets] [nvarchar](50) NULL,
	[PetrolWashing] [nvarchar](50) NULL,
	[PetrolTire] [nvarchar](50) NULL,
	[CompanyID] [int] NULL,
 CONSTRAINT [PK_PetrolStation] PRIMARY KEY CLUSTERED 
(
	[PetrolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationTime] [date] NULL,
	[CompanyID] [int] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sss]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sss](
	[SssID] [int] IDENTITY(1,1) NOT NULL,
	[SssQuestion] [nvarchar](100) NULL,
	[SssReply] [nvarchar](50) NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
 CONSTRAINT [PK_Sss] PRIMARY KEY CLUSTERED 
(
	[SssID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29.11.2019 02:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserYears] [int] NULL,
	[UserGender] [bit] NULL,
	[UserPassword] [nvarchar](10) NULL,
	[UserRestartPassword] [nvarchar](10) NULL,
	[UserPhone] [nchar](11) NULL,
	[UserMail] [nvarchar](50) NULL,
	[UserCity] [nvarchar](50) NULL,
	[UserDistrict] [nvarchar](50) NULL,
	[UserAdress] [nvarchar](200) NULL,
	[UserType] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarParks]  WITH CHECK ADD  CONSTRAINT [FK_CarParks_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[CarParks] CHECK CONSTRAINT [FK_CarParks_Company]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_Users]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Company]
GO
ALTER TABLE [dbo].[PetrolStation]  WITH CHECK ADD  CONSTRAINT [FK_PetrolStation_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[PetrolStation] CHECK CONSTRAINT [FK_PetrolStation_Company]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Users]
GO
ALTER TABLE [dbo].[Sss]  WITH CHECK ADD  CONSTRAINT [FK_Sss_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Sss] CHECK CONSTRAINT [FK_Sss_Company]
GO
ALTER TABLE [dbo].[Sss]  WITH CHECK ADD  CONSTRAINT [FK_Sss_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sss] CHECK CONSTRAINT [FK_Sss_Users]
GO
USE [master]
GO
ALTER DATABASE [TheEyeDB] SET  READ_WRITE 
GO
