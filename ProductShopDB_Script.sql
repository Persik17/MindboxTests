CREATE DATABASE [ProductShopDB] 
GO
USE [ProductShopDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 05.03.2024 0:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 05.03.2024 0:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](200) NOT NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Category]    Script Date: 05.03.2024 0:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Product] [int] NOT NULL,
	[Id_Category] [int] NULL,
 CONSTRAINT [PK_Product_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Natural')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Durable')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Non-Durable')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Non-Taxable')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Description], [Price]) VALUES (2, N'Green apple', N'"Green Apple" is a fresh and juicy variety of apples, which are characterized by a rich green skin color and a sweet taste.', CAST(5.45 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price]) VALUES (3, N'Blue jeans', N'"Blue Jeans" are classic straight-cut jeans made of high-quality denim', CAST(11.99 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Price]) VALUES (4, N'Huawei microwave', N'A "microwave oven" is a convenient household device that is designed for fast and uniform heating and cooking', CAST(47.49 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Product_Category] ON 

INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (4, 2, 1)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (5, 2, 3)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (6, 3, 2)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (7, 4, 2)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (8, 4, 4)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (9, 2, NULL)
INSERT [dbo].[Product_Category] ([Id], [Id_Product], [Id_Category]) VALUES (10, 4, NULL)
SET IDENTITY_INSERT [dbo].[Product_Category] OFF
GO
ALTER TABLE [dbo].[Product_Category]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_Category] FOREIGN KEY([Id_Category])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product_Category] CHECK CONSTRAINT [FK_Product_Category_Category]
GO
ALTER TABLE [dbo].[Product_Category]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_Product] FOREIGN KEY([Id_Product])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Product_Category] CHECK CONSTRAINT [FK_Product_Category_Product]
GO

/****** TEST 2 ******/
USE [ProductShopDB]
SELECT pc.Id, p.Name, c.Name 
FROM Product AS p 
LEFT JOIN Product_Category AS pc ON p.Id = pc.Id_Product 
LEFT JOIN Category AS c ON pc.Id_Category = c.Id 
ORDER BY p.Name ASC
/****** TEST 2 ******/

/****** RESULT ******
6	Blue jeans	Durable
4	Green apple	Natural
5	Green apple	Non-Durable
9	Green apple	NULL
7	Huawei microwave	Durable
8	Huawei microwave	Non-Taxable
10	Huawei microwave	NULL
******* RESULT ******/