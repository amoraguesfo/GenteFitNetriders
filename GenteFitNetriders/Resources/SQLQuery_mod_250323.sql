USE [Netriders]
GO
CREATE TABLE [dbo].[Clases](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_clase] [varchar](40) NOT NULL,
	[nrofesor] [varchar](40) NULL,
	[plazas] [int] NOT NULL,
	[fecha_clase] [date] NOT NULL,
	[hora_clase] [time](7) NOT NULL,
	[duracion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_clase] [int] NOT NULL,
	[estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO   
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[sexo] [varchar](10) NOT NULL,
	[edad] [tinyint] NOT NULL,
	[num_telefono] [varchar](15) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[tipo] [varchar](10) NOT NULL,
 CONSTRAINT [PK__Usuarios__3213E83FFD0C373F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Restricciones de integridad para actualizacion y borrado de Clases ******/
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Clases] FOREIGN KEY([id_clase])
REFERENCES [dbo].[Clases] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Clases]
GO
/****** Restricciones de integridad para actualizacion y borrado de Usuario  ******/
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuarios]
GO
/******  Agrego una restricci?n para evitar valores negativos en la columna Duracion ******/
ALTER TABLE [dbo].[Clases]  WITH CHECK ADD  CONSTRAINT [CHK_duracion] CHECK  (([duracion]>(0)))
GO
/******  Agrego una restricci?n para evitar valores negativos en la columna Plazas ******/
ALTER TABLE [dbo].[Clases]  WITH CHECK ADD  CONSTRAINT [CHK_plazas] CHECK  (([plazas]>(0)))
GO
/****** Agrego una restricci?n CHECK para la columna Estado  ******/
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [CHK_estado] CHECK  (([estado]='ausente' OR [estado]='asistida' OR [estado]='cancelada' OR [estado]='reservada'))
GO
/****** Agrego una restricci?n CHECK para la columna Tipo  ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHK_tipo] CHECK  (([tipo]='cliente' OR [tipo]='admin'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHK_tipo]
