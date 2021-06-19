USE [master]
GO
/****** Object:  Database [DonBosco_PED]    Script Date: 6/19/2021 1:25:37 AM ******/
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
/****** Object:  Table [dbo].[Actividades]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[ActividadesMateria]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[CarreraMateria]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[CarreraMateriaUsuario]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarreraMateriaUsuario](
	[IDCarreraMateriaUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdCarreraUsuario] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[IdCiclo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarreraMateriaUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[CarreraUsuario]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[Ciclo]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciclo](
	[IDCiclo] [int] IDENTITY(1,1) NOT NULL,
	[NombreCiclo] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCiclo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[Materias]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IDMateria] [int] IDENTITY(1,1) NOT NULL,
	[NombreMateria] [varchar](255) NOT NULL,
	[CodigoMateria] [varchar](25) NOT NULL,
	[Codigo] [int] NOT NULL,
	[posicion_x] [int] NULL,
	[posicion_Y] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenMaterias]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenMaterias](
	[IDOrdenMaterias] [int] IDENTITY(1,1) NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdMateriaOrigen] [int] NOT NULL,
	[IdMateriaDestino] [int] NOT NULL,
	[Peso] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDOrdenMaterias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/19/2021 1:25:38 AM ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/19/2021 1:25:38 AM ******/
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
ALTER TABLE [dbo].[CarreraMateriaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_CarreraMateriaUsuario4] FOREIGN KEY([IdCiclo])
REFERENCES [dbo].[Ciclo] ([IDCiclo])
GO
ALTER TABLE [dbo].[CarreraMateriaUsuario] CHECK CONSTRAINT [FK_CarreraMateriaUsuario4]
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
/****** Object:  StoredProcedure [dbo].[UDB_CargaCarreras]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargaCarreras]
as
select IDCarrera,NombreCarrera   from  Carreras;
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargaEstadosUsuarios]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UDB_CargaEstadosUsuarios]
as
select IDEstados, Descripcion from Estados where IDEstados in(1,5)
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargaMaestros]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargaMaestros]
as
select  c.NombreCompleto,c.Carnet,d.NombreCarrera,e.NombreMateria,e.CodigoMateria from  CarreraUsuario a inner join CarreraMateriaUsuario b
on a.IDCarreraUsuario=b.IdCarreraUsuario
inner join Usuarios c on a.IdUsuario=c.IDUsuario
inner join  Carreras d on a.IdCarrera=d.IDCarrera
inner join  Materias e on b.IdMateria=e.IDMateria
where c.IdRol=2;
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarCarrerasPorUsuario]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UDB_CargarCarrerasPorUsuario] 
@valor varchar(250)
 AS 
 SET XACT_ABORT ON



DECLARE @Resultado int



set @Resultado=0;
 
select  a.IDCarrera,a.NombreCarrera from Carreras a inner join CarreraUsuario b on a.IDCarrera=b.IdCarrera
													inner join Usuarios c on b.IdUsuario=c.IDUsuario
where c.Carnet=@valor

GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarEstudiantes]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargarEstudiantes]
as
select  c.NombreCompleto,c.Carnet,d.NombreCarrera,e.NombreMateria,e.CodigoMateria from  CarreraUsuario a inner join CarreraMateriaUsuario b
on a.IDCarreraUsuario=b.IdCarreraUsuario
inner join Usuarios c on a.IdUsuario=c.IDUsuario
inner join  Carreras d on a.IdCarrera=d.IDCarrera
inner join  Materias e on b.IdMateria=e.IDMateria
where c.IdRol=3;
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarMaterias]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargarMaterias]
as
select  b.NombreCarrera,c.CodigoMateria,c.NombreMateria from CarreraMateria a inner join Carreras b 
on a.IdCarrera=b.IDCarrera
inner join Materias c on a.IdMateria=c.IDMateria
group by  b.NombreCarrera,c.CodigoMateria,c.NombreMateria
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarMaterias2]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargarMaterias2]
as
select NombreMateria, CodigoMateria from Materias
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarMateriasPorCarrera]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_CargarMateriasPorCarrera] 
@idCarrera varchar(250),@g int
 AS 
 SET XACT_ABORT ON
 if @g=1
 begin
  select  B.Codigo AS 'IDMateria' ,CONCAT('(',b.CodigoMateria,')', b.NombreMateria) as 'NombreMateria'  from CarreraMateria a inner join Materias b 
 on a.IdMateria=b.IDMateria
 inner join Carreras  c on a.IdCarrera=c.IDCarrera
 where a.IdCarrera=@idCarrera AND posicion_x IS NOT NULL AND posicion_Y IS NOT NULL;
 end
 else 
 begin
  select  b.IDMateria AS 'IDMateria',CONCAT('(',b.CodigoMateria,')', b.NombreMateria) as 'NombreMateria'  from CarreraMateria a inner join Materias b 
 on a.IdMateria=b.IDMateria
 inner join Carreras  c on a.IdCarrera=c.IDCarrera
 where a.IdCarrera=@idCarrera;
 end


GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarMateriasPorCarreraUsuario]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_CargarMateriasPorCarreraUsuario] 
@Carnet varchar(250),@idCarrera varchar(250)
 AS 
 SET XACT_ABORT ON



DECLARE @Resultado int



set @Resultado=0;
 
 select e.IDMateria,CONCAT('(',e.CodigoMateria,')', e.NombreMateria) as 'NombreMateria' from   Usuarios a inner join  CarreraUsuario b on  a.IDUsuario=b.IdUsuario 
							inner join Carreras c on b.IdCarrera=c.IDCarrera
							inner join CarreraMateriaUsuario d on b.IDCarreraUsuario=d.IdCarreraUsuario
						    inner join Materias e on d.IdMateria=e.IDMateria						

where a.Carnet=@Carnet and b.IdCarrera=@idCarrera and  d.Idestado=1
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargaRoles]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UDB_CargaRoles]
as
select IDRol, Descripcion from Roles  
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargarUserTable]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargarUserTable]
as
select a.NombreCompleto,a.Carnet,a.CorreoElectronico,b.Descripcion from Usuarios a inner join  Roles b on a.IdRol=b.IDRol
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargaTipoActividades]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargaTipoActividades]
as
select   IDActividades, NombreActividad from Actividades
GO
/****** Object:  StoredProcedure [dbo].[UDB_CargaUsuariosAll]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UDB_CargaUsuariosAll]
as
select   IDUsuario, NombreCompleto  from   Usuarios;
GO
/****** Object:  StoredProcedure [dbo].[UDB_CarreraAdd]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cREATE PROCEDURE [dbo].[UDB_CarreraAdd] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @NombreCarrera varchar(250)

DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --='<Root><Request><NombreCarrera></NombreCarrera></Request><Response><Resultado></Resultado></Response></Root>'
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @NombreCarrera = NombreCarrera
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( NombreCarrera varchar(200) 'NombreCarrera'
    
	  )

set @Resultado=0;
 

Begin
insert into Carreras(NombreCarrera)
values(@NombreCarrera);

	if @@ROWCOUNT>0
	Begin
		set @Resultado=1;
	End
	else
	Begin
		set @Resultado=0;
	End
End




------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_InscripcionAdd]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UDB_InscripcionAdd] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @IdUsuario int
DECLARE @IdCarrera int
DECLARE @IdEstado  int
DECLARE @Avance    int
DECLARE @IdMateria int
DECLARE @IdCiclo   int
Declare @CarreraUsuario int

DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML /*=
'<Root>
	<Request>
		<Carrera>
			<IdUsuario></IdUsuario>
			<IdCarrera></IdCarrera>
			<IdEstado></IdEstado>
			<Avance></Avance>
		</Carrera>
		<Materia>
			<IdMateria></IdMateria>
			<IdCiclo></IdCiclo>
			<IdEstado></IdEstado>
		</Materia>

	</Request>
	<Response>
		<Resultado/>
	</Response>
</Root>'
*/
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @IdUsuario = IdUsuario,@IdCarrera=IdCarrera,@IdEstado=IdEstado,@Avance=Avance
FROM OpenXML(@iDoc,'//Root/Request/Carrera')
WITH ( IdUsuario int 'IdUsuario',
	   IdCarrera int 'IdCarrera',
	   IdEstado int 'IdEstado',
	   Avance int 'Avance'    
	  );

