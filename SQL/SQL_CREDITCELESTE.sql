USE IF EXISTS [CREDIT_CELESTE]

GO

/****** Object:  Database [CREDIT_CELESTE]    Script Date: 29/04/2019 13:15:50 ******/
DROP DATABASE IF EXISTS [CREDIT_CELESTE]
CREATE DATABASE [CREDIT_CELESTE]

 CONTAINMENT = NONE

 ON  PRIMARY 

( NAME = N'CREDIT_CELESTE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CREDIT_CELESTE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )

 LOG ON 

( NAME = N'CREDIT_CELESTE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CREDIT_CELESTE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )

GO

ALTER DATABASE [CREDIT_CELESTE] SET COMPATIBILITY_LEVEL = 140

GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))

begin

EXEC [CREDIT_CELESTE].[dbo].[sp_fulltext_database] @action = 'enable'

end

GO

ALTER DATABASE [CREDIT_CELESTE] SET ANSI_NULL_DEFAULT OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET ANSI_NULLS OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET ANSI_PADDING OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET ANSI_WARNINGS OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET ARITHABORT OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET AUTO_CLOSE OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET AUTO_SHRINK OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET AUTO_UPDATE_STATISTICS ON 

GO

ALTER DATABASE [CREDIT_CELESTE] SET CURSOR_CLOSE_ON_COMMIT OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET CURSOR_DEFAULT  GLOBAL 

GO

ALTER DATABASE [CREDIT_CELESTE] SET CONCAT_NULL_YIELDS_NULL OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET NUMERIC_ROUNDABORT OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET QUOTED_IDENTIFIER OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET RECURSIVE_TRIGGERS OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET  DISABLE_BROKER 

GO

