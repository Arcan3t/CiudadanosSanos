use CiudadanosSanos

create table Pacientes
(
	Id int primary key,
	Nombre nvarchar (255)
);

go

INSERT INTO Pacientes (ID, Nombre) VALUES (1, N'Juan');
INSERT INTO Pacientes (ID, Nombre) VALUES (2, N'María');
INSERT INTO Pacientes (ID, Nombre) VALUES (3, N'Pedro');
INSERT INTO Pacientes (ID, Nombre) VALUES (4, N'Ana');