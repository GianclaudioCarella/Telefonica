CREATE TABLE [dbo].[Telefonos](
	[TelefonoId] [uniqueidentifier] NOT NULL,
	[Numero] [int] NOT NULL,
	[Area] [int] NOT NULL,
	[CodPais] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Telefono] PRIMARY KEY CLUSTERED 
(
	[TelefonoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO