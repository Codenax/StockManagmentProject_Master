USE [master]
GO
/****** Object:  Database [StockManagementSystem]    Script Date: 15-Nov-18 2:02:05 PM ******/
CREATE DATABASE [StockManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockManagementSystem.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockManagementSystem_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockManagementSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagementSystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StockManagementSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StockManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagementSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StockManagementSystem]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[SL] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[SL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Companies]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[SL] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](50) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[SL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Itemes]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itemes](
	[Category] [nvarchar](50) NULL,
	[CategoryID] [int] NULL,
	[Company] [nvarchar](50) NULL,
	[CompanyID] [int] NULL,
	[Item] [nvarchar](50) NULL,
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ReoderLevel] [int] NULL,
 CONSTRAINT [PK_Itemes] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesDate]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDate](
	[Sl] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](50) NULL,
	[SaleQuantity] [int] NOT NULL,
	[SaleDate] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[SL] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[CategoryID] [int] NULL,
	[Company] [nvarchar](50) NULL,
	[CompanyID] [int] NULL,
	[Item] [nvarchar](50) NULL,
	[ItemID] [int] NOT NULL,
	[StockInQuantity] [int] NOT NULL,
	[SalesQuantity] [int] NOT NULL,
	[DamageQuantity] [int] NOT NULL,
	[LostQuantity] [int] NOT NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[SL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[StockOut]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StockOut] AS
SELECT Item,ItemId,StockInQuantity,SalesQuantity,DamageQuantity,LostQuantity
FROM StockIn
GO
/****** Object:  View [dbo].[StockInOut]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StockInOut]
AS
SELECT        Item, SUM(ItemId) AS ItemID, SUM(StockInQuantity) AS StockInQuantity, SUM(SalesQuantity) AS SalesQuantity, SUM(DamageQuantity) AS DamageQuantity, SUM(LostQuantity) AS LostQuantity
FROM            dbo.StockOut
GROUP BY Item

GO
/****** Object:  View [dbo].[AvailableQuantities]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AvailableQuantities]
AS
SELECT        Item, ItemID, StockInQuantity, SalesQuantity, DamageQuantity, LostQuantity, StockInQuantity - (SalesQuantity + DamageQuantity + LostQuantity) AS AvailableQuantity
FROM            dbo.StockInOut

GO
/****** Object:  View [dbo].[SearchCom_Cat]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SearchCom_Cat]
AS
SELECT        dbo.Itemes.Item, dbo.Itemes.Company, dbo.Itemes.Category, dbo.AvailableQuantities.AvailableQuantity, dbo.Itemes.ReoderLevel, dbo.Itemes.CategoryID, dbo.Itemes.CompanyID
FROM            dbo.Itemes INNER JOIN
                         dbo.AvailableQuantities ON dbo.Itemes.ItemID = dbo.AvailableQuantities.ItemID

GO
/****** Object:  View [dbo].[CategoryListCompanySelect]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CategoryListCompanySelect]
AS
SELECT DISTINCT dbo.Categories.SL, dbo.SearchCom_Cat.Category, dbo.SearchCom_Cat.CompanyID
FROM            dbo.Categories INNER JOIN
                         dbo.SearchCom_Cat ON dbo.Categories.Category = dbo.SearchCom_Cat.Category

GO
/****** Object:  View [dbo].[CategoryStockIn]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CategoryStockIn] AS  SELECT  DISTINCT CategoryID, Category From Itemes
GO
/****** Object:  View [dbo].[CompanyStockIn]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CompanyStockIn] AS SELECT  DISTINCT Company , CategoryID,CompanyID From Itemes
GO
/****** Object:  View [dbo].[SalesDateSearch]    Script Date: 15-Nov-18 2:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SalesDateSearch]
AS
SELECT        Item, SaleDate, SUM(SaleQuantity) AS SaleQuantity
FROM            dbo.SalesDate
GROUP BY SaleDate, Item

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([SL], [Category]) VALUES (1, N'Laptop')
INSERT [dbo].[Categories] ([SL], [Category]) VALUES (2, N'Pen')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([SL], [Company]) VALUES (1, N'Apple')
INSERT [dbo].[Companies] ([SL], [Company]) VALUES (2, N'Matador')
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[Itemes] ON 

INSERT [dbo].[Itemes] ([Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [ReoderLevel]) VALUES (N'Laptop', 1, N'Apple', 1, N'Macbook', 1, 20)
INSERT [dbo].[Itemes] ([Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [ReoderLevel]) VALUES (N'Pen', 2, N'Matador', 2, N'Soft grip Black', 2, 25)
SET IDENTITY_INSERT [dbo].[Itemes] OFF
SET IDENTITY_INSERT [dbo].[SalesDate] ON 

INSERT [dbo].[SalesDate] ([Sl], [Item], [SaleQuantity], [SaleDate]) VALUES (1, N'Macbook', 1000, CAST(0xF43E0B00 AS Date))
INSERT [dbo].[SalesDate] ([Sl], [Item], [SaleQuantity], [SaleDate]) VALUES (2, N'Soft grip Black', 1200, CAST(0xF43E0B00 AS Date))
INSERT [dbo].[SalesDate] ([Sl], [Item], [SaleQuantity], [SaleDate]) VALUES (3, N'Macbook', 70, CAST(0xF43E0B00 AS Date))
SET IDENTITY_INSERT [dbo].[SalesDate] OFF
SET IDENTITY_INSERT [dbo].[StockIn] ON 

INSERT [dbo].[StockIn] ([SL], [Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [StockInQuantity], [SalesQuantity], [DamageQuantity], [LostQuantity]) VALUES (1, N'Pen', 2, N'Matador', 2, N'Soft grip Black', 2, 5500, 0, 0, 0)
INSERT [dbo].[StockIn] ([SL], [Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [StockInQuantity], [SalesQuantity], [DamageQuantity], [LostQuantity]) VALUES (2, N'Laptop', 1, N'Apple', 1, N'Macbook', 1, 1100, 0, 0, 0)
INSERT [dbo].[StockIn] ([SL], [Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [StockInQuantity], [SalesQuantity], [DamageQuantity], [LostQuantity]) VALUES (3, NULL, NULL, N'Apple', NULL, N'Macbook', 0, 0, 1000, 0, 0)
INSERT [dbo].[StockIn] ([SL], [Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [StockInQuantity], [SalesQuantity], [DamageQuantity], [LostQuantity]) VALUES (4, NULL, NULL, N'Matador', NULL, N'Soft grip Black', 0, 0, 1200, 0, 0)
INSERT [dbo].[StockIn] ([SL], [Category], [CategoryID], [Company], [CompanyID], [Item], [ItemID], [StockInQuantity], [SalesQuantity], [DamageQuantity], [LostQuantity]) VALUES (5, NULL, NULL, N'Apple', NULL, N'Macbook', 0, 0, 70, 0, 0)
SET IDENTITY_INSERT [dbo].[StockIn] OFF
ALTER TABLE [dbo].[SalesDate] ADD  CONSTRAINT [DF_SalesDate_SaleQuantity]  DEFAULT ((0)) FOR [SaleQuantity]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_ItemID]  DEFAULT ((0)) FOR [ItemID]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_StockInQuantity_1]  DEFAULT ((0)) FOR [StockInQuantity]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_SalesQuantity]  DEFAULT ((0)) FOR [SalesQuantity]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_DamageQuantity]  DEFAULT ((0)) FOR [DamageQuantity]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_LostQuantity]  DEFAULT ((0)) FOR [LostQuantity]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[21] 2[13] 3) )"
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
         Begin Table = "StockInOut"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 217
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AvailableQuantities'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AvailableQuantities'
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
         Begin Table = "Categories"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SearchCom_Cat"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 3
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CategoryListCompanySelect'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CategoryListCompanySelect'
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
         Begin Table = "SalesDate"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesDateSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SalesDateSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[34] 2[21] 3) )"
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
         Begin Table = "Itemes"
            Begin Extent = 
               Top = 6
               Left = 259
               Bottom = 136
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AvailableQuantities"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 221
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
         Column = 2325
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SearchCom_Cat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SearchCom_Cat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[21] 2[20] 3) )"
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
         Begin Table = "StockOut"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 233
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
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockInOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockInOut'
GO
USE [master]
GO
ALTER DATABASE [StockManagementSystem] SET  READ_WRITE 
GO
