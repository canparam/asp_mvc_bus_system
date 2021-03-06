USE [master]
GO
/****** Object:  Database [DbContext]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE DATABASE [DbContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbContext', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DbContext.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbContext_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DbContext_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbContext] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbContext] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbContext] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbContext] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbContext] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbContext] SET  MULTI_USER 
GO
ALTER DATABASE [DbContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbContext] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbContext] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DbContext]
GO
/****** Object:  User [cannv]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE USER [cannv] FOR LOGIN [cannv] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
	[IsDel] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bus]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_Bus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BusSchedules]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusSchedules](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TimeScheduleId] [int] NOT NULL,
	[BusId] [int] NOT NULL,
	[PriceTicket] [decimal](18, 1) NOT NULL,
	[Status] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_BusSchedules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Birthday] [datetime2](7) NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[From] [nvarchar](max) NULL,
	[To] [nvarchar](max) NULL,
	[Price] [decimal](18, 1) NOT NULL,
	[StartTime] [datetime2](7) NOT NULL,
	[BusName] [nvarchar](max) NULL,
	[OrderId] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[Amount] [decimal](18, 1) NOT NULL,
	[Total] [decimal](18, 1) NOT NULL,
	[Status] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[BusCheduleId] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
	[TransactionId] [int] NULL DEFAULT ((0)),
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[From] [nvarchar](max) NULL,
	[To] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TimeSchedule]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleId] [int] NOT NULL,
	[StartTime] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_TimeSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TransactionHis]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionHis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [nvarchar](450) NULL,
	[credit] [decimal](18, 1) NOT NULL,
	[status] [int] NOT NULL,
	[type] [int] NOT NULL,
	[created_by] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_TransactionHis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Wallets]    Script Date: 6/13/2022 2:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wallets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [nvarchar](450) NULL,
	[amount] [decimal](18, 1) NOT NULL,
	[modified_by] [nvarchar](max) NULL,
	[created_date] [datetime2](7) NOT NULL,
	[modified_date] [datetime2](7) NOT NULL,
	[IsDel] [int] NOT NULL,
 CONSTRAINT [PK_Wallets] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220608141815_sedding', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220608142030_sedding1', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609090846_v2.1', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609101251_v2.2', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609101718_v2.3', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220612050523_v2.120', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613064204_v99', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613064449_v999', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613064620_v991', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613064810_v10', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613065036_v9900', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220613065927_v9900v', N'5.0.17')
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'323005fc-9927-45fd-92ee-2a953776d7c0', N'Master''s Degree', N'US', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'monte.ullrich', N'MONTE.ULLRICH', N'dimitri.schinner@gmail.com', N'DIMITRI.SCHINNER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHvHpSUOFVvNb6Pk3PvwOtPlM7rbcHh42LZYsOqAjJ6nBX8DUoXn3jXIEXya4BUn8g==', N'SGXUP3MFUUQ53TJBSJEHDU43MLHRMZMW', N'045155f4-13db-43d5-8c68-5aaa7daf4765', N'1-623-748-6505', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'55d7c92b-a5db-466c-8615-283cc80ef2f5', N'Ngo Van Can', N'Bac Ninh', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'cannv', N'CANNV', N'cannv@gmail.com', N'CANNV@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOJut6pQXNPRnwbWkB3OkOo/b8yqdrs+FdVSAeouSbtpuN2k70PG5Z1dOLt/3UlzQw==', N'VI75ZGPGQ7YVVXG2C3MSEFRHOHBPHZEH', N'8a371508-e088-429a-b39c-bc8a9d181a80', N'0985722967', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'587100a6-b6fb-4b80-ba02-304b99967729', N'Jazmin Rowe', N'1832 Hane Ranch Suite 173', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'athena.hills', N'ATHENA.HILLS', N'jacobs.chad@roberts.info', N'JACOBS.CHAD@ROBERTS.INFO', 0, N'AQAAAAEAACcQAAAAEHko29RigyPQqaXXJp/uZZce0y+9MaGr1k6FXqyBR8FPdKcMXD7YzZrVYrEOpTb7AQ==', N'A5JG2WAK5I42BQVMX7BAGTHIZIKHPRYO', N'b59224f0-7053-439c-beab-5f5dd5fa086d', N'838-590-2289 x54454', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7ff879e5-88a6-41aa-8aea-5d8917d81e2c', N'Kaitlyn D''Amore III', N'496 Norene Loop Fairhope, AL 36533', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'xbalistreri', N'XBALISTRERI', N'callie.reichert@yahoo.com', N'CALLIE.REICHERT@YAHOO.COM', 0, N'AQAAAAEAACcQAAAAENKNEfbLseAJSi+91NcL7QsBcd5GFcyc8y+kOIszQb2wsh2xUgAkNYpfmBDo3LBusg==', N'O55F6Q2CYEOWCFGGKJBIRYPZKDODOTZO', N'c266bf59-caf4-4527-a070-5417bce89ead', N'863.797.0975', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'93678e20-35e1-4834-b672-b622891a04ec', N'Nguyen Thi Linh', N'ha noi', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'linhcut', N'LINHCUT', N'linh.nt@gmail.com', N'LINH.NT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENeyxrJjYwEXHvIBQMCtB8U2fzVPZd+SFhWjERhbs7fMNrtUzF6bJq0HAr5CaC+Tlg==', N'7EPNYKQWUBP2OIT3S7XVTU57PRLP7RRK', N'143942b4-9730-4fa0-8a72-fe2d89b4a6de', N'0985722964', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a942a748-1934-4698-b216-fb2c6e9f6217', N'High school diploma', N'99708 Davis Hills Suite 172', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'xhermann', N'XHERMANN', N'jackeline.abshire@krajcik.biz', N'JACKELINE.ABSHIRE@KRAJCIK.BIZ', 0, N'AQAAAAEAACcQAAAAECQvbPt6sAz1WsS5kYgjdh0+dtHk4KjK2vCbECDPsDxLCYWcf1+Bk2hE/fAZ85JhEw==', N'6ZWKTSA6LLPIJEGGWCTIYWE3MK72DABG', N'61888ed0-31e9-4b59-9071-59867b5fae71', N'248-331-9302', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b74ddd14-6340-4840-95c2-db12554843e5', NULL, NULL, 0, 0, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ3R4A99YnH2ntFMPmCwsd2m3wCJ/lL0PVBpFAdD87SQ9LbMaoYEQytBGih7/P6kJQ==', N'd060a972-7ab7-4bf1-a475-f10f8a258990', N'644aab66-6f26-451b-a636-e21e92e1384b', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'dd62630b-b5df-4db0-b8ed-b5d656dfa22a', N'Granville Boehm DVM', N'348 Lang Views Suite 992 Stockbridge, WI 53088', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'jrolfson', N'JROLFSON', N'qgislason@gmail.com', N'QGISLASON@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPqHyNnkrDFh90mWvVUMQJE9qZ29T6lQ+oiBxoTV4GX6VvrVBEpZvTpqPaBQvnO72w==', N'6IXD67WV7LKJG3UBITXB53M26435FN3G', N'd6d8c8b0-78ef-4d6b-ba34-ee55197511d0', N'+1.289.936.2413', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'dff844ff-d8e7-4177-90a2-e8500efe5aac', N'ngo van can', N'ha noi', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'ngovancanbn', N'NGOVANCANBN', N'ngovancanbn@gmail.com', N'NGOVANCANBN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEDBJl2u8EtmNeryOjGE0ZfW19uiUXCy3tPX59DNLG3g3U4Xfzlut0P82hsTVqFpjIQ==', N'PYFHR4AD63IPMSYWXXXG7XF57XIGSXH4', N'0097ae01-dd43-447c-b389-b71d2aea7473', N'0985722967', 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Bus] ON 

INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Motor coach', 26, 0, NULL, CAST(N'2022-06-13 14:04:24.9466552' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'School bus', 26, 0, NULL, CAST(N'2022-06-13 14:04:31.7804663' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Shuttle bus', 30, 0, NULL, CAST(N'2022-06-13 14:04:38.0754740' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Minibus', 6, 0, NULL, CAST(N'2022-06-13 14:04:52.5168111' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Minicoach', 8, 0, NULL, CAST(N'2022-06-13 14:04:59.6738985' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Double-decker bus', 30, 0, NULL, CAST(N'2022-06-13 14:05:06.6506866' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Single-decker bus', 25, 0, NULL, CAST(N'2022-06-13 14:05:11.7149390' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Low-floor bus', 20, 0, NULL, CAST(N'2022-06-13 14:05:19.7881264' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Step-entrance bus', 15, 0, NULL, CAST(N'2022-06-13 14:05:24.6179190' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Trolleybus', 21, 0, NULL, CAST(N'2022-06-13 14:05:28.7772606' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Articulated bus', 20, 0, NULL, CAST(N'2022-06-13 14:05:35.2418392' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Neighbourhood bus', 10, 0, NULL, CAST(N'2022-06-13 14:05:40.9607187' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Training bus', 10, 0, NULL, CAST(N'2022-06-13 14:05:47.4009426' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Gyrobus', 6, 0, NULL, CAST(N'2022-06-13 14:05:52.6881884' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Open top bus', 126, 0, NULL, CAST(N'2022-06-13 14:05:58.5216322' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Bus] OFF
SET IDENTITY_INSERT [dbo].[BusSchedules] ON 

INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, 6, 15, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:10:54.1263970' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, 4, 15, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:00.5995114' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, 14, 13, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:05.8391564' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, 27, 11, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:12.5512683' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, 16, 11, CAST(30.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:20.1911152' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, 23, 3, CAST(15.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:28.2806040' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, 16, 2, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:33.7754421' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, 20, 2, CAST(2.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:40.4552854' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, 33, 2, CAST(30.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:47.4073567' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, 16, 1, CAST(15.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:11:56.3436580' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, 26, 4, CAST(50.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:12:12.1827811' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, 11, 1, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:12:18.0626031' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, 25, 2, CAST(15.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:12:27.1609398' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, 19, 2, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:12:45.8648450' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, 11, 4, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-13 14:12:52.3744729' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[BusSchedules] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Delbert Raynor', N'Nora_Marks@hotmail.com', N'915-750-7230', N'1997 Wisoky Village, West Robynmouth, Lebanon', CAST(N'1950-01-10 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Audrey Crona', N'Baylee89@hotmail.com', N'553-704-9475', N'74240 Ernestina Centers, North Otiliaville, France', CAST(N'1970-01-05 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Norbert Berge', N'Breanne94@hotmail.com', N'944-479-9257', N'70133 Cynthia Pass, Marvinland, Seychelles', CAST(N'1985-01-24 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Nicholas Kohler', N'Bryce40@gmail.com', N'419-859-4677', N'33300 Dare Turnpike, Allisonfort, Vietnam', CAST(N'1989-03-07 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Llewellyn McDermott', N'Nikki.Rath33@yahoo.com', N'515-486-5987', N'1879 Barrett Extensions, Swaniawskiside, Saint Barthelemy', CAST(N'1981-06-21 19:54:26.2917324' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Kamren Heathcote', N'Celine73@gmail.com', N'952-212-3525', N'109 Ephraim Station, South Jamison, Grenada', CAST(N'1947-10-05 14:02:06.5036130' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Katelynn Swaniawski', N'Macey.Pollich@hotmail.com', N'784-370-8102', N'89395 Julius Neck, Burniceshire, Ukraine', CAST(N'1951-11-01 02:27:39.6853255' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Trent McClure', N'Chelsea_Hudson@gmail.com', N'611-273-9749', N'4632 Grant Via, Schadenborough, Luxembourg', CAST(N'1977-10-09 11:38:28.4715977' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Patrick Halvorson', N'Eloy_Runte@hotmail.com', N'645-432-8996', N'3582 Maximillian Mill, East Carolinachester, Guam', CAST(N'1973-09-06 05:38:05.3065821' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Ciara Hoeger', N'Hermann46@yahoo.com', N'707-432-4324', N'7887 Mitchel Mills, Marielleport, Sweden', CAST(N'1945-05-03 23:03:03.4972856' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Llewellyn Wiegand', N'Tiana83@yahoo.com', N'581-340-4875', N'274 Quitzon Court, Veldamouth, Virgin Islands, British', CAST(N'1947-12-06 01:16:07.6021917' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Ansel Heidenreich', N'Roman72@gmail.com', N'204-504-3722', N'6023 Lucy Club, North Lydaside, Rwanda', CAST(N'1970-02-10 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Keanu Gottlieb', N'Jammie98@hotmail.com', N'322-446-5623', N'25260 Etha Squares, East Brayan, Denmark', CAST(N'1988-03-25 18:12:23.7089001' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Abdul Blick', N'Robyn.Cormier@yahoo.com', N'950-499-1917', N'225 Marshall Junctions, Port Barretttown, Timor-Leste', CAST(N'1960-01-15 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Stefanie Barrows', N'Marie_Hegmann66@yahoo.com', N'280-263-7231', N'95321 Margarett Junction, Lake Dashawn, Ecuador', CAST(N'1991-04-25 04:23:49.3132548' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'Raul Gerhold', N'Muhammad75@hotmail.com', N'931-595-6668', N'995 Jaren Circle, North Nashfort, Rwanda', CAST(N'1955-08-05 06:25:38.2866742' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'Bell Vandervort', N'Edythe.Thompson@gmail.com', N'538-285-7084', N'2863 Goodwin Keys, Wiegandbury, Belgium', CAST(N'1981-12-31 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'Donnie Goyette', N'Karlee_McDermott@gmail.com', N'268-868-7661', N'15359 Myrtie Dam, Garrisonland, Italy', CAST(N'1947-08-23 21:26:23.5272171' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'Xavier Denesik', N'Lyda.OKon@yahoo.com', N'228-552-1348', N'6813 Ed Vista, South Katarinaview, Afghanistan', CAST(N'1964-02-17 06:00:05.6486781' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'Mara Jacobson', N'Caitlyn2@yahoo.com', N'616-733-7655', N'6097 Leann Fall, South Sammiebury, Belgium', CAST(N'1981-12-23 04:32:34.1542427' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'Madison Kshlerin', N'Taryn20@yahoo.com', N'882-736-2884', N'02956 Anderson Run, Ronaldoshire, Grenada', CAST(N'1974-04-14 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'Gina DuBuque', N'Zoila_Steuber@yahoo.com', N'246-482-3618', N'380 Eleazar Mall, North Jairoside, Bulgaria', CAST(N'1988-03-01 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'Gisselle Bradtke', N'Vaughn_Gerlach64@gmail.com', N'413-940-1672', N'02956 Domenic Wells, East Oswaldville, Timor-Leste', CAST(N'1997-12-14 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'Lorena West', N'Devin55@yahoo.com', N'558-641-6518', N'964 Abernathy Prairie, West Cyrilburgh, Taiwan', CAST(N'1961-03-10 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'Savanah Stoltenberg', N'Janelle_Rath5@hotmail.com', N'623-778-2804', N'3022 Swift Extension, North Hershel, Uzbekistan', CAST(N'1964-12-25 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'Jennie Mann', N'Renee86@hotmail.com', N'582-213-4030', N'8195 Monica Burgs, Gottliebton, Kenya', CAST(N'1998-12-29 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'Cleve Grant', N'Cassandre_Volkman47@yahoo.com', N'650-855-2245', N'214 Boehm Knolls, Lehnerside, Lao People''s Democratic Republic', CAST(N'1962-08-10 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'Nigel Sawayn', N'Maverick.Cormier@yahoo.com', N'564-638-9510', N'9055 Jaskolski Field, Lake Abdulside, Belize', CAST(N'1984-04-01 13:51:29.8385301' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'Melvina Streich', N'Ashleigh68@yahoo.com', N'603-423-7103', N'090 Benedict Corners, Gardnerside, Honduras', CAST(N'2000-10-29 07:56:23.6543987' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'Teresa Klein', N'Delmer_Jenkins51@yahoo.com', N'454-587-4639', N'1024 Shirley Turnpike, Clydemouth, Poland', CAST(N'1997-06-02 12:15:45.1252720' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'Velva MacGyver', N'Jerel65@hotmail.com', N'599-200-1738', N'16849 Kirlin Valleys, Port Angusport, Nigeria', CAST(N'1993-12-16 07:21:38.2855211' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'Joe Ratke', N'Dwight.Zulauf67@gmail.com', N'910-749-1410', N'3218 Boyd Estate, West Delilahfurt, Holy See (Vatican City State)', CAST(N'1982-05-25 11:08:58.2832390' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'Audie Predovic', N'Margarita.Baumbach@yahoo.com', N'907-373-0741', N'5141 Celestine Cape, Hagenesfurt, Palau', CAST(N'1984-03-02 19:36:47.2677380' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'Malcolm Padberg', N'Bridgette.Gleichner@yahoo.com', N'704-716-2898', N'39247 Kris Ville, Maggioton, Heard Island and McDonald Islands', CAST(N'1975-10-19 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (35, N'Nakia Hilll', N'Rosie.Ortiz@yahoo.com', N'793-320-3200', N'86312 Filomena Crescent, Greenfelderview, Kuwait', CAST(N'1966-07-16 02:56:58.7011088' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (36, N'Daron Ortiz', N'Anita.Towne24@yahoo.com', N'621-781-0542', N'1225 Victor Coves, West Jazminfort, Singapore', CAST(N'1944-09-15 01:39:51.0757823' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (37, N'Alexander Zemlak', N'Meagan8@gmail.com', N'937-587-2927', N'27425 Foster Radial, Scottieport, Moldova', CAST(N'1979-05-22 20:55:57.0217002' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (38, N'Chauncey Stamm', N'Elmira_Ratke21@hotmail.com', N'207-993-4807', N'2362 Kris Ville, Wildermantown, Colombia', CAST(N'1982-06-30 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (39, N'Cindy Larkin', N'Johann93@yahoo.com', N'499-473-4756', N'914 Yundt Alley, Lockmanfort, Zambia', CAST(N'1976-01-13 06:14:20.0091054' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (40, N'Porter Langworth', N'Augustine_Halvorson@gmail.com', N'904-885-4925', N'5763 Kertzmann Plaza, Schambergerbury, Iran', CAST(N'1971-02-11 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (41, N'Courtney Jacobson', N'Kattie31@yahoo.com', N'578-975-0882', N'2079 Tyrese Gateway, Griffinstad, Libyan Arab Jamahiriya', CAST(N'1974-02-28 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (42, N'Kiley Metz', N'Gina_Welch96@hotmail.com', N'447-775-4241', N'16882 Donald Springs, Simonisburgh, Haiti', CAST(N'1976-03-11 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (43, N'Juston Kassulke', N'Ila_Wilkinson@gmail.com', N'739-859-5163', N'84534 Christiansen Ford, North Viviennemouth, Guernsey', CAST(N'2002-06-21 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (44, N'Brooklyn Hahn', N'Hailey.Block19@gmail.com', N'641-526-8847', N'11415 Tressie Stream, Littleborough, Saint Kitts and Nevis', CAST(N'1988-08-19 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (45, N'Austin Becker', N'Meggie_Hettinger39@hotmail.com', N'986-267-6425', N'2288 Domingo Corner, Annaton, Slovakia (Slovak Republic)', CAST(N'1968-12-02 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (46, N'Noe Schulist', N'Leopoldo51@yahoo.com', N'760-367-6636', N'9377 Dickens Turnpike, West Trinity, Iran', CAST(N'1981-09-14 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (47, N'Rasheed Mayer', N'Santino39@hotmail.com', N'210-616-9384', N'068 Garfield Haven, South Oswald, Panama', CAST(N'1967-08-23 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (48, N'Dana Hackett', N'Jaylin.Thiel35@gmail.com', N'924-727-6392', N'01005 Runte Walk, West Ariane, Cook Islands', CAST(N'1979-10-07 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (49, N'Charles McDermott', N'Cordelia_Wolff54@hotmail.com', N'804-963-6256', N'8812 Schinner Summit, South Elsa, Samoa', CAST(N'1945-11-13 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (50, N'Billie Harris', N'Elissa.Thompson@hotmail.com', N'267-414-2151', N'260 Reynolds Row, East Ashlystad, Cote d''Ivoire', CAST(N'1949-03-09 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 06:59:27.0566101' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (51, N'Ngo Van Can', NULL, N'0985722967', N'Bac Ninh', CAST(N'2017-10-20 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 14:26:37.6167837' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (52, N'Ha Thi Vanh', NULL, N'0964057550', N'Ninh Binh', CAST(N'2011-06-17 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-13 14:30:51.7985388' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 5, NULL, CAST(N'2022-06-13 14:24:35.4082916' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 6, NULL, CAST(N'2022-06-13 14:25:39.9805197' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 7, NULL, CAST(N'2022-06-13 14:25:44.3175332' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 8, NULL, CAST(N'2022-06-13 14:25:49.2638973' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 9, NULL, CAST(N'2022-06-13 14:25:53.3781747' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 10, NULL, CAST(N'2022-06-13 14:25:58.9859794' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 11, NULL, CAST(N'2022-06-13 14:26:03.5850890' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 12, NULL, CAST(N'2022-06-13 14:26:10.7532161' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 13, NULL, CAST(N'2022-06-13 14:26:16.2735222' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 14, NULL, CAST(N'2022-06-13 14:26:37.6263825' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 15, NULL, CAST(N'2022-06-13 14:26:43.3544883' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 16, NULL, CAST(N'2022-06-13 14:26:48.3339184' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 17, NULL, CAST(N'2022-06-13 14:26:53.2130473' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 18, NULL, CAST(N'2022-06-13 14:26:57.8788889' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 19, NULL, CAST(N'2022-06-13 14:27:02.8322700' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 20, NULL, CAST(N'2022-06-13 14:27:09.5284102' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 21, NULL, CAST(N'2022-06-13 14:27:14.7276119' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 22, NULL, CAST(N'2022-06-13 14:27:18.9190872' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 23, NULL, CAST(N'2022-06-13 14:27:23.7551810' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 24, NULL, CAST(N'2022-06-13 14:27:28.7187187' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 25, NULL, CAST(N'2022-06-13 14:27:34.4075181' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 26, NULL, CAST(N'2022-06-13 14:27:40.6073344' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 27, NULL, CAST(N'2022-06-13 14:27:43.3277436' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 28, NULL, CAST(N'2022-06-13 14:27:48.1508846' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 29, NULL, CAST(N'2022-06-13 14:27:53.9745823' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 30, NULL, CAST(N'2022-06-13 14:28:00.7661084' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 31, NULL, CAST(N'2022-06-13 14:28:05.4228991' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 32, NULL, CAST(N'2022-06-13 14:28:12.2310825' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 33, NULL, CAST(N'2022-06-13 14:28:19.2539808' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 34, NULL, CAST(N'2022-06-13 14:28:24.0802288' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 35, NULL, CAST(N'2022-06-13 14:28:28.6226390' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 36, NULL, CAST(N'2022-06-13 14:28:34.8701973' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'Hanoi (Hà Nội)', N'Sapa', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'School bus', 37, NULL, CAST(N'2022-06-13 14:28:39.8224574' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'Hanoi (Hà Nội)', N'Sapa', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'School bus', 38, NULL, CAST(N'2022-06-13 14:28:44.6779300' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (35, N'Hanoi (Hà Nội)', N'Sapa', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'School bus', 39, NULL, CAST(N'2022-06-13 14:28:49.6060154' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (36, N'Hanoi (Hà Nội)', N'Sapa', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'School bus', 40, NULL, CAST(N'2022-06-13 14:28:55.6552270' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (37, N'Hồ Chí Minh', N'Cần Thơ', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-07-13 12:00:00.0000000' AS DateTime2), N'Shuttle bus', 41, NULL, CAST(N'2022-06-13 14:28:58.5349546' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (38, N'Hồ Chí Minh', N'Cần Thơ', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-07-13 12:00:00.0000000' AS DateTime2), N'Shuttle bus', 42, NULL, CAST(N'2022-06-13 14:29:04.2609055' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (39, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Minibus', 43, NULL, CAST(N'2022-06-13 14:29:58.4168596' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (40, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 44, NULL, CAST(N'2022-06-13 14:30:06.7008443' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (41, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'School bus', 45, NULL, CAST(N'2022-06-13 14:30:10.8514258' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (42, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 46, NULL, CAST(N'2022-06-13 14:30:16.3183084' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (43, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 47, NULL, CAST(N'2022-06-13 14:30:20.9266297' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (44, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 48, NULL, CAST(N'2022-06-13 14:30:26.5586863' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (45, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 49, NULL, CAST(N'2022-06-13 14:30:32.1589765' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (46, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), N'School bus', 50, NULL, CAST(N'2022-06-13 14:30:51.8024966' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (47, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 51, NULL, CAST(N'2022-06-13 14:30:56.2631237' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (48, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 52, NULL, CAST(N'2022-06-13 14:31:02.2940047' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (49, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), N'Motor coach', 53, NULL, CAST(N'2022-06-13 14:31:07.1830056' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (50, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 54, NULL, CAST(N'2022-06-13 14:31:13.5088954' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (51, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 55, NULL, CAST(N'2022-06-13 14:31:18.5802680' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (52, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 56, NULL, CAST(N'2022-06-13 14:31:23.9511004' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (53, N'Hà Nam', N'Tuyên Quang', CAST(50.0 AS Decimal(18, 1)), CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), N'Minibus', 57, NULL, CAST(N'2022-06-13 14:31:29.2786082' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (54, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 58, NULL, CAST(N'2022-06-13 14:31:33.1984303' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (55, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 59, NULL, CAST(N'2022-06-13 14:31:38.4942231' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (56, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 60, NULL, CAST(N'2022-06-13 14:31:44.1994945' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (57, N'Hanoi (Hà Nội)', N'Sapa', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), N'Motor coach', 61, NULL, CAST(N'2022-06-13 14:31:50.4710297' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (58, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 62, NULL, CAST(N'2022-06-13 14:31:55.6622192' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (59, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 63, NULL, CAST(N'2022-06-13 14:32:00.3606357' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (60, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(2.0 AS Decimal(18, 1)), CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), N'School bus', 64, NULL, CAST(N'2022-06-13 14:32:06.9206227' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (61, N'Hồ Tây', N'Hồ Gươm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-06-18 14:00:00.0000000' AS DateTime2), N'Open top bus', 65, NULL, CAST(N'2022-06-13 14:32:14.3117753' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (62, N'Hồ Tây', N'Hồ Gươm', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-06-18 14:00:00.0000000' AS DateTime2), N'Open top bus', 66, NULL, CAST(N'2022-06-13 14:32:18.9733476' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (63, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-26 06:30:00.0000000' AS DateTime2), N'Training bus', 67, NULL, CAST(N'2022-06-13 14:32:22.6663891' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (64, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-26 06:30:00.0000000' AS DateTime2), N'Training bus', 68, NULL, CAST(N'2022-06-13 14:32:29.5420608' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (5, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 2, 15, NULL, CAST(N'2022-06-10 14:24:35.3784766' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 6)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (6, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 1, 15, NULL, CAST(N'2022-06-10 14:25:39.9775226' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 7)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (7, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 4, 15, NULL, CAST(N'2022-06-10 14:25:44.3133189' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 8)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (8, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 23, 15, NULL, CAST(N'2022-06-11 14:25:49.2609652' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 9)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (9, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 48, 15, NULL, CAST(N'2022-06-11 14:25:53.3771683' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 10)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (10, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 2, 14, NULL, CAST(N'2022-06-11 14:25:58.9846553' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 11)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (11, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 17, 14, NULL, CAST(N'2022-06-12 14:26:03.5839142' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 12)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (12, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 38, 14, NULL, CAST(N'2022-06-12 14:26:10.7523217' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 13)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (13, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 49, 14, NULL, CAST(N'2022-06-12 14:26:16.2722081' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 14)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (14, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(0.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 100, 51, 14, NULL, CAST(N'2022-06-13 14:26:37.6256105' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 15)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (15, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 49, 14, NULL, CAST(N'2022-06-12 14:26:43.3536577' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 16)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (16, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 48, 14, NULL, CAST(N'2022-06-13 14:26:48.3296403' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 17)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (17, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(0.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 100, 51, 13, NULL, CAST(N'2022-06-13 14:26:53.2110698' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 18)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (18, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 2, 13, NULL, CAST(N'2022-06-12 14:26:57.8782245' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 19)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (19, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 25, 13, NULL, CAST(N'2022-06-13 14:27:02.8313563' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 20)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (20, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 14, 13, NULL, CAST(N'2022-06-13 14:27:09.5277506' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 21)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (21, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 46, 13, NULL, CAST(N'2022-06-09 14:27:14.7270078' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 22)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (22, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 4, 12, NULL, CAST(N'2022-06-09 14:27:18.9185961' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 23)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (23, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 1, 0, 41, 12, NULL, CAST(N'2022-06-09 14:27:23.7541509' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 24)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (24, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 47, 12, NULL, CAST(N'2022-06-13 14:27:28.7178777' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 25)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (25, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 49, 12, NULL, CAST(N'2022-06-09 14:27:34.4069546' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 26)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (26, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 1, 30, 47, 12, NULL, CAST(N'2022-06-13 14:27:40.6065447' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 27)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (27, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(50.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 0, 3, 11, NULL, CAST(N'2022-06-13 14:27:43.3270624' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 28)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (28, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(35.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 30, 1, 11, NULL, CAST(N'2022-06-13 14:27:48.1500589' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 29)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (29, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(50.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 1, 0, 26, 11, NULL, CAST(N'2022-06-09 14:27:53.9718425' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 30)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (30, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 2, 10, NULL, CAST(N'2022-06-13 14:28:00.7631777' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 31)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (31, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 12, 10, NULL, CAST(N'2022-06-13 14:28:05.4223104' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 32)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (32, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 30, 14, 10, NULL, CAST(N'2022-06-13 14:28:12.2304687' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 33)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (33, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 30, 40, 10, NULL, CAST(N'2022-06-13 14:28:19.2533208' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 34)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (34, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 1, 0, 26, 8, NULL, CAST(N'2022-06-13 14:28:24.0795096' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 35)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (35, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 0, 0, 43, 8, NULL, CAST(N'2022-06-13 14:28:28.6219606' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 36)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (36, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 0, 0, 44, 8, NULL, CAST(N'2022-06-13 14:28:34.8694860' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 37)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (37, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 2, 7, NULL, CAST(N'2022-06-13 14:28:39.8216190' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 38)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (38, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 24, 7, NULL, CAST(N'2022-06-13 14:28:44.6772047' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 39)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (39, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 24, 7, NULL, CAST(N'2022-06-13 14:28:49.6053715' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 40)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (40, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 30, 45, 7, NULL, CAST(N'2022-06-13 14:28:55.6545700' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 41)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (41, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 0, 4, 6, NULL, CAST(N'2022-06-13 14:28:58.5343072' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 42)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (42, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 0, 41, 6, NULL, CAST(N'2022-06-13 14:29:04.2586755' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 43)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (43, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 4, 15, NULL, CAST(N'2022-06-13 14:29:58.4158984' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 53)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (44, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 3, 14, NULL, CAST(N'2022-06-13 14:30:06.6978299' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 54)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (45, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 22, 14, NULL, CAST(N'2022-06-13 14:30:10.8490667' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 55)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (46, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 4, 13, NULL, CAST(N'2022-06-05 14:30:16.3177087' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 56)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (47, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 23, 13, NULL, CAST(N'2022-06-05 14:30:20.9255715' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 57)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (48, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 46, 13, NULL, CAST(N'2022-06-05 14:30:26.5580249' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 58)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (49, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 48, 13, NULL, CAST(N'2022-06-05 14:30:32.1581588' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 59)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (50, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(7.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 50, 52, 13, NULL, CAST(N'2022-06-05 14:30:51.8017265' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 60)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (51, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 50, 52, 12, NULL, CAST(N'2022-06-09 14:30:56.2624543' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 61)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (52, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 27, 12, NULL, CAST(N'2022-06-13 14:31:02.2933873' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 62)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (53, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 23, 12, NULL, CAST(N'2022-06-13 14:31:07.1822633' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 63)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (54, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(50.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 0, 21, 11, NULL, CAST(N'2022-06-05 14:31:13.5066802' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 64)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (55, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(50.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 0, 23, 11, NULL, CAST(N'2022-06-13 14:31:18.5779353' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 65)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (56, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(35.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 30, 40, 11, NULL, CAST(N'2022-06-05 14:31:23.9502138' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 66)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (57, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(35.0 AS Decimal(18, 1)), CAST(50.0 AS Decimal(18, 1)), 0, 30, 49, 11, NULL, CAST(N'2022-06-13 14:31:29.2778166' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 67)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (58, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 1, 10, NULL, CAST(N'2022-06-05 14:31:33.1978221' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 68)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (59, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 0, 42, 10, NULL, CAST(N'2022-06-13 14:31:38.4934081' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 69)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (60, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 50, 10, NULL, CAST(N'2022-06-13 14:31:44.1988644' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 70)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (61, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 46, 10, NULL, CAST(N'2022-06-05 14:31:50.4702338' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 71)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (62, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(1.4 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 0, 30, 12, 8, NULL, CAST(N'2022-06-13 14:31:55.6616480' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 72)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (63, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.0 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 1, 0, 34, 8, NULL, CAST(N'2022-06-13 14:32:00.3599537' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 73)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (64, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.0 AS Decimal(18, 1)), CAST(2.0 AS Decimal(18, 1)), 0, 0, 43, 8, NULL, CAST(N'2022-06-13 14:32:06.9198385' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 74)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (65, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(3.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 30, 2, 2, NULL, CAST(N'2022-06-13 14:32:14.3105396' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 75)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (66, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.5 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 50, 52, 2, NULL, CAST(N'2022-06-13 14:32:18.9711389' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 76)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (67, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 0, 26, 3, NULL, CAST(N'2022-06-13 14:32:22.6642655' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 77)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel], [TransactionId]) VALUES (68, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 30, 45, 3, NULL, CAST(N'2022-06-13 14:32:29.5415468' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0, 78)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Bắc Giang', N'Bắc Ninh', 0, NULL, CAST(N'2022-06-13 14:06:26.1255269' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Hanoi (Hà Nội)', N'Hải Phòng', 0, NULL, CAST(N'2022-06-13 14:06:35.2559103' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Hà Nam', N'Tuyên Quang', 0, NULL, CAST(N'2022-06-13 14:06:45.9910513' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Hồ Chí Minh', N'Cần Thơ', 0, NULL, CAST(N'2022-06-13 14:07:01.2086433' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Quận Thanh Xuân', N'Quận Cầu Giấy', 0, NULL, CAST(N'2022-06-13 14:07:10.2175359' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Hanoi (Hà Nội)', N'Sapa', 0, NULL, CAST(N'2022-06-13 14:07:19.9441596' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', 0, NULL, CAST(N'2022-06-13 14:07:27.9293373' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Cao Bằng', N'Lào Cai', 0, NULL, CAST(N'2022-06-13 14:07:35.3602300' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Hồ Tây', N'Hồ Gươm', 0, NULL, CAST(N'2022-06-13 14:07:46.2012938' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Schedules] OFF
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'VBus_0', 0, 5, NULL, CAST(N'2022-06-13 14:24:35.4257909' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'VBus_2', 0, 6, NULL, CAST(N'2022-06-13 14:25:39.9816933' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'VBus_3', 0, 7, NULL, CAST(N'2022-06-13 14:25:44.3184942' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'VBus_4', 0, 8, NULL, CAST(N'2022-06-13 14:25:49.2646845' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'VBus_5', 0, 9, NULL, CAST(N'2022-06-13 14:25:53.3786695' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'VBus_6', 0, 10, NULL, CAST(N'2022-06-13 14:25:58.9864695' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'VBus_7', 0, 11, NULL, CAST(N'2022-06-13 14:26:03.5855798' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'VBus_8', 0, 12, NULL, CAST(N'2022-06-13 14:26:10.7536871' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'VBus_9', 0, 13, NULL, CAST(N'2022-06-13 14:26:16.2740710' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'VBus_10', 0, 14, NULL, CAST(N'2022-06-13 14:26:37.6267880' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'VBus_11', 0, 15, NULL, CAST(N'2022-06-13 14:26:43.3548475' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'VBus_12', 0, 16, NULL, CAST(N'2022-06-13 14:26:48.3346743' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'VBus_13', 0, 17, NULL, CAST(N'2022-06-13 14:26:53.2138103' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'VBus_14', 0, 18, NULL, CAST(N'2022-06-13 14:26:57.8792289' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'VBus_15', 0, 19, NULL, CAST(N'2022-06-13 14:27:02.8326994' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'VBus_16', 0, 20, NULL, CAST(N'2022-06-13 14:27:09.5287017' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'VBus_17', 0, 21, NULL, CAST(N'2022-06-13 14:27:14.7279188' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'VBus_18', 0, 22, NULL, CAST(N'2022-06-13 14:27:18.9194060' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'VBus_19', 2, 23, NULL, CAST(N'2022-06-13 14:27:23.7557279' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'VBus_20', 0, 24, NULL, CAST(N'2022-06-13 14:27:28.7191812' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'VBus_21', 0, 25, NULL, CAST(N'2022-06-13 14:27:34.4078080' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'VBus_22', 2, 26, NULL, CAST(N'2022-06-13 14:27:40.6076735' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'VBus_23', 0, 27, NULL, CAST(N'2022-06-13 14:27:43.3280741' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'VBus_24', 0, 28, NULL, CAST(N'2022-06-13 14:27:48.1512952' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'VBus_25', 2, 29, NULL, CAST(N'2022-06-13 14:27:53.9755660' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'VBus_26', 0, 30, NULL, CAST(N'2022-06-13 14:28:00.7669800' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'VBus_27', 0, 31, NULL, CAST(N'2022-06-13 14:28:05.4232227' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'VBus_28', 2, 32, NULL, CAST(N'2022-06-13 14:28:12.2314090' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'VBus_29', 2, 33, NULL, CAST(N'2022-06-13 14:28:19.2543734' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'VBus_30', 2, 34, NULL, CAST(N'2022-06-13 14:28:24.0805914' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'VBus_31', 0, 35, NULL, CAST(N'2022-06-13 14:28:28.6230116' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'VBus_32', 0, 36, NULL, CAST(N'2022-06-13 14:28:34.8705632' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'VBus_33', 0, 37, NULL, CAST(N'2022-06-13 14:28:39.8228679' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'VBus_34', 0, 38, NULL, CAST(N'2022-06-13 14:28:44.6782805' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (35, N'VBus_35', 0, 39, NULL, CAST(N'2022-06-13 14:28:49.6063797' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (36, N'VBus_36', 2, 40, NULL, CAST(N'2022-06-13 14:28:55.6555956' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (37, N'VBus_37', 2, 41, NULL, CAST(N'2022-06-13 14:28:58.5353075' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (38, N'VBus_38', 2, 42, NULL, CAST(N'2022-06-13 14:29:04.2615658' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (39, N'VBus_39', 0, 43, NULL, CAST(N'2022-06-13 14:29:58.4173724' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (40, N'VBus_40', 0, 44, NULL, CAST(N'2022-06-13 14:30:06.7016663' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (41, N'VBus_41', 0, 45, NULL, CAST(N'2022-06-13 14:30:10.8521152' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (42, N'VBus_42', 0, 46, NULL, CAST(N'2022-06-13 14:30:16.3186319' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (43, N'VBus_43', 0, 47, NULL, CAST(N'2022-06-13 14:30:20.9271288' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (44, N'VBus_44', 0, 48, NULL, CAST(N'2022-06-13 14:30:26.5590298' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (45, N'VBus_45', 0, 49, NULL, CAST(N'2022-06-13 14:30:32.1593474' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (46, N'VBus_46', 0, 50, NULL, CAST(N'2022-06-13 14:30:51.8028557' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (47, N'VBus_47', 0, 51, NULL, CAST(N'2022-06-13 14:30:56.2634555' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (48, N'VBus_48', 0, 52, NULL, CAST(N'2022-06-13 14:31:02.2943778' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (49, N'VBus_49', 0, 53, NULL, CAST(N'2022-06-13 14:31:07.1834332' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (50, N'VBus_50', 0, 54, NULL, CAST(N'2022-06-13 14:31:13.5097531' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (51, N'VBus_51', 0, 55, NULL, CAST(N'2022-06-13 14:31:18.5811673' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (52, N'VBus_52', 0, 56, NULL, CAST(N'2022-06-13 14:31:23.9515506' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (53, N'VBus_53', 0, 57, NULL, CAST(N'2022-06-13 14:31:29.2790379' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (54, N'VBus_54', 0, 58, NULL, CAST(N'2022-06-13 14:31:33.1987935' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (55, N'VBus_55', 2, 59, NULL, CAST(N'2022-06-13 14:31:38.4946094' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (56, N'VBus_56', 0, 60, NULL, CAST(N'2022-06-13 14:31:44.1998448' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (57, N'VBus_57', 0, 61, NULL, CAST(N'2022-06-13 14:31:50.4714851' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (58, N'VBus_58', 0, 62, NULL, CAST(N'2022-06-13 14:31:55.6625544' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (59, N'VBus_59', 2, 63, NULL, CAST(N'2022-06-13 14:32:00.3610404' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (60, N'VBus_60', 0, 64, NULL, CAST(N'2022-06-13 14:32:06.9210185' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (61, N'VBus_61', 0, 65, NULL, CAST(N'2022-06-13 14:32:14.3122254' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (62, N'VBus_62', 0, 66, NULL, CAST(N'2022-06-13 14:32:18.9740071' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (63, N'VBus_63', 2, 67, NULL, CAST(N'2022-06-13 14:32:22.6671183' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (64, N'VBus_64', 2, 68, NULL, CAST(N'2022-06-13 14:32:29.5423810' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
SET IDENTITY_INSERT [dbo].[TimeSchedule] ON 

INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, 9, CAST(N'2022-06-01 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:07:59.7328428' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, 9, CAST(N'2022-06-16 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:03.0252515' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, 9, CAST(N'2022-06-17 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:05.8031715' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, 9, CAST(N'2022-06-18 14:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:10.6616114' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, 9, CAST(N'2022-06-21 11:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:17.0811069' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, 9, CAST(N'2022-06-29 10:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:22.5206337' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, 8, CAST(N'2022-06-30 05:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:29.4176007' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, 8, CAST(N'2022-06-29 06:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:34.8664355' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, 8, CAST(N'2022-06-30 19:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:39.8069816' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, 8, CAST(N'2022-06-25 00:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:45.8314282' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, 7, CAST(N'2022-07-26 13:05:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:08:55.9293302' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, 7, CAST(N'2022-06-25 16:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:01.7845240' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, 7, CAST(N'2022-06-18 11:20:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:06.2734182' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, 7, CAST(N'2022-06-26 06:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:15.1218288' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, 6, CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:18.8798962' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, 6, CAST(N'2022-06-28 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:19.3020566' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, 6, CAST(N'2022-06-18 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:31.3844045' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, 6, CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:34.3757003' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, 5, CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:38.3835841' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, 5, CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:42.3039674' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, 5, CAST(N'2022-06-28 23:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:47.0958745' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, 4, CAST(N'2022-07-17 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:51.9995520' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, 4, CAST(N'2022-07-13 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:55.1921858' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, 4, CAST(N'2022-07-15 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:09:58.6555089' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, 3, CAST(N'2022-06-27 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:02.5931939' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, 3, CAST(N'2022-06-25 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:05.6818250' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, 3, CAST(N'2022-06-26 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:08.5516945' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, 2, CAST(N'2022-07-24 08:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:16.5091260' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, 2, CAST(N'2022-07-24 18:40:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:24.3619331' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, 1, CAST(N'2022-06-25 03:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:30.3915438' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, 1, CAST(N'2022-06-27 14:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:34.9039592' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, 1, CAST(N'2022-06-13 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:39.2803273' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, 1, CAST(N'2022-06-13 13:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-13 14:10:42.8558584' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[TimeSchedule] OFF
SET IDENTITY_INSERT [dbo].[TransactionHis] ON 

INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'323005fc-9927-45fd-92ee-2a953776d7c0', CAST(50.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-13 14:17:08.6665274' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(700.0 AS Decimal(18, 1)), 0, 0, N'admin', N'admin sent', NULL, CAST(N'2022-06-13 14:17:16.2468439' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(1000.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-13 14:17:22.7615954' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'7ff879e5-88a6-41aa-8aea-5d8917d81e2c', CAST(20.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-13 14:17:25.7518950' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'93678e20-35e1-4834-b672-b622891a04ec', CAST(10.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-13 14:17:29.3660516' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:24:35.2571551' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:25:39.9707387' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:25:44.3050982' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:25:49.2547820' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:25:53.3754419' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:25:58.9829238' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:03.5821738' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:10.7507072' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:16.2705208' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(0.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:37.6242919' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:43.3521248' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:48.3241516' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(0.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:53.2062040' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:26:57.8771746' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:02.8299457' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:09.5264607' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:14.7257753' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:18.9175415' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:23.7528166' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:28.7166535' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:34.4058458' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:40.6052161' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(50.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:43.3257966' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(35.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:48.1488136' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(50.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:27:53.9666182' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:00.7586104' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:05.4211241' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:12.2292997' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:19.2523665' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (35, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:24.0780605' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (36, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:28.6206207' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (37, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:34.8685076' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (38, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:39.8205104' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (39, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:44.6760545' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (40, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:49.6043130' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (41, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:55.6533089' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (42, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:28:58.5332580' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (43, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:29:04.2541635' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (44, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 42', NULL, CAST(N'2022-06-13 14:29:11.9808236' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (45, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(15.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 41', NULL, CAST(N'2022-06-13 14:29:13.7498149' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (46, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(7.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 40', NULL, CAST(N'2022-06-13 14:29:15.5307574' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (47, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 33', NULL, CAST(N'2022-06-13 14:29:17.3343614' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (48, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(2.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 34', NULL, CAST(N'2022-06-13 14:29:18.9530197' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (49, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(50.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 29', NULL, CAST(N'2022-06-13 14:29:24.5838136' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (50, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(3.5 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 26', NULL, CAST(N'2022-06-13 14:29:26.2433701' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (51, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(5.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 23', NULL, CAST(N'2022-06-13 14:29:28.0296926' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (52, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(10.5 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 32', NULL, CAST(N'2022-06-13 14:29:29.7660373' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (53, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:29:58.4141865' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (54, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:06.6934056' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (55, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:10.8444590' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (56, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:16.3165026' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (57, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:20.9242815' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (58, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:26.5568477' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (59, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:32.1567231' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (60, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(7.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:51.8006730' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (61, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:30:56.2612952' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (62, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:02.2922953' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (63, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:07.1809235' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (64, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(50.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:13.5018278' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (65, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(50.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:18.5731934' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (66, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(35.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:23.9489977' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (67, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(35.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:29.2766060' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (68, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:33.1967089' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (69, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:38.4921008' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (70, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:44.1978035' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (71, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:50.4688549' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (72, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(1.4 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:31:55.6605978' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (73, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:00.3588642' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (74, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:06.9186235' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (75, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(3.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:14.3092910' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (76, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.5 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:18.9666022' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (77, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:22.6595848' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (78, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'ngovancanbn', N'Payment buy ticket', NULL, CAST(N'2022-06-13 14:32:29.5406158' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (79, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(10.0 AS Decimal(18, 1)), 0, 2, N'ngovancanbn', N'Refund for OrderId: 67', NULL, CAST(N'2022-06-13 14:32:33.6037823' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (80, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(7.0 AS Decimal(18, 1)), 0, 2, N'ngovancanbn', N'Refund for OrderId: 68', NULL, CAST(N'2022-06-13 14:32:35.5006514' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (81, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(15.0 AS Decimal(18, 1)), 0, 2, N'ngovancanbn', N'Refund for OrderId: 59', NULL, CAST(N'2022-06-13 14:32:37.4368321' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (82, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(2.0 AS Decimal(18, 1)), 0, 2, N'ngovancanbn', N'Refund for OrderId: 63', NULL, CAST(N'2022-06-13 14:32:40.2207810' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[TransactionHis] OFF
SET IDENTITY_INSERT [dbo].[Wallets] ON 

INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(96.5 AS Decimal(18, 1)), NULL, CAST(N'2022-06-13 13:59:27.0030495' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'55d7c92b-a5db-466c-8615-283cc80ef2f5', CAST(741.0 AS Decimal(18, 1)), N'cannv', CAST(N'2022-06-13 14:13:22.9703361' AS DateTime2), CAST(N'2022-06-13 07:29:29.7659989' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'93678e20-35e1-4834-b672-b622891a04ec', CAST(10.0 AS Decimal(18, 1)), N'admin', CAST(N'2022-06-13 14:13:46.5090715' AS DateTime2), CAST(N'2022-06-13 07:17:29.3659452' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'dff844ff-d8e7-4177-90a2-e8500efe5aac', CAST(381.1 AS Decimal(18, 1)), N'ngovancanbn', CAST(N'2022-06-13 14:14:01.5364038' AS DateTime2), CAST(N'2022-06-13 07:32:40.2207426' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'323005fc-9927-45fd-92ee-2a953776d7c0', CAST(50.0 AS Decimal(18, 1)), N'admin', CAST(N'2022-06-13 14:14:51.3785458' AS DateTime2), CAST(N'2022-06-13 07:17:08.6660622' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'a942a748-1934-4698-b216-fb2c6e9f6217', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'2022-06-13 14:15:28.2692559' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'587100a6-b6fb-4b80-ba02-304b99967729', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'2022-06-13 14:15:57.9693897' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'7ff879e5-88a6-41aa-8aea-5d8917d81e2c', CAST(20.0 AS Decimal(18, 1)), N'admin', CAST(N'2022-06-13 14:16:29.8219162' AS DateTime2), CAST(N'2022-06-13 07:17:25.7517571' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'dd62630b-b5df-4db0-b8ed-b5d656dfa22a', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'2022-06-13 14:17:00.6163536' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Wallets] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BusSchedules_BusId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusSchedules_BusId] ON [dbo].[BusSchedules]
(
	[BusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BusSchedules_TimeScheduleId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusSchedules_TimeScheduleId] ON [dbo].[BusSchedules]
(
	[TimeScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_OrderId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_OrderId] ON [dbo].[OrderDetail]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_BusCheduleId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_BusCheduleId] ON [dbo].[Orders]
(
	[BusCheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_CustomerId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId] ON [dbo].[Orders]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_TransactionId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_TransactionId] ON [dbo].[Orders]
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tickets_OrderId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tickets_OrderId] ON [dbo].[Tickets]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimeSchedule_ScheduleId]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_TimeSchedule_ScheduleId] ON [dbo].[TimeSchedule]
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TransactionHis_user_id]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_TransactionHis_user_id] ON [dbo].[TransactionHis]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Wallets_user_id]    Script Date: 6/13/2022 2:37:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Wallets_user_id] ON [dbo].[Wallets]
(
	[user_id] ASC
)
WHERE ([user_id] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[BusSchedules]  WITH CHECK ADD  CONSTRAINT [FK_BusSchedules_Bus_BusId] FOREIGN KEY([BusId])
REFERENCES [dbo].[Bus] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BusSchedules] CHECK CONSTRAINT [FK_BusSchedules_Bus_BusId]
GO
ALTER TABLE [dbo].[BusSchedules]  WITH CHECK ADD  CONSTRAINT [FK_BusSchedules_TimeSchedule_TimeScheduleId] FOREIGN KEY([TimeScheduleId])
REFERENCES [dbo].[TimeSchedule] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BusSchedules] CHECK CONSTRAINT [FK_BusSchedules_TimeSchedule_TimeScheduleId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Orders_OrderId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_BusSchedules_BusCheduleId] FOREIGN KEY([BusCheduleId])
REFERENCES [dbo].[BusSchedules] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_BusSchedules_BusCheduleId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_TransactionHis_TransactionId] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[TransactionHis] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_TransactionHis_TransactionId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Orders_OrderId]
GO
ALTER TABLE [dbo].[TimeSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TimeSchedule_Schedules_ScheduleId] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[Schedules] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TimeSchedule] CHECK CONSTRAINT [FK_TimeSchedule_Schedules_ScheduleId]
GO
ALTER TABLE [dbo].[TransactionHis]  WITH CHECK ADD  CONSTRAINT [FK_TransactionHis_AspNetUsers_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[TransactionHis] CHECK CONSTRAINT [FK_TransactionHis_AspNetUsers_user_id]
GO
ALTER TABLE [dbo].[Wallets]  WITH CHECK ADD  CONSTRAINT [FK_Wallets_AspNetUsers_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Wallets] CHECK CONSTRAINT [FK_Wallets_AspNetUsers_user_id]
GO
USE [master]
GO
ALTER DATABASE [DbContext] SET  READ_WRITE 
GO
