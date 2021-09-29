IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161720_V1')
BEGIN
    CREATE TABLE [Nhanvien] (
        [ID] int NOT NULL IDENTITY,
        [Ten] char(20) NULL,
        [Manv] char(8) NULL,
        [Diachi] char(30) NULL,
        [Gioitinh] char(10) NULL,
        [Ngaysinh] Date NOT NULL,
        [Phong] char(15) NULL,
        CONSTRAINT [PK_Nhanvien] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161720_V1')
BEGIN
    CREATE TABLE [Passwords] (
        [ID] int NOT NULL IDENTITY,
        [User] nvarchar(max) NULL,
        [Pass] nvarchar(max) NULL,
        [Manv] nvarchar(max) NULL,
        CONSTRAINT [PK_Passwords] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161720_V1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210818161720_V1', N'5.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161928_V2')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Diachi', N'Gioitinh', N'Manv', N'Ngaysinh', N'Phong', N'Ten') AND [object_id] = OBJECT_ID(N'[Nhanvien]'))
        SET IDENTITY_INSERT [Nhanvien] ON;
    EXEC(N'INSERT INTO [Nhanvien] ([ID], [Diachi], [Gioitinh], [Manv], [Ngaysinh], [Phong], [Ten])
    VALUES (1, ''Bac Ninh'', ''Nam'', ''CT010304'', ''1998-10-24T00:00:00.0000000'', ''PM'', ''Hoang Tien Binh''),
    (2, ''Thai Binh'', ''Nam'', ''CT010305'', ''1998-01-24T00:00:00.0000000'', ''PM'', ''Hoang Thanh Binh''),
    (3, ''Bac Ninh'', ''Nu'', ''CT010306'', ''1998-11-14T00:00:00.0000000'', ''App'', ''Hoang Thi Binh''),
    (4, ''Ha Noi'', ''Nu'', ''CT010307'', ''1998-10-24T00:00:00.0000000'', ''Mobile'', ''Nguyen Thi A'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Diachi', N'Gioitinh', N'Manv', N'Ngaysinh', N'Phong', N'Ten') AND [object_id] = OBJECT_ID(N'[Nhanvien]'))
        SET IDENTITY_INSERT [Nhanvien] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161928_V2')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Manv', N'Pass', N'User') AND [object_id] = OBJECT_ID(N'[Passwords]'))
        SET IDENTITY_INSERT [Passwords] ON;
    EXEC(N'INSERT INTO [Passwords] ([ID], [Manv], [Pass], [User])
    VALUES (1, N''CT010304'', N''1234'', N''binhht2''),
    (2, N''CT010305'', N''1234'', N''binhht1''),
    (3, N''CT010306'', N''admin'', N''admin'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Manv', N'Pass', N'User') AND [object_id] = OBJECT_ID(N'[Passwords]'))
        SET IDENTITY_INSERT [Passwords] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210818161928_V2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210818161928_V2', N'5.0.9');
END;
GO

COMMIT;
GO

