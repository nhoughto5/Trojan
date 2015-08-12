
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/12/2015 15:16:05
-- Generated from EDMX file: C:\Users\Nicholas\Documents\Visual Studio 2013\Projects\Trojan\Trojan\Database\TrojanDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TrojanDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserVirus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Virus] DROP CONSTRAINT [FK_UserVirus];
GO
IF OBJECT_ID(N'[dbo].[FK_VirusMatrix]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Virus] DROP CONSTRAINT [FK_VirusMatrix];
GO
IF OBJECT_ID(N'[dbo].[FK_MatrixToCell]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matrix_Cell] DROP CONSTRAINT [FK_MatrixToCell];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryAttribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_CategoryAttribute];
GO
IF OBJECT_ID(N'[dbo].[FK_VirusDescriptionItemsAttribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VirusDescriptionItems] DROP CONSTRAINT [FK_VirusDescriptionItemsAttribute];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Virus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Virus];
GO
IF OBJECT_ID(N'[dbo].[Matrices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matrices];
GO
IF OBJECT_ID(N'[dbo].[Matrix_Cell]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matrix_Cell];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Attributes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attributes];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[OrderDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetails];
GO
IF OBJECT_ID(N'[dbo].[VirusDescriptionItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VirusDescriptionItems];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [User_Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [EmailConfirmed] bit  NOT NULL
);
GO

-- Creating table 'Virus'
CREATE TABLE [dbo].[Virus] (
    [Virus_Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [UserUser_Id] int  NOT NULL,
    [Matrix_Matrix_Id] int  NOT NULL
);
GO

-- Creating table 'Matrices'
CREATE TABLE [dbo].[Matrices] (
    [Matrix_Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Matrix_Cell'
CREATE TABLE [dbo].[Matrix_Cell] (
    [Cell_Id] int IDENTITY(1,1) NOT NULL,
    [RowId] int  NOT NULL,
    [ColumnId] int  NOT NULL,
    [value] bit  NULL,
    [submatrix] nvarchar(max)  NOT NULL,
    [MatrixMatrix_Id] int  NOT NULL,
    [MatrixName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Attribute_AttributeId] int  NOT NULL
);
GO

-- Creating table 'Attributes'
CREATE TABLE [dbo].[Attributes] (
    [AttributeId] int IDENTITY(1,1) NOT NULL,
    [AttributeName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ImagePath] nvarchar(max)  NOT NULL,
    [F_in] int  NOT NULL,
    [F_out] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [OrderDetailId] int IDENTITY(1,1) NOT NULL,
    [OrderId] int  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [VirusId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VirusDescriptionItems'
CREATE TABLE [dbo].[VirusDescriptionItems] (
    [ItemId] nvarchar(250)  NOT NULL,
    [VirusId] nvarchar(max)  NOT NULL,
    [On_Off] bit  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [AttributeId] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [Attribute1_AttributeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [User_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([User_Id] ASC);
GO

-- Creating primary key on [Virus_Id] in table 'Virus'
ALTER TABLE [dbo].[Virus]
ADD CONSTRAINT [PK_Virus]
    PRIMARY KEY CLUSTERED ([Virus_Id] ASC);
GO

-- Creating primary key on [Matrix_Id] in table 'Matrices'
ALTER TABLE [dbo].[Matrices]
ADD CONSTRAINT [PK_Matrices]
    PRIMARY KEY CLUSTERED ([Matrix_Id] ASC);
GO

-- Creating primary key on [Cell_Id] in table 'Matrix_Cell'
ALTER TABLE [dbo].[Matrix_Cell]
ADD CONSTRAINT [PK_Matrix_Cell]
    PRIMARY KEY CLUSTERED ([Cell_Id] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [AttributeId] in table 'Attributes'
ALTER TABLE [dbo].[Attributes]
ADD CONSTRAINT [PK_Attributes]
    PRIMARY KEY CLUSTERED ([AttributeId] ASC);
GO

-- Creating primary key on [OrderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [OrderDetailId] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([OrderDetailId] ASC);
GO

-- Creating primary key on [ItemId] in table 'VirusDescriptionItems'
ALTER TABLE [dbo].[VirusDescriptionItems]
ADD CONSTRAINT [PK_VirusDescriptionItems]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserUser_Id] in table 'Virus'
ALTER TABLE [dbo].[Virus]
ADD CONSTRAINT [FK_UserVirus]
    FOREIGN KEY ([UserUser_Id])
    REFERENCES [dbo].[Users]
        ([User_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserVirus'
CREATE INDEX [IX_FK_UserVirus]
ON [dbo].[Virus]
    ([UserUser_Id]);
GO

-- Creating foreign key on [Matrix_Matrix_Id] in table 'Virus'
ALTER TABLE [dbo].[Virus]
ADD CONSTRAINT [FK_VirusMatrix]
    FOREIGN KEY ([Matrix_Matrix_Id])
    REFERENCES [dbo].[Matrices]
        ([Matrix_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VirusMatrix'
CREATE INDEX [IX_FK_VirusMatrix]
ON [dbo].[Virus]
    ([Matrix_Matrix_Id]);
GO

-- Creating foreign key on [MatrixMatrix_Id] in table 'Matrix_Cell'
ALTER TABLE [dbo].[Matrix_Cell]
ADD CONSTRAINT [FK_MatrixToCell]
    FOREIGN KEY ([MatrixMatrix_Id])
    REFERENCES [dbo].[Matrices]
        ([Matrix_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatrixToCell'
CREATE INDEX [IX_FK_MatrixToCell]
ON [dbo].[Matrix_Cell]
    ([MatrixMatrix_Id]);
GO

-- Creating foreign key on [Attribute_AttributeId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_CategoryAttribute]
    FOREIGN KEY ([Attribute_AttributeId])
    REFERENCES [dbo].[Attributes]
        ([AttributeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryAttribute'
CREATE INDEX [IX_FK_CategoryAttribute]
ON [dbo].[Categories]
    ([Attribute_AttributeId]);
GO

-- Creating foreign key on [Attribute1_AttributeId] in table 'VirusDescriptionItems'
ALTER TABLE [dbo].[VirusDescriptionItems]
ADD CONSTRAINT [FK_VirusDescriptionItemsAttribute]
    FOREIGN KEY ([Attribute1_AttributeId])
    REFERENCES [dbo].[Attributes]
        ([AttributeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VirusDescriptionItemsAttribute'
CREATE INDEX [IX_FK_VirusDescriptionItemsAttribute]
ON [dbo].[VirusDescriptionItems]
    ([Attribute1_AttributeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------