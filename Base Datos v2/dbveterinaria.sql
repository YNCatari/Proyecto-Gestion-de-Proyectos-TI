-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-11-2021 a las 19:46:47
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbveterinaria`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_D_EliminarCliente` (`pdnicli` VARCHAR(8))  BEGIN
	delete from VettbCliente 
where 
	dni = pdnicli;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarAgenda` (`pcodreg` INT(8), `pdnireg` VARCHAR(8), `pnomreg` VARCHAR(50), `ptelreg` VARCHAR(12), `pdirreg` VARCHAR(50), `pfecreg` DATE, `phorreg` VARCHAR(8), `pactreg` VARCHAR(100))  BEGIN
insert into VettbAgenda(codigo, dni, nombre, telefono, direccion, fecha, hora, actividad) 
values(pcodreg, pdnireg, pnomreg, ptelreg, pdirreg, pfecreg, phorreg, pactreg);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarCliente` (`pdnicli` VARCHAR(8), `pnomcli` VARCHAR(50), `papecli` VARCHAR(50), `ptelcli` VARCHAR(12), `pemacli` VARCHAR(100), `pdircli` VARCHAR(50))  BEGIN
insert into VettbCliente(dni, nombre, apellido, telefono, email, direccion) 
values(pdnicli, pnomcli, papecli, ptelcli, pemacli, pdircli);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarEmpleado` (`pcodemp` VARCHAR(8), `pnomemp` VARCHAR(50), `papeemp` VARCHAR(50), `pdiremp` VARCHAR(100), `pemaemp` VARCHAR(100), `pcaremp` VARCHAR(50), `pclaemp` VARCHAR(8), `pestemp` VARCHAR(8))  BEGIN
insert into VettbUsuario(codigo, nombre, apellido, direccion, email, cargo, clave, estado) 
values(pcodemp, pnomemp, papeemp, pdiremp, pemaemp, pcaremp, pclaemp, pestemp);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarMantenimiento` (`pdniman` VARCHAR(8), `pnomman` VARCHAR(50), `pserman` VARCHAR(50), `pdetman` VARCHAR(100), `pfecman` DATE, `ppreman` DOUBLE)  BEGIN
insert into VettbVacunas(dni, nombre, servicio, detalle, fecha, precio) 
values(pdniman, pnomman, pserman, pdetman, pfecman, ppreman);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarMascota` (`pdnimas` VARCHAR(8), `pnommas` VARCHAR(50), `pespmas` VARCHAR(50), `prazmas` VARCHAR(50), `ppesmas` VARCHAR(12), `psexmas` VARCHAR(6), `pnacmas` DATE, `pestmas` VARCHAR(8))  BEGIN
insert into VettbMascota(dni, nombre, especie, raza, peso, sexo, nacimiento, estado) 
values(pdnimas, pnommas, pespmas, prazmas, ppesmas, psexmas, pnacmas, pestmas);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarServicio` (`pdniser` VARCHAR(8), `pnomser` VARCHAR(50), `pvacser` VARCHAR(50), `pdetser` VARCHAR(100), `pfecser` DATE, `ppreser` DOUBLE)  BEGIN
insert into VettbServicio(dni, nombre, vacuna, detalle, fecha, precio) 
values(pdniser, pnomser, pvacser, pdetser, pfecser, ppreser);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_I_AgregarTratamiento` (`pdnitra` VARCHAR(8), `pnomtra` VARCHAR(50), `ptratra` VARCHAR(50), `pdettra` VARCHAR(100), `prectra` VARCHAR(100), `pfectra` DATE, `pcittra` DATE, `ppretra` DOUBLE)  BEGIN
insert into VettbTratamiento(dni, nombre, tratamiento, detalle, receta, fecha, cita, precio) 
values(pdnitra, pnomtra, ptratra, pdettra, prectra, pfectra, pcittra, ppretra);
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarAgenda` (`pfecreg` DATE)  BEGIN
	select * from VettbAgenda
where
	fecha = pfecreg;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarAgendaConDni` (`pdniage` VARCHAR(8))  BEGIN
	select * from VettbAgenda
where
	dni = pdniage;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarCliente` (`pdnicli` VARCHAR(8))  BEGIN
	select * from VettbCliente
