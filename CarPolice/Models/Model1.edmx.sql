
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/04/2023 22:32:55
-- Generated from EDMX file: C:\Users\Alexey\Dropbox\ПК\Desktop\Car-master\CarPolice\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TRPK];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_results_column_2_Car_id_foreign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[results] DROP CONSTRAINT [FK_results_column_2_Car_id_foreign];
GO
IF OBJECT_ID(N'[dbo].[FK_results_id_car_CarOwner_id_foreign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[results] DROP CONSTRAINT [FK_results_id_car_CarOwner_id_foreign];
GO
IF OBJECT_ID(N'[dbo].[FK_results_id_employee_CompanyEmployee_id_foreign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[results] DROP CONSTRAINT [FK_results_id_employee_CompanyEmployee_id_foreign];
GO
IF OBJECT_ID(N'[dbo].[FK_results_id_inspection_TechnicalInspection_id_foreign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[results] DROP CONSTRAINT [FK_results_id_inspection_TechnicalInspection_id_foreign];
GO
IF OBJECT_ID(N'[dbo].[FK_results_id_officer_Officer_id_foreign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[results] DROP CONSTRAINT [FK_results_id_officer_Officer_id_foreign];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Car];
GO
IF OBJECT_ID(N'[dbo].[CarOwner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarOwner];
GO
IF OBJECT_ID(N'[dbo].[CompanyEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyEmployee];
GO
IF OBJECT_ID(N'[dbo].[Officer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Officer];
GO
IF OBJECT_ID(N'[dbo].[results]', 'U') IS NOT NULL
    DROP TABLE [dbo].[results];
GO
IF OBJECT_ID(N'[dbo].[TechnicalInspection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TechnicalInspection];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Car'
CREATE TABLE [dbo].[Car] (
    [id] int  NOT NULL,
    [body_no] varchar(11)  NOT NULL,
    [license_plate] varchar(9)  NOT NULL,
    [mark] varchar(255)  NOT NULL,
    [color] varchar(50)  NOT NULL,
    [engine_no] varchar(11)  NOT NULL,
    [pass_no] int  NOT NULL
);
GO

-- Creating table 'CarOwner'
CREATE TABLE [dbo].[CarOwner] (
    [id] int  NOT NULL,
    [full_name] varchar(255)  NOT NULL,
    [address] varchar(255)  NOT NULL,
    [gender] varchar(1)  NOT NULL,
    [driver_license_no] int  NOT NULL,
    [DOB] datetime  NOT NULL
);
GO

-- Creating table 'CompanyEmployee'
CREATE TABLE [dbo].[CompanyEmployee] (
    [id] int  NOT NULL,
    [login] varchar(20)  NOT NULL,
    [password] varchar(20)  NOT NULL,
    [full_name] varchar(255)  NOT NULL,
    [pass_no] int  NOT NULL
);
GO

-- Creating table 'Officer'
CREATE TABLE [dbo].[Officer] (
    [id] int  NOT NULL,
    [login] varchar(20)  NOT NULL,
    [password] varchar(20)  NOT NULL,
    [full_name] varchar(255)  NOT NULL,
    [rank] varchar(20)  NOT NULL,
    [position] varchar(20)  NOT NULL
);
GO

-- Creating table 'results'
CREATE TABLE [dbo].[results] (
    [id] int  NOT NULL,
    [id_car] int  NOT NULL,
    [id_officer] int  NULL,
    [id_employee] int  NOT NULL,
    [id_owner] int  NOT NULL,
    [id_inspection] int  NOT NULL
);
GO

-- Creating table 'TechnicalInspection'
CREATE TABLE [dbo].[TechnicalInspection] (
    [id] int  NOT NULL,
    [conclusion] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [PK_Car]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CarOwner'
ALTER TABLE [dbo].[CarOwner]
ADD CONSTRAINT [PK_CarOwner]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CompanyEmployee'
ALTER TABLE [dbo].[CompanyEmployee]
ADD CONSTRAINT [PK_CompanyEmployee]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Officer'
ALTER TABLE [dbo].[Officer]
ADD CONSTRAINT [PK_Officer]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [PK_results]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TechnicalInspection'
ALTER TABLE [dbo].[TechnicalInspection]
ADD CONSTRAINT [PK_TechnicalInspection]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_car] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [FK_results_column_2_Car_id_foreign]
    FOREIGN KEY ([id_car])
    REFERENCES [dbo].[Car]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_results_column_2_Car_id_foreign'
CREATE INDEX [IX_FK_results_column_2_Car_id_foreign]
ON [dbo].[results]
    ([id_car]);
GO

-- Creating foreign key on [id_owner] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [FK_results_id_car_CarOwner_id_foreign]
    FOREIGN KEY ([id_owner])
    REFERENCES [dbo].[CarOwner]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_results_id_car_CarOwner_id_foreign'
CREATE INDEX [IX_FK_results_id_car_CarOwner_id_foreign]
ON [dbo].[results]
    ([id_owner]);
GO

-- Creating foreign key on [id_employee] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [FK_results_id_employee_CompanyEmployee_id_foreign]
    FOREIGN KEY ([id_employee])
    REFERENCES [dbo].[CompanyEmployee]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_results_id_employee_CompanyEmployee_id_foreign'
CREATE INDEX [IX_FK_results_id_employee_CompanyEmployee_id_foreign]
ON [dbo].[results]
    ([id_employee]);
GO

-- Creating foreign key on [id_officer] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [FK_results_id_officer_Officer_id_foreign]
    FOREIGN KEY ([id_officer])
    REFERENCES [dbo].[Officer]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_results_id_officer_Officer_id_foreign'
CREATE INDEX [IX_FK_results_id_officer_Officer_id_foreign]
ON [dbo].[results]
    ([id_officer]);
GO

-- Creating foreign key on [id_inspection] in table 'results'
ALTER TABLE [dbo].[results]
ADD CONSTRAINT [FK_results_id_inspection_TechnicalInspection_id_foreign]
    FOREIGN KEY ([id_inspection])
    REFERENCES [dbo].[TechnicalInspection]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_results_id_inspection_TechnicalInspection_id_foreign'
CREATE INDEX [IX_FK_results_id_inspection_TechnicalInspection_id_foreign]
ON [dbo].[results]
    ([id_inspection]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------