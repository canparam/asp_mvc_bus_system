USE [master]
GO
/****** Object:  Database [NewDB]    Script Date: 6/12/2022 11:18:49 PM ******/
CREATE DATABASE [NewDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NewDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NewDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NewDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NewDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NewDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NewDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NewDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NewDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NewDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [NewDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NewDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NewDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NewDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NewDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NewDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NewDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NewDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NewDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NewDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NewDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NewDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NewDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NewDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NewDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NewDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NewDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NewDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NewDB] SET  MULTI_USER 
GO
ALTER DATABASE [NewDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NewDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NewDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NewDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NewDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [NewDB]
GO
/****** Object:  User [cannv]    Script Date: 6/12/2022 11:18:49 PM ******/
CREATE USER [cannv] FOR LOGIN [cannv] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[Bus]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[BusSchedules]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[Customers]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 6/12/2022 11:18:49 PM ******/
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
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[Tickets]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[TimeSchedule]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[TransactionHis]    Script Date: 6/12/2022 11:18:49 PM ******/
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
/****** Object:  Table [dbo].[Wallets]    Script Date: 6/12/2022 11:18:49 PM ******/
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
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'114ceeb9-9318-4c58-9b79-5ab658013d12', N'Nguyen Thi Linh', N'Ha Noi', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'linhnhi', N'LINHNHI', N'linhnhi@gmail.com', N'LINHNHI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEL8H/nfFsgAa8X6uwv89JrexZZRb+TcwK9PJKJwPBpr2flATPQ13saZshz/q+9KtJQ==', N'2K5WM3L5PSQXRFBYXJCY3JLP5UIW3MJW', N'210086bb-3c57-4b79-b787-d4fda1822b87', N'0741964512', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'37fe9ef0-2937-4079-a8a2-d619640e501b', N'Rivera', N'1987 Fannie Street', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'brennan_he1982', N'BRENNAN_HE1982', N'kyler.bod8@hotmail.com', N'KYLER.BOD8@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHSyHy/Q4lkwm5ZBQ4SODqLbQOIO/gf/EnLknr/ETazqktYHQB3zCzyKF/uVhnPJtA==', N'T6SZYY3ZPEGPUTOM55QTN47IQJ4SUHQW', N'3534b230-27e8-408c-b795-e2970d0200d7', N'832-896-8875', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', N'CAN', N'208 xa dan , dong da , ha noi', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'cannv', N'CANNV', N'ngovancanbn@gmail.com', N'NGOVANCANBN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEC9duiIB5CFPNop80BtjPv0R8RYR7WZRoWxGoSYjX5/J8W0g8o/o0sZ8QV1y5wGfHg==', N'7XFJPQKC3E7IYA34QKK62MZCAXYHHX5A', N'8228bfdd-4549-4211-8dd4-5b9a240e7b91', N'0985722967', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4acdea16-ba9e-4ae0-a1c4-4bca6e525ea0', N'Super kai', N'1372 Charla Lane', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'suzanne1981', N'SUZANNE1981', N'suzanne1981@gmail.com', N'SUZANNE1981@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJWHcA4qTS3gjjyrZ6ZsGocBS/6nxN/Bffv9JH31z9klyXxgbmOc2bZ9KxSiRE4/Bw==', N'QPTMKKFO2KKC4RKVDLRWS224RQMWMJRO', N'ccdc44be-e59f-44f6-84bf-a5eead3ea7f5', N'214-709-5267', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'79cca2b6-2069-4d98-b658-6b3f19527b89', N'Linh', N'Bắc Ninh', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'linhte', N'LINHTE', N'linh.nt@gmail.com', N'LINH.NT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGjscqwhywtwuCekQ7taoFFd1KmUzfSQlSgksV0ewpQ15iy+7djXd24TnxWiDcxolw==', N'TDAZTF4Q52YLQGR3HBSVZ35NIDKMNFSC', N'8af52d74-e16a-4e5f-a376-1b9abaa67d7e', N'0988733123', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'84ed688b-7813-42c2-91a1-7a30e09d3df8', N'Alexis Zorbas', N'2079 Keyser Ridge Road', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'eudora', N'EUDORA', N'jeremie1999@hotmail.com', N'JEREMIE1999@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAsJkwIK8igriP/D66SqX6OLvTT+041i2ujZ8//rUb6EkNPi/StEjAN/jyGx/hQ4wQ==', N'MNLLKTAFINZND5EHTEJA7BRFYZQPKVHZ', N'b384e689-a849-40dd-85b5-c8d15968cc30', N'336-202-1900', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'988a3644-01d4-40cd-a309-1c6195093960', N'Bachelor', N'1824 Petunia Way', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'ProfPyrowise', N'PROFPYROWISE', N'christ2010@hotmail.com', N'CHRIST2010@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAg7jRPJiyHjB5q0W6wiZapfkljEFbfmBrlaqz6LfZkxV7k20GZ42x/0/sc927u1bg==', N'MFG7NKOVL4K4CIOSW7AJROZFDJSRGG32', N'02fca772-2fa6-47ed-9c3d-f676bb66e925', N'205-816-2567', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'99c6bc0c-a1bf-4052-818e-9f9867fcbb43', N'Ngo Van Can', N'Bac Ninh', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'canv.space', N'CANV.SPACE', N'mail@canv.space', N'MAIL@CANV.SPACE', 0, N'AQAAAAEAACcQAAAAEIEqgEErzTMr2TNLPEVFaBBna6JJXA3C2avzbqTbAf9wVRo9KbgCvIQBMyrs5wuTcw==', N'FIW6Y5OM472W7KD2DOIGG3KNDA2S7OLP', N'10fe252b-993f-46c0-afd1-1da5dc4d7522', N'0972323964', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b74ddd14-6340-4840-95c2-db12554843e5', NULL, NULL, 0, 0, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAELE0y0XqUU8SqJj0kzFlP+rHF6rfr0+m97abWJzb46Bwiky5z3gjdLt6Xq7kDaCTgA==', N'a8a431c9-fb1c-4dd7-bb70-86f92bbbf229', N'7e97cf3f-9b3c-4559-9127-d63b8cd99c90', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Address], [Status], [Type], [Code], [Logo], [IsDel], [CreatedDate], [ModifiedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f3e8a262-6fd6-44c2-a355-272e3cc8eb83', N'Green Marketer', N'617 Thunder Road', 0, 1, NULL, NULL, 0, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'ford', N'FORD', N'carolyne_labad@gmail.com', N'CAROLYNE_LABAD@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBmj9SNsXCVcCHMUDoIFaoIV29nYJIUOjs9DbVJ7ZMI1Wz7EjLHdtESH2KnmaTgooQ==', N'5424Q5F65HNYD2KG7B47G23FDS3J64RY', N'bd6c1acd-a396-4f55-97f0-b029e009a5e6', N'408-509-1679', 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Bus] ON 

INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Motor coach', 26, 0, NULL, CAST(N'2022-06-12 05:08:29.9377921' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'School bus', 26, 0, NULL, CAST(N'2022-06-12 05:08:36.3048870' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Shuttle bus', 30, 0, NULL, CAST(N'2022-06-12 05:08:42.3028238' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Minibus', 6, 0, NULL, CAST(N'2022-06-12 05:08:48.2472112' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Minicoach', 8, 0, NULL, CAST(N'2022-06-12 05:08:54.5981903' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Double-decker bus', 30, 0, NULL, CAST(N'2022-06-12 05:09:00.3422225' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Single-decker bus', 25, 0, NULL, CAST(N'2022-06-12 05:09:06.2620884' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Low-floor bus', 20, 0, NULL, CAST(N'2022-06-12 05:09:13.0841378' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Step-entrance bus', 15, 0, NULL, CAST(N'2022-06-12 05:09:18.9975902' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Trolleybus', 21, 0, NULL, CAST(N'2022-06-12 05:09:24.2460366' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Articulated bus', 20, 0, NULL, CAST(N'2022-06-12 05:09:30.5894167' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Neighbourhood bus', 10, 0, NULL, CAST(N'2022-06-12 05:09:35.6530828' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Training bus', 10, 0, NULL, CAST(N'2022-06-12 05:09:41.7095892' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Gyrobus', 6, 0, NULL, CAST(N'2022-06-12 05:09:48.6528451' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Bus] ([Id], [Name], [Quantity], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Open top bus', 26, 0, NULL, CAST(N'2022-06-12 05:09:55.5234128' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Bus] OFF
SET IDENTITY_INSERT [dbo].[BusSchedules] ON 

INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, 2, 15, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 05:10:53.7226804' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, 1, 15, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 05:11:00.0611913' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, 3, 15, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 06:36:53.8822441' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, 13, 15, CAST(7.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:11:06.0612114' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, 25, 13, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:11:12.7334543' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, 9, 3, CAST(30.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:11:23.5244916' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, 26, 3, CAST(30.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:11:30.6615389' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, 2, 1, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:11:37.8379486' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, 17, 1, CAST(8.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:13:41.2946678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, 24, 7, CAST(7.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:13:50.6206044' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, 14, 3, CAST(2.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:13:57.8386947' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, 19, 12, CAST(5.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:15:33.0701461' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, 19, 3, CAST(10.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:15:41.5238894' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[BusSchedules] ([Id], [TimeScheduleId], [BusId], [PriceTicket], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, 26, 13, CAST(15.0 AS Decimal(18, 1)), 0, NULL, CAST(N'2022-06-12 07:16:02.8051983' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[BusSchedules] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Cloyd Ward', N'Olen_Hansen@hotmail.com', N'983-420-6070', N'397 Tillman Rapids, Gaylordview, Iran', CAST(N'1986-12-05 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Lamont Reinger', N'Colton2@yahoo.com', N'539-913-4826', N'92769 Kutch Place, West Jerrold, Isle of Man', CAST(N'1973-07-23 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Manley Tromp', N'Jeanette.Fay80@hotmail.com', N'626-463-2544', N'72716 Greta Squares, Bergstrommouth, Jersey', CAST(N'1955-04-16 14:03:29.9205200' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Waino Fisher', N'Lavern84@yahoo.com', N'467-277-1402', N'54049 Hazel Courts, Araceliborough, Chad', CAST(N'1963-08-11 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Maxine Denesik', N'Emilia_Kunze93@gmail.com', N'219-545-6734', N'436 Earl Knoll, West Glenna, Nigeria', CAST(N'1967-10-13 16:35:09.3531753' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Zackary Bayer', N'Jessica_Kihn@gmail.com', N'467-478-7777', N'93119 Crooks Mill, South Addie, Peru', CAST(N'1945-08-11 09:26:33.5132297' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Aileen Douglas', N'Katrina91@hotmail.com', N'878-457-3626', N'08525 Hortense Center, Coletown, Panama', CAST(N'1948-07-26 20:32:05.8748287' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Hassan Keeling', N'Verdie16@gmail.com', N'641-254-8262', N'50461 Nolan Locks, Lake Keeley, Lao People''s Democratic Republic', CAST(N'1960-03-24 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Donna Nitzsche', N'Beulah65@gmail.com', N'429-587-8207', N'1304 Robyn Prairie, Grantfurt, Sudan', CAST(N'1947-05-03 13:19:26.1086101' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Pauline Rosenbaum', N'Miracle.Haag@hotmail.com', N'745-391-8430', N'294 Mueller Fields, Metzville, Palau', CAST(N'1958-08-09 12:49:13.4734428' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Pauline Weber', N'Abdiel_Bergstrom@gmail.com', N'953-989-6779', N'80308 Abshire Track, Lake Sashachester, Estonia', CAST(N'1970-06-02 08:29:36.6402249' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Rubye Oberbrunner', N'Esperanza_Grimes@hotmail.com', N'342-416-9946', N'98221 Wuckert Shores, Binsstad, Palau', CAST(N'1991-06-22 19:43:43.7192091' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Destin Ward', N'Marlen.Parker@gmail.com', N'645-885-8099', N'53013 Hilario Islands, Lake Bert, Lesotho', CAST(N'1959-01-05 15:22:09.4324810' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Polly Nikolaus', N'Cielo_Nader24@yahoo.com', N'873-347-4577', N'757 Jacobi Ports, Hansenfort, Tunisia', CAST(N'1952-09-24 16:25:44.6734491' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Easton Bogisich', N'Danielle19@hotmail.com', N'304-705-3622', N'7358 Ullrich Dam, New Kieranville, Barbados', CAST(N'1973-08-30 02:25:48.6802551' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'Ora Adams', N'Demond36@yahoo.com', N'695-243-8637', N'70952 Huel Club, New Keon, Comoros', CAST(N'1992-08-25 05:38:23.8244063' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'Eriberto O''Keefe', N'Simeon38@hotmail.com', N'544-953-0979', N'1643 Wintheiser Mill, New Stacy, Guam', CAST(N'1981-01-25 13:50:12.3614309' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'Henriette MacGyver', N'Cecilia_Boyle@gmail.com', N'338-479-1364', N'228 Grady Viaduct, North Romanshire, Cyprus', CAST(N'1977-10-22 08:35:28.2646014' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'Cristobal Towne', N'Hipolito27@gmail.com', N'920-812-4093', N'619 Shanahan Vista, Bradyville, Egypt', CAST(N'1981-08-06 04:34:47.4275147' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'Orpha Stehr', N'Augusta_Koelpin@gmail.com', N'935-446-5753', N'0460 Effertz Glens, Yeseniamouth, Finland', CAST(N'1997-01-17 01:27:48.5080577' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'Samir Pfeffer', N'Americo_Beahan@hotmail.com', N'485-818-5572', N'31747 Lowe Spur, East Francisco, Solomon Islands', CAST(N'1964-03-09 19:59:43.6060711' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'Walker Goldner', N'Cortney_McKenzie72@gmail.com', N'523-992-2398', N'537 Henriette Mills, Port Berenice, Bosnia and Herzegovina', CAST(N'1955-02-16 17:04:34.6028601' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'Leila Bauch', N'Paige60@hotmail.com', N'995-653-9421', N'522 Abel Mountains, New Linnie, Grenada', CAST(N'1976-12-21 18:12:47.4868203' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'Donavon Fahey', N'Eudora.Towne46@hotmail.com', N'639-401-6380', N'261 Schuppe Village, Yoshikochester, Nepal', CAST(N'1989-05-07 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'Arlene Hammes', N'Eleonore_Gislason8@hotmail.com', N'677-290-0662', N'667 Daphnee Rest, North Samantha, Ukraine', CAST(N'1948-08-09 16:44:44.1136697' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'Zakary Rau', N'Walter.Cruickshank61@yahoo.com', N'952-931-3169', N'9562 O''Keefe Rapid, South Will, Honduras', CAST(N'1977-03-16 03:49:05.7301325' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'Tyree Krajcik', N'Ivory50@yahoo.com', N'837-910-3256', N'2621 Harvey Forks, Lake Domenico, Montserrat', CAST(N'1961-01-23 19:10:16.2749768' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'Hellen Ziemann', N'Pamela_Tremblay@yahoo.com', N'551-265-2891', N'70792 Kuhlman Way, South Leathaton, Estonia', CAST(N'1963-11-04 04:48:55.7715468' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'Leonor Pollich', N'Pattie_Reichert@gmail.com', N'847-924-3318', N'3753 Morissette Ford, Madysonmouth, Tanzania', CAST(N'1993-03-21 11:26:47.1355659' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'Rosemarie Baumbach', N'Heloise.Kirlin@gmail.com', N'487-598-6280', N'3043 Goodwin Mews, Port Davinside, Ireland', CAST(N'1957-11-23 03:48:01.5431336' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'Kassandra Rippin', N'Loy_Considine32@hotmail.com', N'776-803-6685', N'9546 Gottlieb Circle, West Landenside, Central African Republic', CAST(N'1953-12-04 02:59:12.5093552' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'Frederick Mosciski', N'Wilson_Stanton@hotmail.com', N'247-878-6059', N'158 Salvatore Mill, South Anseltown, Equatorial Guinea', CAST(N'1954-03-11 06:57:10.7612885' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'Reagan Schmitt', N'Marcus58@hotmail.com', N'728-828-8960', N'491 Reichel Light, Kihnhaven, French Southern Territories', CAST(N'1990-11-21 19:03:56.7268607' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'Shakira Cassin', N'Tracey.Brakus@yahoo.com', N'389-320-5861', N'021 Maribel Knolls, New Serena, Isle of Man', CAST(N'1960-06-23 12:42:24.6752587' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (35, N'Stephanie Kuphal', N'Terrill67@gmail.com', N'836-786-2961', N'905 Russell Mills, New Benjamin, Bangladesh', CAST(N'1989-03-06 23:49:43.6306861' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (36, N'Cecile McGlynn', N'Brandyn_Brakus@hotmail.com', N'211-400-6552', N'91819 Rickey Summit, North Orlandmouth, Bouvet Island (Bouvetoya)', CAST(N'1958-01-24 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (37, N'Tania Hodkiewicz', N'Joany.Fay@yahoo.com', N'648-806-7852', N'29725 Steuber Landing, Rathborough, Svalbard & Jan Mayen Islands', CAST(N'1986-08-29 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (38, N'Korbin Prohaska', N'Demarcus7@hotmail.com', N'488-787-1875', N'9381 Gino Crest, Kshlerinview, Indonesia', CAST(N'1976-01-16 02:24:42.1062894' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (39, N'Blaise Corwin', N'Velda_Johns@yahoo.com', N'542-229-2826', N'794 Libby Rapids, Theronchester, Vanuatu', CAST(N'1968-02-18 21:54:44.2718571' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (40, N'Waldo Botsford', N'Samara_Ferry@gmail.com', N'780-406-7723', N'4281 Orland Neck, Port Mallory, Latvia', CAST(N'1980-12-22 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (41, N'Shannon Kutch', N'Scarlett_Wilkinson@hotmail.com', N'828-873-9187', N'9884 Fay Island, New Oletatown, Croatia', CAST(N'1955-01-26 18:10:24.1556832' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (42, N'Abe Kutch', N'Ahmed_Schultz82@gmail.com', N'436-942-6609', N'069 Feeney Ways, New Ferne, Malta', CAST(N'1970-11-28 22:01:03.8418668' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (43, N'Merlin Anderson', N'Magnus27@gmail.com', N'875-993-0034', N'65782 Kailey Brooks, East Destany, Japan', CAST(N'1963-12-31 18:27:53.1555977' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (44, N'Lester Veum', N'Kaitlin_Huel83@gmail.com', N'574-366-6554', N'5912 Herman Inlet, Port Virginieview, Cape Verde', CAST(N'1980-03-12 16:29:19.8623954' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (45, N'Gwen Padberg', N'Alfonso.Kuhic85@hotmail.com', N'249-496-9266', N'9129 Russel Haven, New Verdiemouth, Belgium', CAST(N'1958-10-20 09:14:48.6746272' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (46, N'Pink McLaughlin', N'Korey_Steuber8@hotmail.com', N'585-912-8422', N'248 Rau Gateway, Port Hailey, Liberia', CAST(N'1958-01-14 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (47, N'Zula Heathcote', N'Timothy11@hotmail.com', N'215-636-4354', N'027 Jennie Falls, South Lourdes, Hong Kong', CAST(N'1992-01-31 01:14:58.1188088' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (48, N'Ivah Schimmel', N'Hilton.Haag@gmail.com', N'711-342-7570', N'6413 Joyce Center, Marvinmouth, Solomon Islands', CAST(N'2002-11-17 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (49, N'Roma Lowe', N'Favian17@gmail.com', N'261-849-2316', N'96727 Crawford Bridge, Lake Dimitriside, Guernsey', CAST(N'1957-10-14 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (50, N'Carlie Lesch', N'Kamille.Strosin36@hotmail.com', N'936-858-0593', N'256 Evalyn Station, Andersonside, Brunei Darussalam', CAST(N'1981-10-05 19:59:29.1592969' AS DateTime2), NULL, CAST(N'2022-06-12 05:05:22.9053678' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (51, N'Nguyễn Văn Nam', NULL, N'0985966987', N'Bắc Ninh Hà Nội', CAST(N'2018-05-08 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 15:29:46.5304346' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Customers] ([Id], [FullName], [Email], [Phone], [Address], [Birthday], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (52, N'Hà Văn Văn', NULL, N'0972323964', N'Hà Nội', CAST(N'2006-06-06 00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-12 15:33:44.5360821' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Bắc Giang', N'Bắc Ninh', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-06-13 13:30:00.0000000' AS DateTime2), N'Open top bus', 1, NULL, CAST(N'2022-06-12 05:11:52.5686561' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Bắc Giang', N'Bắc Ninh', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-15 11:30:00.0000000' AS DateTime2), N'Open top bus', 2, NULL, CAST(N'2022-06-12 06:20:35.8895226' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Bắc Giang', N'Bắc Ninh', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-13 12:00:00.0000000' AS DateTime2), N'Open top bus', 3, NULL, CAST(N'2022-06-12 06:37:11.9815153' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Bắc Giang', N'Bắc Ninh', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-13 12:00:00.0000000' AS DateTime2), N'Open top bus', 4, NULL, CAST(N'2022-06-12 06:50:16.4357233' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 5, NULL, CAST(N'2022-06-12 08:09:52.3697909' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Hà Nam', N'Tuyên Quang', CAST(30.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Shuttle bus', 6, NULL, CAST(N'2022-06-12 15:22:47.7635897' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Hà Nam', N'Tuyên Quang', CAST(30.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Shuttle bus', 7, NULL, CAST(N'2022-06-12 15:27:21.0855004' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Hà Nam', N'Tuyên Quang', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-25 17:00:00.0000000' AS DateTime2), N'Training bus', 8, NULL, CAST(N'2022-06-12 15:27:26.5117614' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 9, NULL, CAST(N'2022-06-12 15:27:58.4224532' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 10, NULL, CAST(N'2022-06-12 15:29:14.9123954' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 11, NULL, CAST(N'2022-06-12 15:29:46.5377846' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 12, NULL, CAST(N'2022-06-12 15:30:08.1634329' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 13, NULL, CAST(N'2022-06-12 15:30:17.3811842' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 14, NULL, CAST(N'2022-06-12 15:30:24.5453850' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 15, NULL, CAST(N'2022-06-12 15:30:33.1213432' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 16, NULL, CAST(N'2022-06-12 15:30:44.5468547' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'Hà Nam', N'Tuyên Quang', CAST(15.0 AS Decimal(18, 1)), CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), N'Training bus', 17, NULL, CAST(N'2022-06-12 15:30:52.2275404' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-19 11:30:00.0000000' AS DateTime2), N'Shuttle bus', 18, NULL, CAST(N'2022-06-12 15:31:08.4489961' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'Quận Thanh Xuân', N'Quận Cầu Giấy', CAST(5.0 AS Decimal(18, 1)), CAST(N'2022-06-19 11:30:00.0000000' AS DateTime2), N'Neighbourhood bus', 19, NULL, CAST(N'2022-06-12 15:31:12.7285769' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'Bắc Giang', N'Bắc Ninh', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-15 11:30:00.0000000' AS DateTime2), N'Open top bus', 20, NULL, CAST(N'2022-06-12 15:33:44.5424107' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[OrderDetail] ([Id], [From], [To], [Price], [StartTime], [BusName], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'Bắc Giang', N'Bắc Ninh', CAST(10.0 AS Decimal(18, 1)), CAST(N'2022-06-15 11:30:00.0000000' AS DateTime2), N'Open top bus', 21, NULL, CAST(N'2022-06-12 15:34:27.3229659' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 1, 0, 1, 2, NULL, CAST(N'2022-06-12 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 30, 8, 1, NULL, CAST(N'2022-06-11 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 0, 2, 3, NULL, CAST(N'2022-06-11 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 0, 2, 3, NULL, CAST(N'2022-06-11 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 2, 14, NULL, CAST(N'2022-06-10 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(30.0 AS Decimal(18, 1)), CAST(30.0 AS Decimal(18, 1)), 0, 0, 2, 7, NULL, CAST(N'2022-06-10 05:11:52.5299795' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(21.0 AS Decimal(18, 1)), CAST(30.0 AS Decimal(18, 1)), 1, 30, 4, 7, NULL, CAST(N'2022-06-12 15:27:20.9797002' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 37, 5, NULL, CAST(N'2022-06-12 15:27:26.5089431' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 2, 14, NULL, CAST(N'2022-06-12 15:27:58.4145689' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 30, 4, 14, NULL, CAST(N'2022-06-12 15:29:14.9057324' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(0.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 1, 100, 51, 14, NULL, CAST(N'2022-06-12 15:29:46.5363118' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 49, 14, NULL, CAST(N'2022-06-12 15:30:08.1615956' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 48, 14, NULL, CAST(N'2022-06-12 15:30:17.3756440' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(15.0 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 0, 40, 14, NULL, CAST(N'2022-06-12 15:30:24.5437230' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 49, 14, NULL, CAST(N'2022-06-12 15:30:33.1197822' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 46, 14, NULL, CAST(N'2022-06-12 15:30:44.5453323' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), CAST(15.0 AS Decimal(18, 1)), 0, 30, 36, 14, NULL, CAST(N'2022-06-12 15:30:52.2258882' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(7.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 30, 4, 13, NULL, CAST(N'2022-06-12 15:31:08.4474173' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(5.0 AS Decimal(18, 1)), CAST(5.0 AS Decimal(18, 1)), 0, 0, 24, 12, NULL, CAST(N'2022-06-12 15:31:12.7273845' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 0, 0, 52, 1, NULL, CAST(N'2022-06-12 15:33:44.5382448' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Orders] ([Id], [UserId], [Amount], [Total], [Status], [Discount], [CustomerId], [BusCheduleId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.0 AS Decimal(18, 1)), CAST(10.0 AS Decimal(18, 1)), 1, 0, 52, 1, NULL, CAST(N'2022-06-12 15:34:27.3205040' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'Bắc Giang', N'Bắc Ninh', 0, NULL, CAST(N'2022-06-12 05:10:10.7103874' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'Hanoi (Hà Nội)', N'Hải Phòng', 0, NULL, CAST(N'2022-06-12 06:52:27.6947894' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'Hà Nam', N'Tuyên Quang', 0, NULL, CAST(N'2022-06-12 06:52:37.6686038' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'Hồ Chí Minh', N'Cần Thơ', 0, NULL, CAST(N'2022-06-12 06:52:47.6118345' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'Quận Thanh Xuân', N'Quận Cầu Giấy', 0, NULL, CAST(N'2022-06-12 06:52:56.8356768' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'Hanoi (Hà Nội)', N'Sapa', 0, NULL, CAST(N'2022-06-12 06:53:22.7498505' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'Bến Xe Mỹ Đình', N'Bến Xe Gia Lâm', 0, NULL, CAST(N'2022-06-12 06:53:31.5070861' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'Cao Bằng', N'Lào Cai', 0, NULL, CAST(N'2022-06-12 06:53:41.1772329' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Schedules] ([Id], [From], [To], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'Hồ Tây', N'Hồ Gươm', 0, NULL, CAST(N'2022-06-12 06:53:55.1934441' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Schedules] OFF
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'VBus_0', 2, 1, NULL, CAST(N'2022-06-12 05:11:52.5987651' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'VBus_2', 2, 2, NULL, CAST(N'2022-06-12 06:20:35.8969977' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'VBus_3', 2, 3, NULL, CAST(N'2022-06-12 06:37:11.9879707' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'VBus_4', 2, 4, NULL, CAST(N'2022-06-12 06:50:16.4408989' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'VBus_5', 0, 5, NULL, CAST(N'2022-06-12 08:09:52.3948219' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'VBus_6', 0, 6, NULL, CAST(N'2022-06-12 15:22:47.7709515' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'VBus_7', 2, 7, NULL, CAST(N'2022-06-12 15:27:21.0925463' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'VBus_8', 0, 8, NULL, CAST(N'2022-06-12 15:27:26.5125700' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'VBus_9', 0, 9, NULL, CAST(N'2022-06-12 15:27:58.4236308' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'VBus_10', 2, 10, NULL, CAST(N'2022-06-12 15:29:14.9136858' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'VBus_11', 2, 11, NULL, CAST(N'2022-06-12 15:29:46.5382456' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'VBus_12', 0, 12, NULL, CAST(N'2022-06-12 15:30:08.1640408' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'VBus_13', 0, 13, NULL, CAST(N'2022-06-12 15:30:17.3819081' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'VBus_14', 0, 14, NULL, CAST(N'2022-06-12 15:30:24.5459503' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'VBus_15', 0, 15, NULL, CAST(N'2022-06-12 15:30:33.1218960' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'VBus_16', 0, 16, NULL, CAST(N'2022-06-12 15:30:44.5473903' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'VBus_17', 0, 17, NULL, CAST(N'2022-06-12 15:30:52.2279773' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'VBus_18', 0, 18, NULL, CAST(N'2022-06-12 15:31:08.4494557' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'VBus_19', 0, 19, NULL, CAST(N'2022-06-12 15:31:12.7289303' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'VBus_20', 0, 20, NULL, CAST(N'2022-06-12 15:33:44.5433111' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tickets] ([Id], [Code], [Status], [OrderId], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'VBus_21', 2, 21, NULL, CAST(N'2022-06-12 15:34:27.3234319' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
SET IDENTITY_INSERT [dbo].[TimeSchedule] ON 

INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, 1, CAST(N'2022-06-13 13:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 05:10:31.4896716' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, 1, CAST(N'2022-06-15 11:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 05:10:42.2053568' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, 1, CAST(N'2022-06-13 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 06:36:42.5855487' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, 9, CAST(N'2022-06-12 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:01:23.9420521' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, 9, CAST(N'2022-06-18 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:01:28.0406832' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, 9, CAST(N'2022-06-13 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:01:31.2783509' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, 9, CAST(N'2022-06-22 11:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:01:37.2703973' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, 9, CAST(N'2022-06-19 05:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:01:42.4403392' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, 8, CAST(N'2022-06-05 04:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:02:35.0762666' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, 8, CAST(N'2022-06-14 05:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:02:39.9597566' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, 8, CAST(N'2022-06-15 18:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:02:45.6308332' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, 8, CAST(N'2022-06-14 06:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:02:50.7439912' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, 8, CAST(N'2022-06-16 07:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:02:57.1044292' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, 7, CAST(N'2022-06-17 08:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:04.9158559' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, 7, CAST(N'2022-06-26 05:02:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:12.6475209' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, 7, CAST(N'2022-06-16 10:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:18.9123007' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, 6, CAST(N'2022-07-08 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:35.0963036' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, 6, CAST(N'2022-07-09 17:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:41.8084643' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, 5, CAST(N'2022-06-19 11:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:03:50.6435021' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, 5, CAST(N'2022-06-27 15:30:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:03.3173201' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, 5, CAST(N'2022-06-25 17:20:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:09.5293290' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, 4, CAST(N'2022-06-30 12:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:13.3115900' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, 4, CAST(N'2022-06-19 21:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:19.1858695' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, 3, CAST(N'2022-06-26 16:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:25.1997913' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, 3, CAST(N'2022-06-25 17:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:28.6479034' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TimeSchedule] ([Id], [ScheduleId], [StartTime], [Status], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, 3, CAST(N'2022-06-30 20:00:00.0000000' AS DateTime2), 0, NULL, CAST(N'2022-06-12 07:04:33.3270930' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[TimeSchedule] OFF
SET IDENTITY_INSERT [dbo].[TransactionHis] ON 

INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 1', NULL, CAST(N'2022-06-12 12:11:52.5805262' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(5.0 AS Decimal(18, 1)), 0, 2, N'admin', N'Canel OrderID: 1', NULL, CAST(N'2022-06-12 06:12:22.4214350' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 2', NULL, CAST(N'2022-06-12 13:20:35.8912019' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 3', NULL, CAST(N'2022-06-12 13:37:11.9826049' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(7.0 AS Decimal(18, 1)), 0, 2, N'admin', N'Canel OrderID: 3', NULL, CAST(N'2022-06-12 06:41:49.7200276' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(7.0 AS Decimal(18, 1)), 0, 2, N'admin', N'Payment for OrderId: 2', NULL, CAST(N'2022-06-12 06:49:49.6877007' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 4', NULL, CAST(N'2022-06-12 13:50:16.4368144' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(7.0 AS Decimal(18, 1)), 0, 2, N'admin', N'Payment for OrderId: 4 lost 30% / 10.0$ less 1 dáy', NULL, CAST(N'2022-06-12 06:50:34.1963499' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(700.0 AS Decimal(18, 1)), 0, 0, N'admin', N'admin sent', NULL, CAST(N'2022-06-12 07:26:32.3000444' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'114ceeb9-9318-4c58-9b79-5ab658013d12', CAST(10.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-12 08:04:57.8467707' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (11, N'99c6bc0c-a1bf-4052-818e-9f9867fcbb43', CAST(150.0 AS Decimal(18, 1)), 0, 0, N'admin', N'admin send', NULL, CAST(N'2022-06-12 08:05:06.3183197' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (12, N'f3e8a262-6fd6-44c2-a355-272e3cc8eb83', CAST(1.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-12 08:05:11.0664392' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (13, N'988a3644-01d4-40cd-a309-1c6195093960', CAST(20.0 AS Decimal(18, 1)), 0, 0, N'admin', NULL, NULL, CAST(N'2022-06-12 08:05:15.8369602' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (14, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 5', NULL, CAST(N'2022-06-12 15:09:52.3819626' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (15, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(30.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 6', NULL, CAST(N'2022-06-12 15:22:47.7652322' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (16, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(21.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 7', NULL, CAST(N'2022-06-12 15:27:21.0871259' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (17, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 8', NULL, CAST(N'2022-06-12 15:27:26.5118956' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (18, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'admin', N'Payment for OrderId: 9', NULL, CAST(N'2022-06-12 15:27:58.4226854' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (19, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 10', NULL, CAST(N'2022-06-12 15:29:14.9126907' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (20, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(0.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 11', NULL, CAST(N'2022-06-12 15:29:46.5378515' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (21, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 12', NULL, CAST(N'2022-06-12 15:30:08.1635933' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (22, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 13', NULL, CAST(N'2022-06-12 15:30:17.3812538' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (23, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(15.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 14', NULL, CAST(N'2022-06-12 15:30:24.5454888' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (24, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 15', NULL, CAST(N'2022-06-12 15:30:33.1214501' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (25, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 16', NULL, CAST(N'2022-06-12 15:30:44.5469526' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (26, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 17', NULL, CAST(N'2022-06-12 15:30:52.2276051' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (27, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(7.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 18', NULL, CAST(N'2022-06-12 15:31:08.4490725' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (28, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(5.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 19', NULL, CAST(N'2022-06-12 15:31:12.7286217' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (29, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.5 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 10', NULL, CAST(N'2022-06-12 15:31:31.8968173' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (30, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(0.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 11', NULL, CAST(N'2022-06-12 15:32:44.8293849' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (31, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 20', NULL, CAST(N'2022-06-12 15:33:44.5424862' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (32, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.0 AS Decimal(18, 1)), 1, 1, N'cannv', N'Payment for OrderId: 21', NULL, CAST(N'2022-06-12 15:34:27.3230395' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (33, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(10.0 AS Decimal(18, 1)), 0, 2, N'cannv', N'Refund for OrderId: 21', NULL, CAST(N'2022-06-12 15:40:30.2456659' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[TransactionHis] ([id], [user_id], [credit], [status], [type], [created_by], [Message], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (34, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(21.0 AS Decimal(18, 1)), 0, 2, N'admin', N'Refund for OrderId: 7', NULL, CAST(N'2022-06-12 20:31:45.3787390' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[TransactionHis] OFF
SET IDENTITY_INSERT [dbo].[Wallets] ON 

INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (1, N'b74ddd14-6340-4840-95c2-db12554843e5', CAST(24.0 AS Decimal(18, 1)), N'admin', CAST(N'2022-06-12 12:05:22.8517876' AS DateTime2), CAST(N'2022-06-12 13:31:45.3761915' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (2, N'3bbd4f24-3250-4965-bbed-dfb12912f6a3', CAST(606.0 AS Decimal(18, 1)), N'cannv', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2022-06-12 08:40:30.2430958' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (3, N'79cca2b6-2069-4d98-b658-6b3f19527b89', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (4, N'114ceeb9-9318-4c58-9b79-5ab658013d12', CAST(10.0 AS Decimal(18, 1)), N'admin', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2022-06-12 08:04:57.8465651' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (5, N'4acdea16-ba9e-4ae0-a1c4-4bca6e525ea0', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (6, N'84ed688b-7813-42c2-91a1-7a30e09d3df8', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (7, N'f3e8a262-6fd6-44c2-a355-272e3cc8eb83', CAST(1.0 AS Decimal(18, 1)), N'admin', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2022-06-12 08:05:11.0663215' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (8, N'37fe9ef0-2937-4079-a8a2-d619640e501b', CAST(0.0 AS Decimal(18, 1)), NULL, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (9, N'988a3644-01d4-40cd-a309-1c6195093960', CAST(20.0 AS Decimal(18, 1)), N'admin', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2022-06-12 08:05:15.8368495' AS DateTime2), 0)
INSERT [dbo].[Wallets] ([id], [user_id], [amount], [modified_by], [created_date], [modified_date], [IsDel]) VALUES (10, N'99c6bc0c-a1bf-4052-818e-9f9867fcbb43', CAST(150.0 AS Decimal(18, 1)), N'admin', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2022-06-12 08:05:06.3181760' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Wallets] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BusSchedules_BusId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusSchedules_BusId] ON [dbo].[BusSchedules]
(
	[BusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BusSchedules_TimeScheduleId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusSchedules_TimeScheduleId] ON [dbo].[BusSchedules]
(
	[TimeScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_OrderId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_OrderId] ON [dbo].[OrderDetail]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_BusCheduleId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_BusCheduleId] ON [dbo].[Orders]
(
	[BusCheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_CustomerId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId] ON [dbo].[Orders]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tickets_OrderId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tickets_OrderId] ON [dbo].[Tickets]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimeSchedule_ScheduleId]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_TimeSchedule_ScheduleId] ON [dbo].[TimeSchedule]
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TransactionHis_user_id]    Script Date: 6/12/2022 11:18:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_TransactionHis_user_id] ON [dbo].[TransactionHis]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Wallets_user_id]    Script Date: 6/12/2022 11:18:50 PM ******/
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
ALTER DATABASE [NewDB] SET  READ_WRITE 
GO