where
	dni = pdnicli;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarEmpleado` (`pcodemp` VARCHAR(8))  BEGIN
	select * from VettbUsuario
where
	codigo = pcodemp;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarMantenimiento` (`pdniman` VARCHAR(8), `pnomman` VARCHAR(50))  BEGIN
	select * from VettbVacunas
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarMantenimientoConDni` (`pdniman` VARCHAR(8))  BEGIN
	select * from VettbVacunas
where
	dni = pdniman;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarMascota` (`pdnimas` VARCHAR(8))  BEGIN
	select * from VettbMascota
where
	dni = pdnimas;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarMascotaConDni` (`pdnimas` VARCHAR(8), `pnommas` VARCHAR(50))  BEGIN
	select * from VettbMascota
where
	dni = pdnimas and nombre = pnommas;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarServicio` (`pdniser` VARCHAR(8), `pnomser` VARCHAR(50))  BEGIN
	select * from VettbServicio
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarServicioConDni` (`pdniser` VARCHAR(8))  BEGIN
	select * from VettbServicio
where
	dni = pdniser;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarTratamiento` (`pdnitra` VARCHAR(8), `pnomtra` VARCHAR(50))  BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra and nombre = pnomtra;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_BuscarTratamientoConDni` (`pdnitra` VARCHAR(8))  BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarAgenda` ()  select * from VettbAgenda
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarCliente` ()  select * from VettbCliente
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarEmpleado` ()  select * from VettbUsuario
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarMantenimiento` ()  select * from VettbVacunas
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarMascota` ()  select * from VettbMascota
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarServicio` ()  select * from VettbServicio
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ListarTratamiento` ()  select * from VettbTratamiento
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_SumarMantenimientoFecha` (`pfecini` DATE, `pfecfin` DATE)  BEGIN
	select sum(precio) from VettbVacunas
where
	fecha between pfecini and pfecfin;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_SumarServicioFecha` (`pfecini` DATE, `pfecfin` DATE)  BEGIN
	select sum(precio) from VettbServicio
where
	fecha between pfecini and pfecfin;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_SumarTratamientoFecha` (`pfecini` DATE, `pfecfin` DATE)  BEGIN
	select sum(precio) from VettbTratamiento
where
	fecha between pfecini and pfecfin;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_S_ValidarLogin` (`pcodemp` VARCHAR(8), `pclaemp` VARCHAR(8), `pestemp` VARCHAR(8))  BEGIN
	select * from VettbUsuario
where
	codigo = pcodemp and clave = pclaemp and estado = pestemp;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarAgenda` (`pcodreg` INT(8), `pdnireg` VARCHAR(8), `pnomreg` VARCHAR(50), `ptelreg` VARCHAR(12), `pdirreg` VARCHAR(50), `pfecreg` DATE, `phorreg` VARCHAR(8), `pactreg` VARCHAR(100))  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarCliente` (`pdnicli` VARCHAR(8), `pnomcli` VARCHAR(50), `papecli` VARCHAR(50), `ptelcli` VARCHAR(12), `pemacli` VARCHAR(100), `pdircli` VARCHAR(50))  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarEmpleado` (`pcodemp` VARCHAR(8), `pnomemp` VARCHAR(50), `papeemp` VARCHAR(50), `pdiremp` VARCHAR(100), `pemaemp` VARCHAR(100), `pcaremp` VARCHAR(50), `pclaemp` VARCHAR(8), `pestemp` VARCHAR(8))  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarMantenimiento` (`pdniman` VARCHAR(8), `pnomman` VARCHAR(50), `pserman` VARCHAR(50), `pdetman` VARCHAR(100), `pfecman` DATE, `ppreman` DOUBLE)  BEGIN
