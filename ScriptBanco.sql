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
CREATE TABLE [TB_AUTOR] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TB_AUTOR] PRIMARY KEY ([Id])
);

CREATE TABLE [TB_LIVRO] (
    [Id] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NOT NULL,
    [QuantidadePaginas] int NOT NULL,
    [Valor] float NOT NULL,
    [idAutor] int NOT NULL,
    CONSTRAINT [PK_TB_LIVRO] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_LIVRO_TB_AUTOR_idAutor] FOREIGN KEY ([idAutor]) REFERENCES [TB_AUTOR] ([Id]) ON DELETE CASCADE
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_AUTOR]'))
    SET IDENTITY_INSERT [TB_AUTOR] ON;
INSERT INTO [TB_AUTOR] ([Id], [Nome])
VALUES (1, N'J.K. Rowling'),
(2, N'George Orwell'),
(3, N'Jane Austen'),
(4, N'Mark Twain'),
(5, N'F. Scott Fitzgerald'),
(6, N'Harper Lee'),
(7, N'Hemingway'),
(8, N'J.R.R. Tolkien'),
(9, N'Gabriel García Márquez'),
(10, N'Oscar Wilde');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_AUTOR]'))
    SET IDENTITY_INSERT [TB_AUTOR] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'QuantidadePaginas', N'Titulo', N'Valor', N'idAutor') AND [object_id] = OBJECT_ID(N'[TB_LIVRO]'))
    SET IDENTITY_INSERT [TB_LIVRO] ON;
INSERT INTO [TB_LIVRO] ([Id], [QuantidadePaginas], [Titulo], [Valor], [idAutor])
VALUES (1, 223, N'Harry Potter e a Pedra Filosofal', 49.899999999999999E0, 1),
(2, 328, N'1984', 39.899999999999999E0, 2),
(3, 368, N'Orgulho e Preconceito', 29.899999999999999E0, 3),
(4, 366, N'As Aventuras de Huckleberry Finn', 32.899999999999999E0, 4),
(5, 180, N'O Grande Gatsby', 25.899999999999999E0, 5),
(6, 320, N'O Sol é Para Todos', 36.899999999999999E0, 6),
(7, 128, N'O Velho e o Mar', 19.899999999999999E0, 7),
(8, 310, N'O Hobbit', 44.899999999999999E0, 8),
(9, 448, N'Cem Anos de Solidão', 59.899999999999999E0, 9),
(10, 224, N'O Retrato de Dorian Gray', 39.899999999999999E0, 10);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'QuantidadePaginas', N'Titulo', N'Valor', N'idAutor') AND [object_id] = OBJECT_ID(N'[TB_LIVRO]'))
    SET IDENTITY_INSERT [TB_LIVRO] OFF;

CREATE INDEX [IX_TB_LIVRO_idAutor] ON [TB_LIVRO] ([idAutor]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241213030020_InitialCreate', N'9.0.0');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241213030101_Esquemafeito', N'9.0.0');

COMMIT;
GO