SELECT @IdMateria = IdMateria,@IdCiclo=IdCiclo
FROM OpenXML(@iDoc,'//Root/Request/Materia')
WITH ( IdMateria int 'IdMateria',
	   IdCiclo int 'IdCiclo',
	   IdEstado int 'IdEstado'
	       
	  );

set @Resultado=0;
 

Begin
	if exists (select 1 from  CarreraUsuario where IdUsuario=@IdUsuario and IdCarrera=@IdCarrera and IdEstado=1)
	Begin 
	 set @Resultado=2;--ya existe esta asociacion.
	END
	else 
	Begin
		 insert into CarreraUsuario(IdUsuario,IdCarrera,IdEstado,Avance)
		 values(@IdUsuario,@IdCarrera,@IdEstado,@Avance);

 			if @@ROWCOUNT>0
			Begin
				set @CarreraUsuario=SCOPE_IDENTITY();--devuelve el id insertado simpre y cuando sea identity
				insert into  CarreraMateriaUsuario(IdCarreraUsuario,IdMateria,IdEstado,idCiclo)
				values(@CarreraUsuario,@IdMateria,@IdEstado,@IdCiclo);
		 			if @@ROWCOUNT>0
					Begin
					 set @Resultado=1;
					end
			End
			else
			Begin
				set @Resultado=0;
			End
	End


