CREATE DATABASE GymTheBeach
GO

USE GymTheBeach
GO

CREATE TABLE Actividades (
	ActividadID INT IDENTITY(1, 1),
	Meses INT NOT NULL,
	Costo INT NOT NULL,
	Descripcion NVARCHAR(30) NOT NULL,
	Habilitado BIT NOT NULL,
	CONSTRAINT PK_Actividades PRIMARY KEY (ActividadID)
	)
GO

SET IDENTITY_INSERT Actividades ON
GO

INSERT INTO Actividades (
	ActividadID,
	Meses,
	Costo,
	Descripcion,
	Habilitado
	)
SELECT 1,
	0,
	0,
	'VIP',
	1
GO

INSERT INTO Actividades (
	ActividadID,
	Meses,
	Costo,
	Descripcion,
	Habilitado
	)
SELECT 2,
	1,
	3500,
	'Mensual',
	1
GO

INSERT INTO Actividades (
	ActividadID,
	Meses,
	Costo,
	Descripcion,
	Habilitado
	)
SELECT 3,
	3,
	9450,
	'Trimestral (-10%)',
	1
GO

INSERT INTO Actividades (
	ActividadID,
	Meses,
	Costo,
	Descripcion,
	Habilitado
	)
SELECT 4,
	6,
	16800,
	'Semestral (-20%)',
	1
GO

INSERT INTO Actividades (
	ActividadID,
	Meses,
	Costo,
	Descripcion,
	Habilitado
	)
SELECT 5,
	12,
	29400,
	'Anual (-30%)',
	1
GO

SET IDENTITY_INSERT Actividades OFF
GO

CREATE TABLE Generos (
	GeneroID INT IDENTITY(1, 1),
	Descripcion NVARCHAR(20),
	CONSTRAINT PK_Generos PRIMARY KEY (GeneroID)
	)

SET IDENTITY_INSERT Generos ON
GO

INSERT INTO Generos (
	GeneroID,
	Descripcion
	)
SELECT 1,
	'Masculino'
GO

INSERT INTO Generos (
	GeneroID,
	Descripcion
	)
SELECT 2,
	'Femenino'
GO

INSERT INTO Generos (
	GeneroID,
	Descripcion
	)
SELECT 3,
	'Sin especificar'
GO

SET IDENTITY_INSERT Generos OFF
GO

CREATE TABLE Usuarios (
	UserID INT IDENTITY(1, 1),
	Nombre NVARCHAR(64) NOT NULL,
	Apellido NVARCHAR(64) NOT NULL,
	DNI NVARCHAR(15) NOT NULL,
	GeneroID INT NOT NULL DEFAULT(3), -- Sin especificar por defecto
	Habilitado BIT NOT NULL,
	EsAdmin BIT NULL,
	Username NVARCHAR(64) NULL,
	[Hash] NVARCHAR(64) NULL,
	Salt NVARCHAR(64) NULL,
	FechaNacimiento DATE NULL,
	Telefono NVARCHAR(25) NULL,
	Domicilio NVARCHAR(64) NULL,
	Profesion NVARCHAR(64) NULL,
	Email NVARCHAR(64) NULL,
	ComoNosConocio NVARCHAR(100) NULL,
	Observaciones NVARCHAR(200) NULL,
	Saldo INT DEFAULT(0),
	CreatorUserID INT NULL,
	CONSTRAINT PK_Usuarios PRIMARY KEY (UserID),
	CONSTRAINT FK_Usuarios_Generos FOREIGN KEY (GeneroID) REFERENCES Generos(GeneroID)
	)
GO

CREATE TABLE ActividadesXUsuario (
	UserID INT,
	ActividadID INT DEFAULT(2), -- Mensual por defecto
	CONSTRAINT PK_ActividadesXUsuario PRIMARY KEY (
		UserID,
		ActividadID
		),
	CONSTRAINT FK_ActividadesXUsuario_Usuarios FOREIGN KEY (UserID) REFERENCES Usuarios(UserID),
	CONSTRAINT FK_ActividadesXUsuario_Actividades FOREIGN KEY (ActividadID) REFERENCES Actividades(ActividadID)
	)
GO

CREATE TABLE Pagos (
	PagoID INT IDENTITY(1, 1),
	UserID INT NOT NULL,
	Descripcion NVARCHAR(30) NOT NULL,
	Monto INT NOT NULL,
	Fecha DATETIME NOT NULL,
	CONSTRAINT PK_Pagos PRIMARY KEY (PagoID),
	CONSTRAINT FK_Pagos_Usuarios FOREIGN KEY (UserID) REFERENCES Usuarios(UserID)
	)
GO

CREATE TABLE Asistencia (
	AsistenciaID INT IDENTITY(1, 1),
	UserID INT NOT NULL,
	Fecha DATETIME NOT NULL DEFAULT(GETDATE()),
	CONSTRAINT PK_Asistencia PRIMARY KEY (AsistenciaID),
	CONSTRAINT FK_Asistencia_Usuarios FOREIGN KEY (UserID) REFERENCES Usuarios(UserID)
	)
GO

CREATE TABLE Logs (
	LogID INT IDENTITY(1, 1),
	Fecha DATETIME NOT NULL DEFAULT(GETDATE()),
	Descripcion NVARCHAR(1000),
	CONSTRAINT PK_Logs PRIMARY KEY (LogID)
)
GO
