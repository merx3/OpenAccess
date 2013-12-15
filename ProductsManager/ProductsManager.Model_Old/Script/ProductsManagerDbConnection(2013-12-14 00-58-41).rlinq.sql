-- ProductsManager.Model.Category
CREATE TABLE [dbo].[Category] (
    [Name] nvarchar NOT NULL,               -- _name
    [Id] int NOT NULL,                      -- _id
    [Description] nvarchar NOT NULL,        -- _description
    CONSTRAINT [pk_Category] PRIMARY KEY ([Id])
)
go

-- ProductsManager.Model.Product
CREATE TABLE [dbo].[Products] (
    [Price] decimal NOT NULL,               -- _price
    [Name] nvarchar NOT NULL,               -- _name
    [IsAvailable] bit NOT NULL,             -- _isAvailable
    [Id] int NOT NULL,                      -- _id
    [CategoryId] int NOT NULL,              -- _category
    CONSTRAINT [pk_Products] PRIMARY KEY ([Id])
)
go

