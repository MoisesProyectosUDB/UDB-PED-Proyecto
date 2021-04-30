USE [master]
GO
/****** Object:  Database [DonBosco_PED]    Script Date: 4/17/2021 2:19:31 PM ******/
CREATE DATABASE [DonBosco_PED]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DonBosco_PED', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DonBosco_PED.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DonBosco_PED_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DonBosco_PED_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DonBosco_PED] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DonBosco_PED].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DonBosco_PED] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DonBosco_PED] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DonBosco_PED] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DonBosco_PED] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DonBosco_PED] SET ARITHABORT OFF 
GO
ALTER DATABASE [DonBosco_PED] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DonBosco_PED] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DonBosco_PED] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DonBosco_PED] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DonBosco_PED] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DonBosco_PED] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DonBosco_PED] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DonBosco_PED] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DonBosco_PED] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DonBosco_PED] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DonBosco_PED] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DonBosco_PED] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DonBosco_PED] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DonBosco_PED] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DonBosco_PED] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DonBosco_PED] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DonBosco_PED] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DonBosco_PED] SET RECOVERY FULL 
GO
ALTER DATABASE [DonBosco_PED] SET  MULTI_USER 
GO
ALTER DATABASE [DonBosco_PED] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DonBosco_PED] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DonBosco_PED] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DonBosco_PED] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DonBosco_PED] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DonBosco_PED] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DonBosco_PED', N'ON'
GO
ALTER DATABASE [DonBosco_PED] SET QUERY_STORE = OFF
GO
USE [DonBosco_PED]
GO
/****** Object:  Table [dbo].[Actividades]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividades](
	[IDActividades] [int] IDENTITY(1,1) NOT NULL,
	[NombreActividad] [varchar](225) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDActividades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActividadesMateria]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActividadesMateria](
	[IDActividadesMateria] [int] IDENTITY(1,1) NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdActividad] [int] NOT NULL,
	[FechaEntrega] [date] NOT NULL,
	[FechaHabilitida] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDActividadesMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarreraMateria]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarreraMateria](
	[IDCarreraMateria] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarreraMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarreraMateriaUsuario]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarreraMateriaUsuario](
	[IDCarreraMateriaUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdCarreraUsuario] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarreraMateriaUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[IDCarrera] [int] IDENTITY(1,1) NOT NULL,
	[NombreCarrera] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarreraUsuario]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarreraUsuario](
	[IDCarreraUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[Avance] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarreraUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[IDEstados] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEstados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IDMateria] [int] IDENTITY(1,1) NOT NULL,
	[NombreMateria] [varchar](255) NOT NULL,
	[CodigoMateria] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IDRol] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 4/17/2021 2:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [varchar](255) NOT NULL,
	[CorreoElectronico] [varchar](200) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[IdRol] [int] NOT NULL,
	[Carnet] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actividades] ON 
GO
INSERT [dbo].[Actividades] ([IDActividades], [NombreActividad]) VALUES (1, N'Tareas')
GO
INSERT [dbo].[Actividades] ([IDActividades], [NombreActividad]) VALUES (2, N'Foros')
GO
INSERT [dbo].[Actividades] ([IDActividades], [NombreActividad]) VALUES (3, N'Cuestionarios')
GO
INSERT [dbo].[Actividades] ([IDActividades], [NombreActividad]) VALUES (4, N'Parciales')
GO
INSERT [dbo].[Actividades] ([IDActividades], [NombreActividad]) VALUES (5, N'Reuniones')
GO
SET IDENTITY_INSERT [dbo].[Actividades] OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON 
GO
INSERT [dbo].[Estados] ([IDEstados], [Descripcion]) VALUES (1, N'Activo')
GO
INSERT [dbo].[Estados] ([IDEstados], [Descripcion]) VALUES (2, N'Retirado')
GO
INSERT [dbo].[Estados] ([IDEstados], [Descripcion]) VALUES (3, N'Aprobado')
GO
INSERT [dbo].[Estados] ([IDEstados], [Descripcion]) VALUES (4, N'Re-PROBADO')
GO
INSERT [dbo].[Estados] ([IDEstados], [Descripcion]) VALUES (5, N'Inactivo')
GO
SET IDENTITY_INSERT [dbo].[Estados] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([IDRol], [Descripcion]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[Roles] ([IDRol], [Descripcion]) VALUES (2, N'Profesor')
GO
INSERT [dbo].[Roles] ([IDRol], [Descripcion]) VALUES (3, N'Estudiante')
GO
INSERT [dbo].[Roles] ([IDRol], [Descripcion]) VALUES (4, N'Invitado')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([IDUsuario], [NombreCompleto], [CorreoElectronico], [Password], [Estado], [IdRol], [Carnet]) VALUES (1, N'Luis Moises Castillo', N'moisesudb17@gmail.com', N'123456789', 1, 1, N'CA140174')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario] ADD  DEFAULT ((1)) FOR [IdEstado]
GO
ALTER TABLE [dbo].[CarreraUsuario] ADD  DEFAULT ((1)) FOR [IdEstado]
GO
ALTER TABLE [dbo].[CarreraUsuario] ADD  DEFAULT ((0)) FOR [Avance]
GO
ALTER TABLE [dbo].[ActividadesMateria]  WITH CHECK ADD  CONSTRAINT [FK_ActividadesMateria1] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IDMateria])
GO
ALTER TABLE [dbo].[ActividadesMateria] CHECK CONSTRAINT [FK_ActividadesMateria1]
GO
ALTER TABLE [dbo].[ActividadesMateria]  WITH CHECK ADD  CONSTRAINT [FK_ActividadesMateria2] FOREIGN KEY([IdActividad])
REFERENCES [dbo].[Actividades] ([IDActividades])
GO
ALTER TABLE [dbo].[ActividadesMateria] CHECK CONSTRAINT [FK_ActividadesMateria2]
GO
ALTER TABLE [dbo].[CarreraMateria]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateria1] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IDMateria])
GO
ALTER TABLE [dbo].[CarreraMateria] CHECK CONSTRAINT [FK_CarreraMateria1]
GO
ALTER TABLE [dbo].[CarreraMateria]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateria2] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([IDCarrera])
GO
ALTER TABLE [dbo].[CarreraMateria] CHECK CONSTRAINT [FK_CarreraMateria2]
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateriaUsuario1] FOREIGN KEY([IdCarreraUsuario])
REFERENCES [dbo].[CarreraUsuario] ([IDCarreraUsuario])
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario] CHECK CONSTRAINT [FK_CarreraMateriaUsuario1]
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateriaUsuario2] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estados] ([IDEstados])
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario] CHECK CONSTRAINT [FK_CarreraMateriaUsuario2]
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateriaUsuario3] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IDMateria])
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario] CHECK CONSTRAINT [FK_CarreraMateriaUsuario3]
GO
ALTER TABLE [dbo].[CarreraUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraUsuario1] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IDUsuario])
GO
ALTER TABLE [dbo].[CarreraUsuario] CHECK CONSTRAINT [FK_CarreraUsuario1]
GO
ALTER TABLE [dbo].[CarreraUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraUsuario2] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([IDCarrera])
GO
ALTER TABLE [dbo].[CarreraUsuario] CHECK CONSTRAINT [FK_CarreraUsuario2]
GO
ALTER TABLE [dbo].[CarreraUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraUsuario3] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estados] ([IDEstados])
GO
ALTER TABLE [dbo].[CarreraUsuario] CHECK CONSTRAINT [FK_CarreraUsuario3]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_UusarioRol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([IDRol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_UusarioRol]
GO
USE [master]
GO
ALTER DATABASE [DonBosco_PED] SET  READ_WRITE 
GO
