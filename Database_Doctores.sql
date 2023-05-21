use CiudadanosSanos

create table Doctores
(
	Id int primary key,
	Nombre nvarchar (255),
	Profesion nvarchar (255)
);

go

INSERT INTO Doctores (ID, Nombre, Profesion) VALUES (1, N'Juan', N'Cardiólogo');
INSERT INTO Doctores (ID, Nombre, Profesion) VALUES (2, N'María', N'Pediatra');
INSERT INTO Doctores (ID, Nombre, Profesion) VALUES (3, N'Pedro', N'Cirujano');
INSERT INTO Doctores (ID, Nombre, Profesion) VALUES (4, N'Ana', N'Dermatóloga');