ALTER DATABASE [CREDIT_CELESTE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET DATE_CORRELATION_OPTIMIZATION OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET TRUSTWORTHY OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET ALLOW_SNAPSHOT_ISOLATION OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET PARAMETERIZATION SIMPLE 

GO

ALTER DATABASE [CREDIT_CELESTE] SET READ_COMMITTED_SNAPSHOT OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET HONOR_BROKER_PRIORITY OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET RECOVERY FULL 

GO

ALTER DATABASE [CREDIT_CELESTE] SET  MULTI_USER 

GO

ALTER DATABASE [CREDIT_CELESTE] SET PAGE_VERIFY CHECKSUM  

GO

ALTER DATABASE [CREDIT_CELESTE] SET DB_CHAINING OFF 

GO

ALTER DATABASE [CREDIT_CELESTE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

GO

ALTER DATABASE [CREDIT_CELESTE] SET TARGET_RECOVERY_TIME = 60 SECONDS 

GO

ALTER DATABASE [CREDIT_CELESTE] SET DELAYED_DURABILITY = DISABLED 

GO

EXEC sys.sp_db_vardecimal_storage_format N'CREDIT_CELESTE', N'ON'

GO

ALTER DATABASE [CREDIT_CELESTE] SET QUERY_STORE = OFF

GO

USE [CREDIT_CELESTE]

GO

/****** Object:  Table [dbo].[CLIENT]    Script Date: 29/04/2019 13:15:50 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[CLIENT](

	[nomClient] [varchar](50) NULL,

	[prenomClient] [varchar](50) NULL,

	[numRueClient] [varchar](50) NULL,

	[RueClient] [varchar](50) NULL,

	[CPClient] [varchar](50) NULL,

	[mailClient] [nchar](20) NULL,

	[numClient] [int] IDENTITY(0,1) NOT NULL,

	[villeClient] [nchar](50) NULL,

 CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED 

(

	[numClient] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[commissionner]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[commissionner](

	[CodeNiveau] [int] NOT NULL,

	[MtFin] [float] NOT NULL,

	[NbMens] [int] NOT NULL,

 CONSTRAINT [commissionner_PK] PRIMARY KEY CLUSTERED 

(

	[CodeNiveau] ASC,

	[MtFin] ASC,

	[NbMens] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CONCESSION]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[CONCESSION](

	[idConcession] [int] NOT NULL,

	[nomConcession] [varchar](50) NOT NULL,

	[numRueConcession] [int] NOT NULL,

	[rueConcession] [varchar](50) NOT NULL,

	[CPConcession] [int] NOT NULL,

	[villeConcession] [varchar](50) NOT NULL,

 CONSTRAINT [CONCESSION_PK] PRIMARY KEY CLUSTERED 

(

	[idConcession] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CREDIT]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[CREDIT](

	[montantFinance] [int] NULL,

	[dureeCredit] [varchar](50) NULL,

	[tauxCredit] [int] NULL,

	[mensualiteCredit] [int] NULL,

	[idVendeur] [int] NULL,

	[numClient] [int] NULL,

	[CodeNiveau] [int] NULL,

	[dateSouscription] [datetime] NULL,

	[numCredit] [int] IDENTITY(1,1) NOT NULL,

 CONSTRAINT [PK_CREDIT] PRIMARY KEY CLUSTERED 

(

	[numCredit] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[MTFIN]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[MTFIN](

	[MtFin] [float] NOT NULL,

	[numClient] [int] NOT NULL,

 CONSTRAINT [MTFIN_PK] PRIMARY KEY CLUSTERED 

(

	[MtFin] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NBMENS]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[NBMENS](

	[NbMens] [int] NOT NULL,

 CONSTRAINT [NBMENS_PK] PRIMARY KEY CLUSTERED 

(

	[NbMens] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NIVEAU]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[NIVEAU](

	[CodeNiveau] [int] NOT NULL,

	[Libelle] [varchar](50) NOT NULL,

	[TauxCommission] [float] NOT NULL,

 CONSTRAINT [NIVEAU_PK] PRIMARY KEY CLUSTERED 

(

	[CodeNiveau] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[VEHICULE]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[VEHICULE](

	[numImmat] [varchar](50) NOT NULL,

	[datePremImmat] [varchar](50) NOT NULL,

	[anneeModele] [varchar](50) NOT NULL,

	[numSerie] [varchar](50) NOT NULL,

	[puissance] [varchar](50) NOT NULL,

	[numClient] [int] NULL,

	[idVendeur] [int] NULL,

	[idConcession] [int] NOT NULL,

 CONSTRAINT [VEHICULE_PK] PRIMARY KEY CLUSTERED 

(

	[numImmat] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[VENDEUR]    Script Date: 29/04/2019 13:15:51 ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[VENDEUR](

	[idVendeur] [int] IDENTITY(0,1) NOT NULL,

	[nomVendeur] [varchar](50) NULL,

	[prenomVendeur] [varchar](50) NULL,

	[idConcession] [int] NULL,

 CONSTRAINT [PK_VENDEUR] PRIMARY KEY CLUSTERED 

(

	[idVendeur] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

ALTER TABLE [dbo].[commissionner]  WITH CHECK ADD  CONSTRAINT [commissionner_NBMENS1_FK] FOREIGN KEY([NbMens])

REFERENCES [dbo].[NBMENS] ([NbMens])

GO

ALTER TABLE [dbo].[commissionner] CHECK CONSTRAINT [commissionner_NBMENS1_FK]

GO

ALTER TABLE [dbo].[commissionner]  WITH CHECK ADD  CONSTRAINT [commissionner_NIVEAU_FK] FOREIGN KEY([CodeNiveau])

REFERENCES [dbo].[NIVEAU] ([CodeNiveau])

GO

ALTER TABLE [dbo].[commissionner] CHECK CONSTRAINT [commissionner_NIVEAU_FK]

GO

ALTER TABLE [dbo].[CREDIT]  WITH CHECK ADD  CONSTRAINT [CREDIT_VENDEUR_FK] FOREIGN KEY([idVendeur])

REFERENCES [dbo].[VENDEUR] ([idVendeur])

GO

ALTER TABLE [dbo].[CREDIT] CHECK CONSTRAINT [CREDIT_VENDEUR_FK]

GO

ALTER TABLE [dbo].[CREDIT]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_CLIENT] FOREIGN KEY([numClient])

REFERENCES [dbo].[CLIENT] ([numClient])

GO

ALTER TABLE [dbo].[CREDIT] CHECK CONSTRAINT [FK_CREDIT_CLIENT]

GO

ALTER TABLE [dbo].[MTFIN]  WITH CHECK ADD  CONSTRAINT [FK_MTFIN_MTFIN] FOREIGN KEY([MtFin])

REFERENCES [dbo].[MTFIN] ([MtFin])

GO

ALTER TABLE [dbo].[MTFIN] CHECK CONSTRAINT [FK_MTFIN_MTFIN]

GO

ALTER TABLE [dbo].[VEHICULE]  WITH CHECK ADD  CONSTRAINT [VEHICULE_CONCESSION1_FK] FOREIGN KEY([idConcession])

REFERENCES [dbo].[CONCESSION] ([idConcession])

GO

ALTER TABLE [dbo].[VEHICULE] CHECK CONSTRAINT [VEHICULE_CONCESSION1_FK]

GO

ALTER TABLE [dbo].[VEHICULE]  WITH CHECK ADD  CONSTRAINT [VEHICULE_VENDEUR0_FK] FOREIGN KEY([idVendeur])

REFERENCES [dbo].[VENDEUR] ([idVendeur])

GO

ALTER TABLE [dbo].[VEHICULE] CHECK CONSTRAINT [VEHICULE_VENDEUR0_FK]

GO

ALTER TABLE [dbo].[VENDEUR]  WITH CHECK ADD  CONSTRAINT [VENDEUR_CONCESSION_FK] FOREIGN KEY([idConcession])

REFERENCES [dbo].[CONCESSION] ([idConcession])

GO

ALTER TABLE [dbo].[VENDEUR] CHECK CONSTRAINT [VENDEUR_CONCESSION_FK]

GO

USE [master]

GO

ALTER DATABASE [CREDIT_CELESTE] SET  READ_WRITE 

GO