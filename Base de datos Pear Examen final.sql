create database Pear
use Pear


CREATE TABLE Color (
    Id_color INT,
	color varchar (20),
	Constraint PK_Color Primary key clustered(id_color)
);

CREATE TABLE Pais (
    Id_pais INT,
	pais varchar (20)
	Constraint PK_Pais Primary key clustered(id_pais)
);

CREATE TABLE Gama (
    Id_gama INT,
	gama varchar (20)
	Constraint PK_Gama Primary key clustered(id_gama)
);

CREATE TABLE Telefono(
	Id_Telefono  Int not null Identity (1,1),
	gama int,
	color int,
	pais int,
	Constraint PK_Telefono Primary key clustered(id_telefono),
	Constraint Fk_gama Foreign key(gama) references gama(id_gama),
	Constraint Fk_color Foreign key(color) references color(id_color),
	Constraint Fk_pais Foreign key(pais) references pais(id_pais),
);

CREATE TABLE Registro(
	Id_registro  Int not null Identity (1,1),
	FechaHora Date,
	telefono int,
	total money,
	Constraint PK_Registro Primary key clustered(id_registro),
	Constraint Fk_Telefono Foreign key(telefono) references Telefono(id_telefono),
);

	