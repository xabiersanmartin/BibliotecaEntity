CREATE DATABASE ProyectoBibliotecaXabier

USE [ProyectoBibliotecaXabier]

CREATE TABLE [dbo].[Libros](
	[Isbn] [int] NOT NULL,
	[Titulo] [nvarchar](100) NOT NULL,
	[Editorial] [nvarchar](100) NOT NULL,
	[Sipnosis] [nvarchar](300) NOT NULL,
	[Caratula] [nvarchar](100) NOT NULL,
	[Unidades] [int] NOT NULL,
	[NumPrestado] [int] NOT NULL,
	[Disponibilidad] [bit] NOT NULL
 CONSTRAINT [PK_TLibros] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Lectores](
	[NumeroCarnet] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Contrasena] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](100) NOT NULL,
	[Mail] [nvarchar](100) NOT NULL
 CONSTRAINT [PK_TLectores] PRIMARY KEY CLUSTERED 
(
	[NumeroCarnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] NOT NULL IDENTITY,
	[Descripcion] [nvarchar](100) NOT NULL
 CONSTRAINT [PK_TCategorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Autores](
	[IdAutor] [int] NOT NULL IDENTITY,
	[Descripcion] [nvarchar](100) NOT NULL
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Prestamos](
	[IdLibro] [int] NOT NULL,
	[IdLector] [int] NOT NULL,
	[FechaPrestado] [date] NOT NULL,
	[FechaDevolucion] [date] NOT NULL
 CONSTRAINT [PK_TPrestamos] PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC,
	[IdLector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[LibrosCategorias](
	[IdCategoria] [int] NOT NULL,
	[IdLibro] [int] NOT NULL
 CONSTRAINT [PK_TLibrosCategorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC,
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[LibrosAutores](
	[IdAutor] [int] NOT NULL,
	[IdLibro] [int] NOT NULL
 CONSTRAINT [PK_TLibrosAutores] PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC,
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[LibrosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_LibrosCategorias_Libros] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosCategorias] CHECK CONSTRAINT [FK_LibrosCategorias_Libros]
GO
ALTER TABLE [dbo].[LibrosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_LibrosCategorias_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosCategorias] CHECK CONSTRAINT [FK_LibrosCategorias_Categorias]
GO
ALTER TABLE [dbo].[LibrosAutores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosAutores_Autores] FOREIGN KEY([IdAutor])
REFERENCES [dbo].[Autores] ([IdAutor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosAutores] CHECK CONSTRAINT [FK_LibrosAutores_Autores]
GO
ALTER TABLE [dbo].[LibrosAutores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosAutores_Libros] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosAutores] CHECK CONSTRAINT [FK_LibrosAutores_Libros]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Libros] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Libros]
GO
ALTER TABLE [dbo].[Prestamos] WITH CHECK ADD CONSTRAINT [FK_Prestamos_Lectores] FOREIGN KEY ([IdLector])
REFERENCES [dbo].[Lectores] ([NumeroCarnet])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Lectores]
GO

INSERT [dbo].[Libros] ([Isbn], [Titulo], [Editorial], [Sipnosis], [Caratula] , [Unidades], [NumPrestado], [Disponibilidad]) VALUES (1, 'Burua galdu zuen jirafa','Elkar', 'Leontzio lehoi magoak lagundu nahiko dio, lepo luzearen amaieran buru berri bat ipiniz, baina ez da oso mago abila, eta hanka sartuko du, behin eta berriz.','jirafa.png', 3,0, 1)
INSERT [dbo].[Libros] ([Isbn], [Titulo], [Editorial], [Sipnosis], [Caratula] , [Unidades], [NumPrestado], [Disponibilidad]) VALUES (2, 'Geronimo Stilton','Planeta Libros', 'Un ratón de aventuras','geronimo.png', 8,0, 1)
INSERT [dbo].[Libros] ([Isbn], [Titulo], [Editorial], [Sipnosis], [Caratula] , [Unidades], [NumPrestado], [Disponibilidad]) VALUES (3, 'Star Wars Una nueva esperanza','Planeta Comic', 'Nos encontramos en un periodo de guerra civil. Las naves espaciales rebeldes, atacando desde una base oculta, han logrado su primera victoria contra el malvado Imperio Galáctico.','starWars.png', 6,1, 1)
INSERT [dbo].[Libros] ([Isbn], [Titulo], [Editorial], [Sipnosis], [Caratula] , [Unidades], [NumPrestado], [Disponibilidad]) VALUES (4, 'One Piece','Viz Media', 'El pirata luffy tratara de encontrar una banda pirata de 10 inetgrantes para surcar los mares','onePiece.png', 12,1, 1)

INSERT [dbo].[Categorias] ([Descripcion]) VALUES ('Aventura')
INSERT [dbo].[Categorias] ([Descripcion]) VALUES ('Acción')
INSERT [dbo].[Categorias] ([Descripcion]) VALUES ('Infantil')

INSERT [dbo].[Autores] ([Descripcion]) VALUES ('Eichiro Oda')
INSERT [dbo].[Autores] ([Descripcion]) VALUES ('Elisabetta Dami')
INSERT [dbo].[Autores] ([Descripcion]) VALUES ('George Lucas')
INSERT [dbo].[Autores] ([Descripcion]) VALUES ('Bertol Arrieta')

INSERT [dbo].[Lectores] ([NumeroCarnet],[Nombre],[Contrasena],[Telefono],[Mail]) VALUES (3098,'Xabier','xabi','601277543','xabottol@gmail.com')
INSERT [dbo].[Lectores] ([NumeroCarnet],[Nombre],[Contrasena],[Telefono],[Mail]) VALUES (2312, 'Celes','cele','654328765', 'celes@gmail.com')

INSERT [dbo].[LibrosAutores] ([IdAutor],[IdLibro]) VALUES (1,4)
INSERT [dbo].[LibrosAutores] ([IdAutor],[IdLibro]) VALUES (2,2)
INSERT [dbo].[LibrosAutores] ([IdAutor],[IdLibro]) VALUES (3,4)
INSERT [dbo].[LibrosAutores] ([IdAutor],[IdLibro]) VALUES (4,1)

INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (1,3)
INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (1,2)
INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (3,2)
INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (1,4)
INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (2,4)
INSERT [dbo].[LibrosCategorias] ([IdCategoria],[IdLibro]) VALUES (3,1)

INSERT [dbo].[Prestamos] ([FechaDevolucion],[FechaPrestado],[IdLector],[IdLibro]) VALUES ('2020-06-01','2020-05-13',3098,4)
INSERT [dbo].[Prestamos] ([FechaDevolucion],[FechaPrestado],[IdLector],[IdLibro]) VALUES ('2020-05-22','2020-04-21',2312,3)