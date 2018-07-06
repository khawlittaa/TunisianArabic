IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20171121225635_Initial')
BEGIN
    CREATE TABLE [Word] (
        [ID] int NOT NULL IDENTITY,
        [ArabWord] nvarchar(max) NULL,
        [Description] nvarchar(200) NOT NULL,
        [EngWord] nvarchar(max) NOT NULL,
        [FbTypping] nvarchar(max) NULL,
        [Nature] nvarchar(max) NOT NULL,
        [PicURL] nvarchar(max) NULL,
        [Pronunciation] nvarchar(max) NULL,
        [Score] int NOT NULL,
        [TunWord] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Word] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20171121225635_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20171121225635_Initial', N'2.0.0-rtm-26452');
END;

GO

