/***INSERTAR DATOS****/

INSERT INTO `VettbUsuario` (`codigo`, `nombre`, `apellido`, `direccion`, `email`, `cargo`, `clave`, `estado`) VALUES
('72567658', 'Yober Nain', 'Catari Cabrera', 'Tacna', 'yobernain@gmail.com', 'Administrador', '123456', 'TRUE');

/***PROCEDIMIENTOS ALMACENADOS***/

/***VALIDAR LOGIN***/
DELIMITER //
CREATE PROCEDURE `VetUSP_S_ValidarLogin`(
	pcodemp varchar(8),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
	select * from VettbUsuario
where
	codigo = pcodemp and clave = pclaemp and estado = pestemp;
COMMIT;
END//
DELIMITER ;


/***ELIMINAR CARGO (Solo referencial)***/
DELIMITER //
CREATE  PROCEDURE `VetUSP_D_EliminarCliente`(
	pdnicli varchar(8)
)
BEGIN
	delete from VettbCliente 
where 
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;
	

/***AGREGAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarCliente`(
	pdnicli varchar(8),
	pnomcli varchar(50),
	papecli varchar(50),
	ptelcli varchar(12),
	pemacli varchar(100),
	pdircli varchar(50)

)
BEGIN
insert into VettbCliente(dni, nombre, apellido, telefono, email, direccion) 
values(pdnicli, pnomcli, papecli, ptelcli, pemacli, pdircli);
COMMIT;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarEmpleado`(
	pcodemp varchar(8),
	pnomemp varchar(50),
	papeemp varchar(50),
	pdiremp varchar(100),
	pemaemp varchar(100),
	pcaremp varchar(50),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
insert into VettbUsuario(codigo, nombre, apellido, direccion, email, cargo, clave, estado) 
values(pcodemp, pnomemp, papeemp, pdiremp, pemaemp, pcaremp, pclaemp, pestemp);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarMascota`(
	pdnimas varchar(8),
	pnommas varchar(50),
	pespmas varchar(50),
	prazmas varchar(50),
	ppesmas varchar(12),
	psexmas varchar(6),
	pnacmas date,
	pestmas varchar(8)
)
BEGIN
insert into VettbMascota(dni, nombre, especie, raza, peso, sexo, nacimiento, estado) 
values(pdnimas, pnommas, pespmas, prazmas, ppesmas, psexmas, pnacmas, pestmas);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarServicio`(
	pdniser varchar(8),
	pnomser varchar(50),
	pvacser varchar(50),
	pdetser varchar(100),
	pfecser date,
	ppreser double
)
BEGIN
insert into VettbServicio(dni, nombre, vacuna, detalle, fecha, precio) 
values(pdniser, pnomser, pvacser, pdetser, pfecser, ppreser);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50),
	pserman varchar(50),
	pdetman varchar(100),
	pfecman date,
	ppreman double
)
BEGIN
insert into VettbVacunas(dni, nombre, servicio, detalle, fecha, precio) 
values(pdniman, pnomman, pserman, pdetman, pfecman, ppreman);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50),
	ptratra varchar(50),
	pdettra varchar(100),
	prectra varchar(100),
	pfectra date,
	pcittra date,
	ppretra double
)
BEGIN
insert into VettbTratamiento(dni, nombre, tratamiento, detalle, receta, fecha, cita, precio) 
values(pdnitra, pnomtra, ptratra, pdettra, prectra, pfectra, pcittra, ppretra);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarAgenda`(
  	pcodreg int(8),
	pdnireg varchar(8),
  	pnomreg varchar(50),
  	ptelreg varchar(12),
  	pdirreg varchar(50),
	pfecreg date,
	phorreg varchar(8),
	pactreg varchar(100)
)
BEGIN
insert into VettbAgenda(codigo, dni, nombre, telefono, direccion, fecha, hora, actividad) 
values(pcodreg, pdnireg, pnomreg, ptelreg, pdirreg, pfecreg, phorreg, pactreg);
COMMIT;
END//
DELIMITER ;

/***ACTUALIZAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarCliente`(
	pdnicli varchar(8),
	pnomcli varchar(50),
	papecli varchar(50),
	ptelcli varchar(12),
	pemacli varchar(100),
	pdircli varchar(50)
)
BEGIN
update VettbCliente set 
	dni = pdnicli,
	nombre = pnomcli,
	apellido = papecli,
	telefono = ptelcli,
	email = pemacli,
	direccion = pdircli
where
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarEmpleado`(
	pcodemp varchar(8),
	pnomemp varchar(50),
	papeemp varchar(50),
	pdiremp varchar(100),
	pemaemp varchar(100),
	pcaremp varchar(50),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
update VettbUsuario set 
	nombre = pnomemp,
	apellido = papeemp,
	direccion = pdiremp,
	email = pemaemp,
	cargo = pcaremp,
	clave = pclaemp,
	estado = pestemp
where
	codigo = pcodemp;
COMMIT;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarMascota`(
	pdnimas varchar(8),
	pnommas varchar(50),
	pespmas varchar(50),
	prazmas varchar(50),
	ppesmas varchar(12),
	psexmas varchar(6),
	pnacmas date,
	pestmas varchar(8)
)
BEGIN
update VettbMascota set
	especie = pespmas,
	raza = prazmas,
	peso = ppesmas,
	sexo = psexmas,
	nacimiento = pnacmas,
	estado = pestmas
where
	dni = pdnimas and nombre = pnommas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarServicio`(
	pdniser varchar(8),
	pnomser varchar(50),
	pvacser varchar(50),
	pdetser varchar(100),
	pfecser date,
	ppreser double
)
BEGIN
update VettbServicio set
	vacuna = pvacser,
	detalle = pdetser,
	fecha = pfecser,
	precio = ppreser
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50),
	pserman varchar(50),
	pdetman varchar(100),
	pfecman date,
	ppreman double
)
BEGIN
update VettbVacunas set 
	servicio = pserman,
	detalle = pdetman,
	fecha = pfecman,
	precio = ppreman
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50),
	ptratra varchar(50),
	pdettra varchar(100),
	prectra varchar(100),
	pfectra date,
	pcittra date,
	ppretra double
)
BEGIN
update VettbTratamiento set
	tratamiento = ptratra,
	detalle = pdettra,
	receta = prectra,
	fecha = pfectra,
	cita = pcittra,
	precio = ppretra
where
	dni = pdnitra and nombre = pnomtra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarAgenda`(
	pcodreg int(8),
	pdnireg varchar(8),
  	pnomreg varchar(50),
  	ptelreg varchar(12),
  	pdirreg varchar(50),
	pfecreg date,
	phorreg varchar(8),
	pactreg varchar(100)
)
BEGIN
update VettbAgenda set 
  	nombre = pnomreg,
  	telefono = ptelreg,
  	direccion = pdirreg,
	fecha = pfecreg,
	hora = phorreg,
	actividad = pactreg
where
	dni = pdnireg and codigo = pcodreg;
COMMIT;
END//
DELIMITER ;


/***BUSCAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarCliente`(
	pdnicli varchar(8)
)
BEGIN
	select * from VettbCliente
where
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarEmpleado`(
	pcodemp varchar(8)
)
BEGIN
	select * from VettbUsuario
where
	codigo = pcodemp;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMascota`(
	pdnimas varchar(8)
)
BEGIN
	select * from VettbMascota
where
	dni = pdnimas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMascotaConDni`(
	pdnimas varchar(8),
	pnommas varchar(50)
)
BEGIN
	select * from VettbMascota
where
	dni = pdnimas and nombre = pnommas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarServicio`(
	pdniser varchar(8),
	pnomser varchar(50)
)
BEGIN
	select * from VettbServicio
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarServicioFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbServicio
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarServicioConDni`(
	pdniser varchar(8)
)
BEGIN
	select * from VettbServicio
where
	dni = pdniser;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50)
)
BEGIN
	select * from VettbVacunas
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMantenimientoConDni`(
	pdniman varchar(8)
)
BEGIN
	select * from VettbVacunas
where
	dni = pdniman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarMantenimientoFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbVacunas
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50)
)
BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra and nombre = pnomtra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarTratamientoConDni`(
	pdnitra varchar(8)
)
BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarTratamientoFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbTratamiento
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarAgenda`(
	pfecreg date
)
BEGIN
	select * from VettbAgenda
where
	fecha = pfecreg;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarAgendaConDni`(
	pdniage varchar(8)
)
BEGIN
	select * from VettbAgenda
where
	dni = pdniage;
COMMIT;
END//
DELIMITER ;

/***LISTAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarCliente`()
	select * from VettbCliente
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarEmpleado`()
	select * from VettbUsuario
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarMascota`()
	select * from VettbMascota
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarServicio`()
	select * from VettbServicio
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarMantenimiento`()
	select * from VettbVacunas
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarTratamiento`()
	select * from VettbTratamiento
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarAgenda`()
	select * from VettbAgenda
END//
DELIMITER ;