END



------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_ListaMaterias]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UDB_ListaMaterias] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @IdUsuario int
DECLARE @IdCarrera int
DECLARE @IdEstado  int
DECLARE @Avance    int
DECLARE @IdMateria int
DECLARE @IdCiclo   int
Declare @CarreraUsuario int

DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML /*=
'<Root>
	<Request>
			<IdCarrera>1</IdCarrera>
	</Request>
	<Response>
		<Resultado/>
	</Response>
</Root>'*/

IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @IdCarrera=IdCarrera
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( 
	   IdCarrera int 'IdCarrera'  
	  );

set @Resultado=0;
 

 

-- select @IdCarrera

------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element], 
NULL							AS [Materia!4!codigo!element],
NULL							AS [Materia!4!x!element],
NULL							AS [Materia!4!y!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element],
NULL							AS [Materia!4!codigo!element],
NULL							AS [Materia!4!x!element],
NULL							AS [Materia!4!y!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado							AS [Response!3!Resultado!element],
NULL							AS [Materia!4!codigo!element],
NULL							AS [Materia!4!x!element],
NULL							AS [Materia!4!y!element]
 
UNION ALL
SELECT 4						AS Tag,   
3								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element],
Codigo							AS [Materia!4!codigo!element],
posicion_x							AS [Materia!4!x!element],
posicion_y							AS [Materia!4!y!element]
from Materias a inner join CarreraMateria b on a.IDMateria=b.IdMateria where b.IdCarrera=@IdCarrera



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_MateriaAdd]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_MateriaAdd] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @NombreMateria varchar(250)
DECLARE @CodigoMateria Varchar(15)
DECLARE @IdCarrera int
DECLARE @IdMateria int
DECLARE @Codigo int
DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --='<Root><Request><NombreMateria></NombreMateria><CodigoMateria></CodigoMateria><IdCarrera></IdCarrera></Request><Response><Resultado></Resultado></Response></Root>'
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @NombreMateria = NombreMateria,@CodigoMateria=CodigoMateria,@IdCarrera=IdCarrera
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( NombreMateria varchar(250) 'NombreMateria',
	   CodigoMateria varchar(15) 'CodigoMateria',
	   IdCarrera int 'IdCarrera'
    
	  )

set @Resultado=0;
set @Codigo=(select  isnull(max(codigo),0) from Materias)
if exists(select  1 from Materias where Codigo=0)
Begin
set @Codigo=@Codigo+1;
End

if exists(select 1 from Materias where  CodigoMateria=@CodigoMateria) 
Begin
set @Resultado=2;
End
ELSE
Begin
insert into Materias(NombreMateria,CodigoMateria,codigo)
values(@NombreMateria,@CodigoMateria,@Codigo);

	if @@ROWCOUNT>0
	Begin
	 set @IdMateria=SCOPE_IDENTITY();--devuelve el id insertado simpre y cuando sea identity
	 insert into CarreraMateria ( IdMateria, IdCarrera)values(@IdMateria,@IdCarrera)
		if @@ROWCOUNT>0
		Begin
			set @Resultado=1;
		End
		
	End
	else
	Begin
		set @Resultado=0;
	End
End




------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_MateriaUpdate]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_MateriaUpdate] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @posicion_x int
DECLARE @posicion_y int
DECLARE @IdCarrera int
DECLARE @IdMateria int
DECLARE @Codigo int
DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --='<Root><Request><NombreMateria></NombreMateria><CodigoMateria></CodigoMateria><IdCarrera></IdCarrera></Request><Response><Resultado></Resultado></Response></Root>'
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @posicion_x = posicion_x,@posicion_y=posicion_y,@IdCarrera=IdCarrera
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( posicion_x  int 'posicion_x',
	   posicion_y  int 'posicion_y',
	   IdCarrera int 'IdCarrera'
    
	  )

set @Resultado=0;
 

if exists(select 1 from Materias where   IDMateria=@IdCarrera and posicion_x is null and posicion_Y is null) 
Begin
update Materias set posicion_x=@posicion_x, posicion_y =@posicion_y where IDMateria=@IdCarrera;
set  @Resultado=1;
End
else
begin
set  @Resultado=2;
end




------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_OrdenADD]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_OrdenADD] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @IdMateriaOrigen  int
DECLARE @IdMateriaDestino int
DECLARE @Peso int
DECLARE @IdMateria int
 
DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --=''
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @IdMateriaOrigen= IdMateriaOrigen,@IdMateriaDestino=IdMateriaDestino,@Peso=Peso
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( IdMateriaOrigen int 'IdMateriaOrigen',
	   IdMateriaDestino int 'IdMateriaDestino',
	   Peso int 'Peso'	   
	  )

set @Resultado=0;
 
