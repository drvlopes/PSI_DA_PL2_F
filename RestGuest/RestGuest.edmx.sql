
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2022 17:20:31
-- Generated from EDMX file: C:\Users\TbpT\Desktop\ipl\S2\DA\PSI_DA_PL2_F\RestGuest\RestGuest.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestGuest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RestauranteTrabalhador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_RestauranteTrabalhador];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_ClientePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_RestaurantePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_EstadoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PedidoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_MetodoPagamentoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_MetodoPagamentoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenus] DROP CONSTRAINT [FK_CategoriaItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_MoradaPessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_MoradaPessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_MoradaRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_MoradaRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[Pedidos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedidos];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[Pagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentos];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentos];
GO
IF OBJECT_ID(N'[dbo].[ItemMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenus];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[RestauranteItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteItemMenu];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuPedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuPedido];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [IdMorada] int  NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Pedidos'
CREATE TABLE [dbo].[Pedidos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdTrabalhador] int  NOT NULL,
    [IdCliente] int  NOT NULL,
    [IdRestaurante] int  NOT NULL,
    [IdEstado] int  NOT NULL,
    [ValorTotal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pagamentos'
CREATE TABLE [dbo].[Pagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdMetodoPagamento] int  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MetodoPagamentos'
CREATE TABLE [dbo].[MetodoPagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MetPagamento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'ItemMenus'
CREATE TABLE [dbo].[ItemMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCategoria] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [IdRestaurante] int  NOT NULL,
    [Salario] nvarchar(max)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [TotalGasto] nvarchar(max)  NOT NULL,
    [NumContribuinte] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurantes_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenus_Id] int  NOT NULL,
    [Pedidos_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [PK_Pedidos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [PK_Pagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentos'
ALTER TABLE [dbo].[MetodoPagamentos]
ADD CONSTRAINT [PK_MetodoPagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [PK_ItemMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Restaurantes_Id], [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurantes_Id], [ItemMenus_Id] ASC);
GO

-- Creating primary key on [ItemMenus_Id], [Pedidos_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenus_Id], [Pedidos_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdRestaurante] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([IdRestaurante])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoas_Trabalhador]
    ([IdRestaurante]);
GO

-- Creating foreign key on [IdTrabalhador] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([IdTrabalhador])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedidos]
    ([IdTrabalhador]);
GO

-- Creating foreign key on [IdCliente] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[Pedidos]
    ([IdCliente]);
GO

-- Creating foreign key on [IdRestaurante] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([IdRestaurante])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[Pedidos]
    ([IdRestaurante]);
GO

-- Creating foreign key on [IdEstado] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_EstadoPedido]
    FOREIGN KEY ([IdEstado])
    REFERENCES [dbo].[Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPedido'
CREATE INDEX [IX_FK_EstadoPedido]
ON [dbo].[Pedidos]
    ([IdEstado]);
GO

-- Creating foreign key on [IdPedido] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamentos]
    ([IdPedido]);
GO

-- Creating foreign key on [IdMetodoPagamento] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_MetodoPagamentoPagamento]
    FOREIGN KEY ([IdMetodoPagamento])
    REFERENCES [dbo].[MetodoPagamentos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentoPagamento'
CREATE INDEX [IX_FK_MetodoPagamentoPagamento]
ON [dbo].[Pagamentos]
    ([IdMetodoPagamento]);
GO

-- Creating foreign key on [IdCategoria] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItemMenus]
    ([IdCategoria]);
GO

-- Creating foreign key on [Restaurantes_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [ItemMenus_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pedidos_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([Pedidos_Id])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([Pedidos_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_MoradaPessoa]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaPessoa'
CREATE INDEX [IX_FK_MoradaPessoa]
ON [dbo].[Pessoas]
    ([Morada_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_MoradaRestaurante]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaRestaurante'
CREATE INDEX [IX_FK_MoradaRestaurante]
ON [dbo].[Restaurantes]
    ([Morada_Id]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------