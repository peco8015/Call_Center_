USE [master]
GO
/****** Object:  Database [Base_CallCenter]    Script Date: 03/11/2016 15:52:18 ******/
CREATE DATABASE [Base_CallCenter] ON  PRIMARY 
( NAME = N'Base_CallCenter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Base_CallCenter.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Base_CallCenter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Base_CallCenter_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Base_CallCenter] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Base_CallCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Base_CallCenter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Base_CallCenter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Base_CallCenter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Base_CallCenter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Base_CallCenter] SET ARITHABORT OFF 
GO
ALTER DATABASE [Base_CallCenter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Base_CallCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Base_CallCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Base_CallCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Base_CallCenter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Base_CallCenter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Base_CallCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Base_CallCenter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Base_CallCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Base_CallCenter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Base_CallCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Base_CallCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Base_CallCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Base_CallCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Base_CallCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Base_CallCenter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Base_CallCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Base_CallCenter] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Base_CallCenter] SET  MULTI_USER 
GO
ALTER DATABASE [Base_CallCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Base_CallCenter] SET DB_CHAINING OFF 
GO
USE [Base_CallCenter]
GO
/****** Object:  Table [dbo].[campaña]    Script Date: 03/11/2016 15:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[campaña](
	[id_campaña] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [decimal](18, 2) NOT NULL,
	[f_inicio] [date] NOT NULL,
	[f_finliza] [nchar](10) NULL,
	[nombreCliente] [nchar](10) NOT NULL,
 CONSTRAINT [PK_campaña] PRIMARY KEY CLUSTERED 
(
	[id_campaña] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contacto]    Script Date: 03/11/2016 15:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contacto](
	[id_contacto] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[ocupacion] [varchar](50) NULL,
	[estado_civil] [varchar](50) NULL,
	[nacionalidad] [varchar](50) NOT NULL,
	[provincia] [varchar](50) NULL,
 CONSTRAINT [PK_contacto] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 03/11/2016 15:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[f_comienza] [date] NOT NULL,
	[jefe] [int] NOT NULL,
	[password] [varchar](50) NOT NULL,
	[f_nacimiento] [date] NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[llamada]    Script Date: 03/11/2016 15:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[llamada](
	[id_llamada] [int] NOT NULL,
	[id_contacto] [int] NOT NULL,
	[id_campaña] [int] NOT NULL,
	[duracion] [time](7) NOT NULL,
	[devolver] [bit] NOT NULL,
	[observaciones] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_empleado] [int] NOT NULL,
 CONSTRAINT [PK_llamada] PRIMARY KEY CLUSTERED 
(
	[id_llamada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venta]    Script Date: 03/11/2016 15:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] NOT NULL,
	[id_llamada] [int] NOT NULL,
	[fecha_venta] [date] NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_empleado] FOREIGN KEY([jefe])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_empleado]
GO
ALTER TABLE [dbo].[llamada]  WITH CHECK ADD  CONSTRAINT [FK_llamada_campaña] FOREIGN KEY([id_campaña])
REFERENCES [dbo].[campaña] ([id_campaña])
GO
ALTER TABLE [dbo].[llamada] CHECK CONSTRAINT [FK_llamada_campaña]
GO
ALTER TABLE [dbo].[llamada]  WITH CHECK ADD  CONSTRAINT [FK_llamada_contacto] FOREIGN KEY([id_contacto])
REFERENCES [dbo].[contacto] ([id_contacto])
GO
ALTER TABLE [dbo].[llamada] CHECK CONSTRAINT [FK_llamada_contacto]
GO
ALTER TABLE [dbo].[llamada]  WITH CHECK ADD  CONSTRAINT [FK_llamada_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[llamada] CHECK CONSTRAINT [FK_llamada_empleado]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_llamada] FOREIGN KEY([id_llamada])
REFERENCES [dbo].[llamada] ([id_llamada])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_llamada]
GO
USE [master]
GO
ALTER DATABASE [Base_CallCenter] SET  READ_WRITE 
GO
