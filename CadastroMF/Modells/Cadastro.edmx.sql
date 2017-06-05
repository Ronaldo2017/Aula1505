
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2017 11:29:19
-- Generated from EDMX file: E:\EXER ASP.NET\ProjetosAspNet\CadastroMF\Modells\Cadastro.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CadastroMF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MaquinaProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [FK_MaquinaProduto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Maquinas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Maquinas];
GO
IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Maquinas'
CREATE TABLE [dbo].[Maquinas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Código] nvarchar(max)  NOT NULL,
    [Descrição] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Código] nvarchar(max)  NOT NULL,
    [Descrição] nvarchar(max)  NOT NULL,
    [MaquinaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Maquinas'
ALTER TABLE [dbo].[Maquinas]
ADD CONSTRAINT [PK_Maquinas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaquinaId] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_MaquinaProduto]
    FOREIGN KEY ([MaquinaId])
    REFERENCES [dbo].[Maquinas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaquinaProduto'
CREATE INDEX [IX_FK_MaquinaProduto]
ON [dbo].[Produtos]
    ([MaquinaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------