update VettbVacunas set 
	servicio = pserman,
	detalle = pdetman,
	fecha = pfecman,
	precio = ppreman
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarMascota` (`pdnimas` VARCHAR(8), `pnommas` VARCHAR(50), `pespmas` VARCHAR(50), `prazmas` VARCHAR(50), `ppesmas` VARCHAR(12), `psexmas` VARCHAR(6), `pnacmas` DATE, `pestmas` VARCHAR(8))  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarServicio` (`pdniser` VARCHAR(8), `pnomser` VARCHAR(50), `pvacser` VARCHAR(50), `pdetser` VARCHAR(100), `pfecser` DATE, `ppreser` DOUBLE)  BEGIN
update VettbServicio set
	vacuna = pvacser,
	detalle = pdetser,
	fecha = pfecser,
	precio = ppreser
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUSP_U_ActualizarTratamiento` (`pdnitra` VARCHAR(8), `pnomtra` VARCHAR(50), `ptratra` VARCHAR(50), `pdettra` VARCHAR(100), `prectra` VARCHAR(100), `pfectra` DATE, `pcittra` DATE, `ppretra` DOUBLE)  BEGIN
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
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbagenda`
--

CREATE TABLE `vettbagenda` (
  `codigo` int(8) NOT NULL,
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `telefono` varchar(12) NOT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `hora` varchar(8) DEFAULT NULL,
  `actividad` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbcliente`
--

CREATE TABLE `vettbcliente` (
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `telefono` varchar(12) NOT NULL,
  `email` varchar(100) NOT NULL,
  `direccion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbcliente`
--

INSERT INTO `vettbcliente` (`dni`, `nombre`, `apellido`, `telefono`, `email`, `direccion`) VALUES
('12345677', 'Jose', 'Vargas Llanos', '987484637', 'jose@gmail.com', 'AV  Cono Sur'),
('12345678', 'Juan ', 'Mamani Loza', '945667889', 'juan@gmail.com', 'Av jorge chavez'),
('12345679', 'Delia', 'Lopes Delgado', '987564534', 'delia@gmail.com', 'Av Tacna');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbmascota`
--

CREATE TABLE `vettbmascota` (
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `especie` varchar(50) NOT NULL,
  `raza` varchar(50) NOT NULL,
  `peso` varchar(12) NOT NULL,
  `sexo` varchar(6) NOT NULL,
  `nacimiento` date DEFAULT NULL,
  `estado` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbmascota`
--

INSERT INTO `vettbmascota` (`dni`, `nombre`, `especie`, `raza`, `peso`, `sexo`, `nacimiento`, `estado`) VALUES
('12345678', 'chiripa', 'dog', 'Poodle', '15', 'Macho', '2021-11-22', 'TRUE'),
('12345678', 'Golfi', 'Dog', 'Pastor Aleman', '25', 'Macho', '2021-11-22', 'TRUE'),
('12345679', 'Lasi', 'Dog', 'Chihuahua', '9', 'Hembra', '2021-11-22', 'TRUE'),
('12345677', 'Coco', 'Dog', 'Bulldog', '30', 'Macho', '2021-11-22', 'TRUE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbservicio`
--

CREATE TABLE `vettbservicio` (
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `vacuna` varchar(50) NOT NULL,
  `detalle` varchar(100) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `precio` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbservicio`
--

INSERT INTO `vettbservicio` (`dni`, `nombre`, `vacuna`, `detalle`, `fecha`, `precio`) VALUES
('12345678', 'Juan ,Mamani Loza', 'Distemper', 'Vacuna contra el distemper', '2021-11-22', 20),
('12345678', 'Juan ,Mamani Loza', 'Hepatitis', 'Vacuna contra la hepatitis infecciosa canina o adenovirus canino 2 (AVC-2)', '2021-11-22', 35),
('12345679', 'Delia,Lopes Delgado', 'leptospirosis', 'Vacuna contra la leptospirosis.', '2021-11-22', 25),
('12345677', 'Jose,Vargas Llanos', 'rabia', 'Esta vacuna debe ser aplicada anualmente', '2021-11-22', 27);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbtratamiento`
--

CREATE TABLE `vettbtratamiento` (
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `tratamiento` varchar(50) NOT NULL,
  `detalle` varchar(100) DEFAULT NULL,
  `receta` varchar(100) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `cita` date DEFAULT NULL,
  `precio` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbtratamiento`
--

INSERT INTO `vettbtratamiento` (`dni`, `nombre`, `tratamiento`, `detalle`, `receta`, `fecha`, `cita`, `precio`) VALUES
('12345678', 'Golfi', 'Antiinflamatorios', 'para el tratamiento de la dermatitis atópica, las reacciones alérgicas ', 'corticoesteroides o ciclosporina', '2021-11-22', '2021-11-22', 45),
('12345678', 'chiripa', 'Acaricidas', 'son medicamentos para tratar la sarna', 'isoxazolinas', '2021-11-22', '2021-11-22', 18),
('12345677', 'Coco', 'Acarticidas', 'son medicamentos para tratar la sarna', 'Isoxazolinas', '2021-11-22', '2021-11-27', 18);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbusuario`
--

CREATE TABLE `vettbusuario` (
  `codigo` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `cargo` varchar(50) NOT NULL,
  `clave` varchar(8) NOT NULL,
  `estado` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbusuario`
--

INSERT INTO `vettbusuario` (`codigo`, `nombre`, `apellido`, `direccion`, `email`, `cargo`, `clave`, `estado`) VALUES
('45635223', 'Midwar Henry ', 'LOZA FLORES', 'Tacna', 'midwarhenry8@gmail.com', 'Medico Veterinario', '123456', 'TRUE'),
('72567658', 'Yober Nain', 'CATARI CABRERA', 'Tacna', 'yobernain@gmail.com', 'Administrador', '123456', 'TRUE'),
('77222801', 'Jhon Thomas ', 'TICONA CHAMBI', 'Tacna', 'lovecraft005@hotmail.com', 'Asistente', '123456', 'TRUE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vettbvacunas`
--

CREATE TABLE `vettbvacunas` (
  `dni` varchar(8) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `servicio` varchar(50) NOT NULL,
  `detalle` varchar(100) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `precio` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vettbvacunas`
--

INSERT INTO `vettbvacunas` (`dni`, `nombre`, `servicio`, `detalle`, `fecha`, `precio`) VALUES
('12345679', 'Lasi', 'Baño y Limpieza Bucal', 'Servicio de Limpieza canina', '2021-11-22', 30),
('12345677', 'Coco', 'Baño', 'desenreda su pelo y elimina los nudos', '2021-11-22', 20);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `vettbagenda`
--
ALTER TABLE `vettbagenda`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `FK_Cliente_Agenda` (`dni`);

--
-- Indices de la tabla `vettbcliente`
--
ALTER TABLE `vettbcliente`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `vettbmascota`
--
ALTER TABLE `vettbmascota`
  ADD KEY `FK_Cliente_Mascota` (`dni`);

--
-- Indices de la tabla `vettbservicio`
--
ALTER TABLE `vettbservicio`
  ADD KEY `FK_Cliente_Servicio` (`dni`);

--
-- Indices de la tabla `vettbtratamiento`
--
ALTER TABLE `vettbtratamiento`
  ADD KEY `FK_Cliente_Tratamiento` (`dni`);

--
-- Indices de la tabla `vettbusuario`
--
ALTER TABLE `vettbusuario`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `vettbvacunas`
--
ALTER TABLE `vettbvacunas`
  ADD KEY `FK_Cliente_Mantenimiento` (`dni`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `vettbagenda`
--
ALTER TABLE `vettbagenda`
  MODIFY `codigo` int(8) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `vettbagenda`
--
ALTER TABLE `vettbagenda`
  ADD CONSTRAINT `FK_Cliente_Agenda` FOREIGN KEY (`dni`) REFERENCES `vettbcliente` (`dni`);

--
-- Filtros para la tabla `vettbmascota`
--
ALTER TABLE `vettbmascota`
  ADD CONSTRAINT `FK_Cliente_Mascota` FOREIGN KEY (`dni`) REFERENCES `vettbcliente` (`dni`);

--
-- Filtros para la tabla `vettbservicio`
--
ALTER TABLE `vettbservicio`
  ADD CONSTRAINT `FK_Cliente_Servicio` FOREIGN KEY (`dni`) REFERENCES `vettbcliente` (`dni`);

--
-- Filtros para la tabla `vettbtratamiento`
--
ALTER TABLE `vettbtratamiento`
  ADD CONSTRAINT `FK_Cliente_Tratamiento` FOREIGN KEY (`dni`) REFERENCES `vettbcliente` (`dni`);

--
-- Filtros para la tabla `vettbvacunas`
--
ALTER TABLE `vettbvacunas`
  ADD CONSTRAINT `FK_Cliente_Mantenimiento` FOREIGN KEY (`dni`) REFERENCES `vettbcliente` (`dni`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
