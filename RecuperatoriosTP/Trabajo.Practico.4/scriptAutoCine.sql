USE [master]
GO
/****** Object:  Database [AutoCine]    Script Date: 30/11/2020 06:44:51 ******/
CREATE DATABASE [AutoCine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoCine', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS03\MSSQL\DATA\AutoCine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoCine_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS03\MSSQL\DATA\AutoCine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AutoCine] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoCine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoCine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoCine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoCine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoCine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoCine] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoCine] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoCine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoCine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoCine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoCine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoCine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoCine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoCine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoCine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoCine] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoCine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoCine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoCine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoCine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoCine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoCine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoCine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoCine] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AutoCine] SET  MULTI_USER 
GO
ALTER DATABASE [AutoCine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoCine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoCine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoCine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoCine] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoCine] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AutoCine] SET QUERY_STORE = OFF
GO
USE [AutoCine]
GO
/****** Object:  Table [dbo].[Cartelera]    Script Date: 30/11/2020 06:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cartelera](
	[Pelicula] [varchar](50) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estacionamiento]    Script Date: 30/11/2020 06:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estacionamiento](
	[Ubicacion] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'El Origen', N'CienciaFiccion', 400)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Midsommar', N'Drama', 450)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Coco', N'Infantil', 350)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Coco 3D', N'Infantil', 500)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'La Isla Siniestra', N'Suspenso', 350)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Titanic', N'Romance', 200)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Orgullo y Prejuicio', N'Romance', 250)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Hercules', N'Infantil', 250)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Narnia', N'Otro', 200)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Climax', N'Drama', 400)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'En la Hierba Alta', N'Suspenso', 380)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'Avatar', N'CienciaFiccion', 300)
INSERT [dbo].[Cartelera] ([Pelicula], [Genero], [Precio]) VALUES (N'2012', N'Drama', 200)
GO
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'A1', 250)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'A2', 250)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'A3', 250)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'B1', 200)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'B2', 200)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'B3', 200)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'C1', 150)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'C2', 150)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'C3', 150)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'D1', 100)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'D2', 100)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'D3', 100)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'E1', 80)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'E2', 80)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'E3', 80)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'F1', 50)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'F2', 50)
INSERT [dbo].[Estacionamiento] ([Ubicacion], [Precio]) VALUES (N'F3', 50)
GO
USE [master]
GO
ALTER DATABASE [AutoCine] SET  READ_WRITE 
GO
