CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [uniqueidentifier] NOT NULL DEFAULT (newsequentialid()),
	[TelefonoId] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_dbo.Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO