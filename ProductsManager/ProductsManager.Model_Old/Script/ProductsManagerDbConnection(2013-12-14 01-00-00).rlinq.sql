-- ProductsManager.Model.Category
CREATE TABLE [dbo].[Category] (
    [Description] nvarchar NOT NULL,        -- _description
    [Id] int NOT NULL,                      -- _id
    [Name] nvarchar NOT NULL,               -- _name
    CONSTRAINT [pk_Category] PRIMARY KEY ([Id])
)

go

-- ProductsManager.Model.Product
CREATE TABLE [dbo].[Products] (
    [CategoryId] int NOT NULL,              -- _category
    [Id] int NOT NULL,                      -- _id
    [IsAvailable] bit NOT NULL,             -- _isAvailable
    [Name] nvarchar NOT NULL,               -- _name
    [Price] decimal NOT NULL,               -- _price
    CONSTRAINT [pk_Products] PRIMARY KEY ([Id])
)

go