if exists(select 1 from OrdenMaterias where  IdMateriaOrigen=@IdMateriaOrigen and  IdMateriaDestino=@IdMateriaDestino) 
Begin
set @Resultado=2;
End
ELSE
Begin
set @IdMateria=(select  isnull(max(IdMateria),0) from OrdenMaterias)
if exists(select  1 from OrdenMaterias where  IdMateria=0)
Begin
set @IdMateria=@IdMateria+1;
End

insert into OrdenMaterias ( IdMateria,IdMateriaOrigen,IdMateriaDestino,Peso)
values(@IdMateria,@IdMateriaOrigen,@IdMateriaDestino,@Peso);

	if @@ROWCOUNT>0
	Begin
		set @Resultado=1;
	End
	else
	Begin
		set @Resultado=0;
	End
End




------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_UserAdd]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UDB_UserAdd] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @NombreCompleto varchar(250)
DECLARE @Correo Varchar(250)
DECLARE @Contra Varchar(max)
DECLARE @Estado int
DECLARE @Rol int
DECLARE @Carnet Varchar(15)
DECLARE @Resultado int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --='<Root><Request><NombreCompleto></NombreCompleto><Correo></Correo><Contra></Contra><Estado></Estado><Rol></Rol><Carnet></Carnet></Request><Response><Resultado></Resultado></Response></Root>'
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @NombreCompleto = NombreCompleto,@Correo=Correo,@Contra=Contra,@Estado=Estado,@Rol=Rol,@Carnet=Carnet
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( NombreCompleto varchar(200) 'NombreCompleto',
	   Correo varchar(250) 'Correo',
	   Contra varchar(max) 'Contra',
	   Estado int 'Estado',
	   Rol int 'Rol',
	   Carnet varchar(15) 'Carnet'
    
	  )

set @Resultado=0;
 
if exists(select 1 from Usuarios where Carnet=@Carnet or CorreoElectronico=@Correo) 
Begin
set @Resultado=2;
End
ELSE
Begin
insert into Usuarios (NombreCompleto,CorreoElectronico,Password,Estado,IdRol,Carnet)
values(@NombreCompleto,@Correo,@Contra,@Estado,@Rol,@Carnet);

	if @@ROWCOUNT>0
	Begin
		set @Resultado=1;
	End
	else
	Begin
		set @Resultado=0;
	End
End




------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
/****** Object:  StoredProcedure [dbo].[UDB_ValidacionLogin]    Script Date: 6/19/2021 1:25:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UDB_ValidacionLogin] 
 @SolicitudXML nText  
 AS 
 SET XACT_ABORT ON


-- DATOS DE CONTROL DEL XML
DECLARE @iDoc INT    
DECLARE @ErrorSave INT 
DECLARE @nReg INT  


SET @ErrorSave = 0   
--VARIABLES DE ENTRADA DEL XML
DECLARE @Usuario varchar(500)
DECLARE @Password Varchar(max)
DECLARE @Resultado int
DECLARE @TipoUsuario int




--Carga el Xml que recibe en la variable    
EXEC sp_xml_preparedocument @iDoc OUTPUT, @solicitudXML --='<Root><Request><Usuario></Usuario><Passwordd></Passwordd></Request><Response /></Root>'
IF (@@ERROR <> 0)  
SET @ErrorSave = @@ERROR 
SELECT @Usuario = Usuario,@Password=Passwordd
FROM OpenXML(@iDoc,'//Root/Request')
WITH ( Usuario varchar(10) 'Usuario',
	   Passwordd varchar(max) 'Passwordd'
    
	  )

set @Resultado=0;
if exists(select 1 from Usuarios where Carnet=@Usuario and  Password=@Password)
Begin
set @Resultado=1;
set @TipoUsuario=(select  IdRol from Usuarios where  Carnet=@Usuario and  Password=@Password)
End
  



------------------------------------------------------------------------------


SELECT 1						AS Tag,   
NULL							AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element],
NULL							AS [Response!3!TipoUsuario!element]

UNION ALL
SELECT 2						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
NULL							AS [Response!3!Resultado!element],
NULL							AS [Response!3!TipoUsuario!element]

UNION ALL
SELECT 3						AS Tag,   
1								AS Parent,   
NULL							AS [Root!1!ID],  
NULL							AS [Request!2!ID],  
@Resultado						AS [Response!3!Resultado!element],
@TipoUsuario					AS [Response!3!TipoUsuario!element]



FOR XML EXPLICIT
------------------------------------------------------------------------------

--Libera de Memoria el documento XML    
EXEC sp_xml_removedocument @iDoc    
IF (@@ERROR <> 0)    
SET @ErrorSave = @@ERROR  
RETURN @ErrorSave
GO
USE [master]
GO
ALTER DATABASE [DonBosco_PED] SET  READ_WRITE 
GO
