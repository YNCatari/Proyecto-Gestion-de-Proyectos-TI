CREATE DATABASE dbveterinaria;
USE dbveterinaria;

/***CREACION DE TABLAS***/
CREATE TABLE VettbCliente(
  	 dni varchar(8) NOT NULL,
  	 nombre varchar(50) NOT NULL,
  	 apellido varchar(50) NOT NULL,
  	 telefono varchar(12) NOT NULL,
  	 email varchar(100) NOT NULL,
  	 direccion varchar(50) NOT NULL,
 	 PRIMARY KEY (dni)
);

CREATE TABLE VettbUsuario(
	codigo varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	apellido varchar(50) NOT NULL,
	direccion varchar(100) NOT NULL,
	email varchar(100),
	cargo varchar(50) NOT NULL,
	clave varchar(8) NOT NULL,
	estado varchar(8) NOT NULL,
	PRIMARY KEY (codigo)
); 

CREATE TABLE VettbMascota(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	especie varchar(50) NOT NULL,
	raza varchar(50) NOT NULL,
	peso varchar(12) NOT NULL,
	sexo varchar(6) NOT NULL,
	nacimiento date,
	estado varchar(8) NOT NULL,
 	CONSTRAINT `FK_Cliente_Mascota` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbServicio(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	vacuna varchar(50) NOT NULL,
	detalle varchar(100),
	fecha date,
	precio double,
 	CONSTRAINT `FK_Cliente_Servicio` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbVacunas(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	servicio varchar(50) NOT NULL,
	detalle varchar(100),
	fecha date,
	precio double,
 	CONSTRAINT `FK_Cliente_Mantenimiento` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbTratamiento(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	tratamiento varchar(50) NOT NULL,
	detalle varchar(100),
	receta varchar(100),
	fecha date,
	cita date,
	precio double,
 	CONSTRAINT `FK_Cliente_Tratamiento` FOREIGN KEY (dni) REFERENCES VettbCliente(dni)
);

CREATE TABLE VettbAgenda(
	codigo int(8) NOT NULL AUTO_INCREMENT,
  	dni varchar(8) NOT NULL,
  	nombre varchar(50) NOT NULL,
  	telefono varchar(12) NOT NULL,
  	direccion varchar(50),
	fecha date,
	hora varchar(8),
	actividad varchar(100),
	PRIMARY KEY (codigo),
 	CONSTRAINT `FK_Cliente_Agenda` FOREIGN KEY (dni) REFERENCES VettbCliente(dni)
);


