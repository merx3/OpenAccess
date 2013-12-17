-- Delete database if it exists
IF EXISTS(SELECT * FROM master.sys.databases WHERE NAME='ProductsManager')
BEGIN
  DROP DATABASE [ProductsManager]
END
GO
------------------------------

-- Create tables
CREATE DATABASE [ProductsManager]
GO

CREATE TABLE [ProductsManager].[dbo].[Categories](
  [Id] [INT] IDENTITY(1,1) NOT NULL,
  [Name][NVARCHAR](50) NOT NULL,
  [Description][NVARCHAR](500) NOT NULL,
  CONSTRAINT [PK_CategoriesId] PRIMARY KEY CLUSTERED
    ([Id] ASC)
);
GO

CREATE TABLE [ProductsManager].[dbo].[Products](
  [Id] [INT] IDENTITY(1,1) NOT NULL,
  [Name] [NVARCHAR](50) NOT NULL,
  [Price] [decimal](12, 2) NULL,
  [IsAvailable] [bit] NOT NULL DEFAULT 1,
  [CategoryId] [INT] NOT NULL,
  CONSTRAINT [PK_ProductId] PRIMARY KEY CLUSTERED
    ([Id] ASC),
  CONSTRAINT [FK_Categories] FOREIGN KEY([CategoryId]) 
    REFERENCES [ProductsManager].[dbo].[Categories] ([Id])
);
GO
------------------------------

-- Insert sample data
SET IDENTITY_INSERT [ProductsManager].[dbo].[Categories] ON
INSERT [ProductsManager].[dbo].[Categories] ([Id], [Name], [Description]) 
  VALUES (1, 'Drinks', 'non-alcoholic drinks');
INSERT [ProductsManager].[dbo].[Categories] ([Id], [Name], [Description]) 
  VALUES (2, 'Meat', 'not cooked meat. can be slightly prepared to be edible');
INSERT [ProductsManager].[dbo].[Categories] ([Id], [Name], [Description]) 
  VALUES (3, 'Spices', '-');
INSERT [ProductsManager].[dbo].[Categories] ([Id], [Name], [Description]) 
  VALUES (4, 'Alcohol', 'Any type of drinks that contain alcohol');
SET IDENTITY_INSERT [ProductsManager].[dbo].[Categories] OFF
GO

SET IDENTITY_INSERT [ProductsManager].[dbo].[Products] ON
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (1, 'Fanta portokal', 1.20, 1, 1)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (2, '7up', 1.99, 0, 1)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (3, 'Coca-Cola', 2.10, 1, 1)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (4, 'Salt', 0.80, 1, 3)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (5, 'Kamenitza', 2.40, 1, 4)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (6, 'Balentines', 21.80, 1, 4)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (7, 'Savoy', 12.00, 1, 4)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (8, 'Pushena lukanka', 4.20, 1, 2)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (9, 'sudjuk Orehite', 5.00, 0, 2)
INSERT [ProductsManager].[dbo].[Products] ([Id], [Name], [Price], [IsAvailable], [CategoryId])
  VALUES (10, 'Makedonska nadenica', 3.00, 1, 2)
SET IDENTITY_INSERT [ProductsManager].[dbo].[Products] OFF
GO
------------------------------

