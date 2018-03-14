
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2018 18:41:45
-- Generated from EDMX file: c:\users\adria\onedrive\documentos\visual studio 2015\Projects\Polizas\AccesoDatos\PolizasModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PolizasDev];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientePoliza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PolizaSet] DROP CONSTRAINT [FK_ClientePoliza];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosSet] DROP CONSTRAINT [FK_UsuariosRoles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[PolizaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PolizaSet];
GO
IF OBJECT_ID(N'[dbo].[RolesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolesSet];
GO
IF OBJECT_ID(N'[dbo].[UsuariosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuariosSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PolizaSet'
CREATE TABLE [dbo].[PolizaSet] (
    [NumPoliza] int IDENTITY(1,1) NOT NULL,
    [estado] nvarchar(max)  NOT NULL,
    [fechaVigencia] datetime  NOT NULL,
    [cobertura] int  NOT NULL,
    [observaciones] nvarchar(max)  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'UsuariosSet'
CREATE TABLE [dbo].[UsuariosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Contrasena] nvarchar(max)  NOT NULL,
    [Rol_Id] int  NOT NULL
);
GO

-- Creating table 'RolesSet'
CREATE TABLE [dbo].[RolesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cedula] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NumPoliza] in table 'PolizaSet'
ALTER TABLE [dbo].[PolizaSet]
ADD CONSTRAINT [PK_PolizaSet]
    PRIMARY KEY CLUSTERED ([NumPoliza] ASC);
GO

-- Creating primary key on [Id] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [PK_UsuariosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RolesSet'
ALTER TABLE [dbo].[RolesSet]
ADD CONSTRAINT [PK_RolesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Rol_Id] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [FK_UsuariosRoles]
    FOREIGN KEY ([Rol_Id])
    REFERENCES [dbo].[RolesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosRoles'
CREATE INDEX [IX_FK_UsuariosRoles]
ON [dbo].[UsuariosSet]
    ([Rol_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'PolizaSet'
ALTER TABLE [dbo].[PolizaSet]
ADD CONSTRAINT [FK_ClientePoliza]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePoliza'
CREATE INDEX [IX_FK_ClientePoliza]
ON [dbo].[PolizaSet]
    ([Cliente_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------