USE [master]
GO
/****** Object:  Database [VideoRentalProject]    Script Date: 10/28/2020 5:36:41 AM ******/
CREATE DATABASE [VideoRentalProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalProject_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRentalProject_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalProject.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRentalProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRentalProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalProject] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalProject] SET QUERY_STORE = OFF
GO
USE [VideoRentalProject]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 10/28/2020 5:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Rental]    Script Date: 10/28/2020 5:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Rental](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[C_Id] [int] NULL,
	[M_Id] [int] NULL,
	[IssueDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Rental] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Video]    Script Date: 10/28/2020 5:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Video](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Video] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Customer] ON 

INSERT [dbo].[tbl_Customer] ([id], [Name], [Email], [Mobile], [Address]) VALUES (1, N'sona', N'soni@gmailcom', N'78945', N'nz')
SET IDENTITY_INSERT [dbo].[tbl_Customer] OFF
SET IDENTITY_INSERT [dbo].[tbl_Rental] ON 

INSERT [dbo].[tbl_Rental] ([id], [C_Id], [M_Id], [IssueDate], [ReturnDate]) VALUES (2, 1, 1, N'9/4/2020', N'booked')
SET IDENTITY_INSERT [dbo].[tbl_Rental] OFF
SET IDENTITY_INSERT [dbo].[tbl_Video] ON 

INSERT [dbo].[tbl_Video] ([id], [Title], [Ratting], [Year], [Cost], [Copies], [Genre]) VALUES (1, N'singham', N'2.3', N'2019', N'5', N'3', N'action')
SET IDENTITY_INSERT [dbo].[tbl_Video] OFF
USE [master]
GO
ALTER DATABASE [VideoRentalProject] SET  READ_WRITE 
GO
