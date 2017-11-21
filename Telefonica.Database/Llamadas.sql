CREATE TABLE [dbo].[Llamadas](
	[LlamadaId] [uniqueidentifier] NOT NULL,
	[UsuarioId] [uniqueidentifier] NOT NULL,
	[TelefonoId] [uniqueidentifier] NOT NULL,
	[InicioLlamada] [datetime] NOT NULL,
	[FinLlamada] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Llamadas] PRIMARY KEY CLUSTERED 
(
	[LlamadaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

ALTER TABLE [dbo].[Llamadas] ADD  DEFAULT (newsequentialid()) FOR [LlamadaId]
GO

ALTER TABLE [dbo].[Llamadas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Llamadas_dbo.Telefono_TelefonoId] FOREIGN KEY([TelefonoId])
REFERENCES [dbo].[Telefonos] ([TelefonoId])
GO

ALTER TABLE [dbo].[Llamadas] CHECK CONSTRAINT [FK_dbo.Llamadas_dbo.Telefono_TelefonoId]
GO

ALTER TABLE [dbo].[Llamadas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Llamadas_dbo.Usuario_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
GO

ALTER TABLE [dbo].[Llamadas] CHECK CONSTRAINT [FK_dbo.Llamadas_dbo.Usuario_UsuarioId]
GO