-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2014 at 04:13 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cibercafe`
--

-- --------------------------------------------------------

--
-- Table structure for table `arriendo`
--

CREATE TABLE IF NOT EXISTS `arriendo` (
`numero_arriendo` mediumint(9) NOT NULL,
  `fecha_hora_inicio` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `id_equipo` tinyint(4) DEFAULT NULL,
  `cod_tarifa` smallint(6) DEFAULT NULL,
  `precio_por_hora` mediumint(9) DEFAULT NULL,
  `total_precio_arriendo` mediumint(9) DEFAULT NULL,
  `usuario_cliente` char(15) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `caja`
--

CREATE TABLE IF NOT EXISTS `caja` (
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `tipo_transacc` char(1) CHARACTER SET latin1 NOT NULL,
  `monto` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `caja`
--

INSERT INTO `caja` (`fechaHora`, `tipo_transacc`, `monto`) VALUES
('2014-12-01 18:45:22', '1', 1000000),
('2014-12-02 17:48:47', '1', 520020);

-- --------------------------------------------------------

--
-- Table structure for table `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `cod_categoria` tinyint(4) NOT NULL DEFAULT '0',
  `nombre_categoria` char(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` char(30) COLLATE latin1_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `nombre_usuario` char(15) COLLATE latin1_spanish_ci NOT NULL,
  `nombre` char(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `apellidos` char(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `password` char(15) COLLATE latin1_spanish_ci NOT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`nombre_usuario`, `nombre`, `apellidos`, `password`, `estado`) VALUES
('HeidiSQL', 'Andres', 'Quezada', 'elmirador', 0),
('HH', 'Andres', 'Quezada', 'elmirador', 0),
('Hsexo', 'Sergio', 'Mora', 'shexomora', 0),
('Ordeal', '135135', '64163', 'elmirador', 0);

-- --------------------------------------------------------

--
-- Table structure for table `computador`
--

CREATE TABLE IF NOT EXISTS `computador` (
  `direcc_MAC` char(12) COLLATE latin1_spanish_ci NOT NULL,
  `direcc_IP` bigint(20) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Dumping data for table `computador`
--

INSERT INTO `computador` (`direcc_MAC`, `direcc_IP`, `estado`) VALUES
('111111111111', 111111111, 1),
('111111111112', 111111111, 1),
('112233445566', 19216820, 1),
('aabbccddeeff', 19216821, 2),
('ffeeddccbbaa', 127001, 0);

-- --------------------------------------------------------

--
-- Table structure for table `consola`
--

CREATE TABLE IF NOT EXISTS `consola` (
  `numero_consola` char(12) COLLATE latin1_spanish_ci NOT NULL,
  `estado` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Dumping data for table `consola`
--

INSERT INTO `consola` (`numero_consola`, `estado`) VALUES
('01', 1),
('02', 1);

-- --------------------------------------------------------

--
-- Table structure for table `detalle_fact`
--

CREATE TABLE IF NOT EXISTS `detalle_fact` (
  `cod_producto` smallint(5) NOT NULL,
  `numero_factura` mediumint(9) NOT NULL,
  `rut_proveedor` char(9) CHARACTER SET latin1 NOT NULL,
  `cant_comprada` smallint(6) DEFAULT NULL,
  `precio_unit_compra` mediumint(9) DEFAULT NULL,
  `subtotal` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `detalle_venta`
--

CREATE TABLE IF NOT EXISTS `detalle_venta` (
  `cod_producto` smallint(5) NOT NULL,
  `numero_venta` mediumint(9) NOT NULL,
  `cantidad` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `equipo`
--

CREATE TABLE IF NOT EXISTS `equipo` (
  `id_equipo` tinyint(4) NOT NULL DEFAULT '0',
  `tipo_equipo` varchar(4) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
  `numero_factura` mediumint(9) NOT NULL,
  `rut_proveedor` char(9) CHARACTER SET latin1 NOT NULL,
  `fecha_compra` datetime DEFAULT NULL,
  `total` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `historial_precio`
--

CREATE TABLE IF NOT EXISTS `historial_precio` (
  `cod_producto` smallint(5) NOT NULL,
  `fecha` datetime NOT NULL,
  `precio` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `historial_sesiones_trabajador`
--

CREATE TABLE IF NOT EXISTS `historial_sesiones_trabajador` (
  `rut_trabajador` char(9) NOT NULL,
  `fecha_termino_sesion` datetime DEFAULT NULL,
  `fecha_inicio_sesion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historial_sesiones_trabajador`
--

INSERT INTO `historial_sesiones_trabajador` (`rut_trabajador`, `fecha_termino_sesion`, `fecha_inicio_sesion`) VALUES
('184576589', '2014-12-02 23:22:57', '2014-12-02 23:22:53'),
('184576589', '2014-12-03 16:50:43', '2014-12-03 16:50:26'),
('184576589', '2014-12-03 16:59:58', '2014-12-03 16:59:35'),
('184576589', NULL, '2014-12-03 17:00:24'),
('184576589', NULL, '2014-12-03 17:01:45'),
('184576589', NULL, '2014-12-03 17:02:41'),
('184576589', '2014-12-03 17:03:28', '2014-12-03 17:03:16'),
('184576589', '2014-12-03 17:05:52', '2014-12-03 17:05:15'),
('184576589', NULL, '2014-12-03 17:06:17'),
('184576589', NULL, '2014-12-03 18:02:43'),
('184576589', NULL, '2014-12-03 18:03:31'),
('184576589', NULL, '2014-12-03 18:06:39'),
('184576589', NULL, '2014-12-03 18:08:47'),
('184576589', NULL, '2014-12-03 18:13:56'),
('184576589', NULL, '2014-12-03 18:39:03'),
('184576589', NULL, '2014-12-03 18:40:12'),
('184576589', NULL, '2014-12-03 18:40:46'),
('184576589', NULL, '2014-12-03 18:41:51'),
('184576589', NULL, '2014-12-03 18:43:03'),
('184576589', NULL, '2014-12-03 18:44:17'),
('184576589', NULL, '2014-12-03 18:47:33'),
('184576589', '2014-12-03 18:49:35', '2014-12-03 18:49:20'),
('184576589', '2014-12-03 18:51:06', '2014-12-03 18:50:55'),
('184576589', '2014-12-03 18:55:56', '2014-12-03 18:55:40'),
('184576589', '2014-12-03 18:57:16', '2014-12-03 18:56:48'),
('184576589', '2014-12-03 19:06:56', '2014-12-03 19:05:55'),
('184576589', '2014-12-03 19:12:54', '2014-12-03 19:12:14'),
('184576589', '2014-12-03 19:16:51', '2014-12-03 19:16:24'),
('184576589', '2014-12-03 19:19:53', '2014-12-03 19:19:10'),
('184576589', '2014-12-03 19:20:25', '2014-12-03 19:20:08'),
('184576589', '2014-12-03 19:26:51', '2014-12-03 19:21:12'),
('184576589', '2014-12-03 19:28:42', '2014-12-03 19:28:26'),
('184576589', '2014-12-03 19:32:25', '2014-12-03 19:31:52'),
('184576589', '2014-12-03 19:33:54', '2014-12-03 19:33:48'),
('184576589', '2014-12-03 19:35:12', '2014-12-03 19:35:07'),
('184576589', '2014-12-03 19:36:53', '2014-12-03 19:36:21'),
('184576589', NULL, '2014-12-03 19:37:33'),
('184576589', '2014-12-03 19:42:33', '2014-12-03 19:42:08'),
('184576589', '2014-12-03 19:45:39', '2014-12-03 19:44:36'),
('184576589', '2014-12-03 19:47:30', '2014-12-03 19:47:20'),
('184576589', '2014-12-03 19:47:55', '2014-12-03 19:47:44'),
('184576589', '2014-12-03 19:52:34', '2014-12-03 19:52:25'),
('184576589', '2014-12-03 19:54:52', '2014-12-03 19:54:32'),
('184576589', '2014-12-03 20:14:44', '2014-12-03 20:14:31'),
('184576589', '2014-12-03 20:17:19', '2014-12-03 20:16:23'),
('184576589', '2014-12-03 21:12:22', '2014-12-03 21:11:41'),
('184576589', '2014-12-03 21:18:36', '2014-12-03 21:18:27'),
('184576589', '2014-12-03 21:33:40', '2014-12-03 21:33:01'),
('184576589', '2014-12-03 21:40:00', '2014-12-03 21:39:32'),
('184576589', '2014-12-03 21:44:30', '2014-12-03 21:44:11'),
('184576589', NULL, '2014-12-03 21:52:58'),
('184576589', '2014-12-03 22:20:26', '2014-12-03 22:19:57'),
('184576589', '2014-12-03 22:20:53', '2014-12-03 22:20:48'),
('184576589', '2014-12-03 22:27:30', '2014-12-03 22:27:24'),
('184576589', '2014-12-03 22:28:41', '2014-12-03 22:28:34'),
('184576589', '2014-12-03 22:29:21', '2014-12-03 22:29:13'),
('184576589', '2014-12-03 22:35:46', '2014-12-03 22:35:41'),
('184576589', '2014-12-03 22:36:36', '2014-12-03 22:36:23'),
('184576589', '2014-12-04 13:27:43', '2014-12-04 13:27:06'),
('184576589', '2014-12-04 13:41:27', '2014-12-04 13:41:09'),
('184576589', '2014-12-04 13:43:16', '2014-12-04 13:42:55'),
('184576589', '2014-12-04 13:45:52', '2014-12-04 13:45:31'),
('184576589', '2014-12-04 14:26:41', '2014-12-04 14:26:29'),
('184576589', NULL, '2014-12-04 14:27:32'),
('184576589', '2014-12-04 14:28:51', '2014-12-04 14:28:35'),
('184576589', '2014-12-04 14:30:16', '2014-12-04 14:29:51'),
('184576589', '2014-12-04 14:31:16', '2014-12-04 14:30:50'),
('184576589', '2014-12-04 14:32:03', '2014-12-04 14:31:48'),
('184576589', '2014-12-04 14:34:03', '2014-12-04 14:33:50'),
('184576589', NULL, '2014-12-04 15:49:32'),
('184576589', NULL, '2014-12-04 15:52:06'),
('184576589', NULL, '2014-12-04 15:53:22'),
('184576589', NULL, '2014-12-04 15:55:34'),
('184576589', NULL, '2014-12-04 15:56:53'),
('184576589', '2014-12-04 16:00:02', '2014-12-04 15:59:33'),
('184576589', '2014-12-04 16:06:04', '2014-12-04 16:05:55'),
('184576589', NULL, '2014-12-04 16:06:24'),
('184576589', '2014-12-04 16:07:20', '2014-12-04 16:07:07'),
('184576589', '2014-12-04 16:38:51', '2014-12-04 16:38:48'),
('184576589', '2014-12-04 16:39:05', '2014-12-04 16:39:03'),
('184576589', '2014-12-04 16:57:19', '2014-12-04 16:57:17'),
('184576589', '2014-12-04 16:59:19', '2014-12-04 16:58:43'),
('184576589', '2014-12-04 17:00:22', '2014-12-04 16:59:57'),
('184576589', '2014-12-04 17:01:26', '2014-12-04 17:00:51'),
('184576589', '2014-12-04 17:10:13', '2014-12-04 17:10:04'),
('184576589', '2014-12-04 17:12:40', '2014-12-04 17:10:49'),
('184576589', '2014-12-04 22:17:55', '2014-12-04 22:17:12'),
('184576589', NULL, '2014-12-04 22:24:56'),
('184576589', '2014-12-04 22:26:36', '2014-12-04 22:26:07'),
('184576589', NULL, '2014-12-04 22:27:28'),
('184576589', '2014-12-04 22:32:03', '2014-12-04 22:31:43'),
('184576589', '2014-12-04 23:09:57', '2014-12-04 23:09:40'),
('184576589', NULL, '2014-12-04 23:10:27'),
('184576589', '2014-12-04 23:25:12', '2014-12-04 23:22:13'),
('184576589', NULL, '2014-12-04 23:32:05'),
('184576589', '2014-12-04 23:34:49', '2014-12-04 23:33:01'),
('184576589', '2014-12-04 23:38:43', '2014-12-04 23:38:00');

-- --------------------------------------------------------

--
-- Table structure for table `historial_tarifa`
--

CREATE TABLE IF NOT EXISTS `historial_tarifa` (
  `cod_tarifa` smallint(6) NOT NULL,
  `valor_hora` smallint(6) NOT NULL,
  `tipo_equipo` varchar(4) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `cod_producto` smallint(5) NOT NULL,
  `nom_producto` char(20) CHARACTER SET latin1 DEFAULT NULL,
  `precio_unitario` mediumint(9) DEFAULT NULL,
  `cod_categoria` tinyint(4) DEFAULT NULL,
  `cantidad` smallint(6) DEFAULT NULL,
  `cantidad_minima` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `producto`
--

INSERT INTO `producto` (`cod_producto`, `nom_producto`, `precio_unitario`, `cod_categoria`, `cantidad`, `cantidad_minima`) VALUES
(1, 'Chocman 37 grs', 120, NULL, 50, 20),
(2, 'Sprite 2 Lts', 1100, NULL, 20, 5),
(3, 'CD-RW', 250, NULL, 30, 5),
(4, 'Lapiz BIC Cristal', 130, NULL, 50, 33),
(5, 'Evercrisp ram. queso', 250, NULL, 10, 8),
(6, 'Pinguinos Marinela', 300, NULL, 10, 10),
(7, 'Cuaderno univ 100 hj', 900, NULL, 5, 4),
(11, 'Grafito N2 F Castell', 100, NULL, 50, 20);

-- --------------------------------------------------------

--
-- Table structure for table `proveedores`
--

CREATE TABLE IF NOT EXISTS `proveedores` (
  `rut_proveedor` char(9) CHARACTER SET latin1 NOT NULL,
  `nombre_proveedor` char(20) CHARACTER SET latin1 DEFAULT NULL,
  `telefono_proveedor` varchar(20) DEFAULT NULL,
  `direccion_proveedor` char(20) CHARACTER SET latin1 DEFAULT NULL,
  `nombre_empresa_proveedor` char(20) DEFAULT NULL,
  `e_mail_proveedor` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `proveedores`
--

INSERT INTO `proveedores` (`rut_proveedor`, `nombre_proveedor`, `telefono_proveedor`, `direccion_proveedor`, `nombre_empresa_proveedor`, `e_mail_proveedor`) VALUES
('222222222', 'Andres Quezada', '2120241', 'Undurraga 234', 'Ordeal Ltd', 'andres@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tiempos_en_reserva`
--

CREATE TABLE IF NOT EXISTS `tiempos_en_reserva` (
  `nombre_usuario` char(15) NOT NULL,
  `tiempo_a_favor` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_equipo`
--

CREATE TABLE IF NOT EXISTS `tipo_equipo` (
  `tipo_equipo` varchar(4) NOT NULL,
  `descipcion` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `rut` char(9) COLLATE latin1_spanish_ci NOT NULL,
  `nombre` char(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `apellidos` char(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `fono` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `password` char(15) COLLATE latin1_spanish_ci NOT NULL,
  `tipo_usuario` tinyint(4) NOT NULL,
  `estado` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`rut`, `nombre`, `apellidos`, `fono`, `password`, `tipo_usuario`, `estado`) VALUES
('123456785', 'usr02', 'usr02', '12345678', 'chao', 2, 0),
('123456789', 'usr02', 'usr02', '0', 'chao', 2, 1),
('12452', '2', '2', '2', '2', 0, 2),
('184576589', 'Andres', 'Quezada', '2120241', 'elmirador', 2, 0),
('197357940', 'Sergio', 'Mora', '12345678', 'berrueta1994', 2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
  `numero_venta` mediumint(9) NOT NULL DEFAULT '0',
  `fecha` datetime DEFAULT NULL,
  `total` mediumint(9) DEFAULT NULL,
  `rut_trabajador` char(9) COLLATE latin1_spanish_ci NOT NULL,
  `tipo_venta` tinyint(4) NOT NULL,
  `ARRIENDO_numero_arriendo` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Dumping data for table `venta`
--

INSERT INTO `venta` (`numero_venta`, `fecha`, `total`, `rut_trabajador`, `tipo_venta`, `ARRIENDO_numero_arriendo`) VALUES
(1, '2014-12-02 16:45:45', 600, '184576589', 1, NULL),
(2, '2014-12-02 17:44:02', 3000, '184576589', 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `venta_anulada`
--

CREATE TABLE IF NOT EXISTS `venta_anulada` (
  `numero_venta` mediumint(9) NOT NULL,
  `fecha` date NOT NULL,
  `motivo` int(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `arriendo`
--
ALTER TABLE `arriendo`
 ADD PRIMARY KEY (`numero_arriendo`), ADD KEY `cod_tarifa` (`cod_tarifa`), ADD KEY `fk_id_equipo` (`id_equipo`);

--
-- Indexes for table `caja`
--
ALTER TABLE `caja`
 ADD PRIMARY KEY (`fechaHora`,`tipo_transacc`), ADD UNIQUE KEY `fechaHora_UNIQUE` (`fechaHora`);

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
 ADD PRIMARY KEY (`cod_categoria`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
 ADD PRIMARY KEY (`nombre_usuario`);

--
-- Indexes for table `computador`
--
ALTER TABLE `computador`
 ADD PRIMARY KEY (`direcc_MAC`);

--
-- Indexes for table `consola`
--
ALTER TABLE `consola`
 ADD PRIMARY KEY (`numero_consola`);

--
-- Indexes for table `detalle_fact`
--
ALTER TABLE `detalle_fact`
 ADD PRIMARY KEY (`cod_producto`,`numero_factura`,`rut_proveedor`), ADD KEY `FK-Detalle_Fact.rut_proveedor` (`rut_proveedor`), ADD KEY `numero_factura` (`numero_factura`);

--
-- Indexes for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
 ADD PRIMARY KEY (`cod_producto`,`numero_venta`), ADD KEY `fk_DETALLE_VENTA_VENTA1_idx` (`numero_venta`), ADD KEY `cod_producto` (`cod_producto`);

--
-- Indexes for table `equipo`
--
ALTER TABLE `equipo`
 ADD PRIMARY KEY (`id_equipo`), ADD KEY `tipo_equipo` (`tipo_equipo`);

--
-- Indexes for table `factura`
--
ALTER TABLE `factura`
 ADD PRIMARY KEY (`numero_factura`,`rut_proveedor`), ADD KEY `rut_idx` (`rut_proveedor`), ADD KEY `numero_factura` (`numero_factura`);

--
-- Indexes for table `historial_precio`
--
ALTER TABLE `historial_precio`
 ADD PRIMARY KEY (`cod_producto`,`fecha`);

--
-- Indexes for table `historial_sesiones_trabajador`
--
ALTER TABLE `historial_sesiones_trabajador`
 ADD PRIMARY KEY (`rut_trabajador`,`fecha_inicio_sesion`);

--
-- Indexes for table `historial_tarifa`
--
ALTER TABLE `historial_tarifa`
 ADD PRIMARY KEY (`cod_tarifa`), ADD KEY `fk_HISTORIAL_ARRIENDO_ARRIENDO1_idx` (`cod_tarifa`), ADD KEY `tipo_equipo` (`tipo_equipo`), ADD KEY `tipo_equipo_2` (`tipo_equipo`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
 ADD PRIMARY KEY (`cod_producto`), ADD UNIQUE KEY `cod_producto_2` (`cod_producto`), ADD KEY `categoria_idx` (`cod_categoria`), ADD KEY `cod_producto` (`cod_producto`);

--
-- Indexes for table `proveedores`
--
ALTER TABLE `proveedores`
 ADD PRIMARY KEY (`rut_proveedor`);

--
-- Indexes for table `tiempos_en_reserva`
--
ALTER TABLE `tiempos_en_reserva`
 ADD PRIMARY KEY (`nombre_usuario`);

--
-- Indexes for table `tipo_equipo`
--
ALTER TABLE `tipo_equipo`
 ADD PRIMARY KEY (`tipo_equipo`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
 ADD PRIMARY KEY (`rut`), ADD KEY `fk_USUARIO_TRABAJADOR1_idx` (`rut`);

--
-- Indexes for table `venta`
--
ALTER TABLE `venta`
 ADD PRIMARY KEY (`numero_venta`), ADD UNIQUE KEY `numero_venta_UNIQUE` (`numero_venta`), ADD KEY `venta_historial_trabajador_idx` (`rut_trabajador`,`fecha`), ADD KEY `fk_VENTA_ARRIENDO1_idx` (`ARRIENDO_numero_arriendo`), ADD KEY `rut_trabajador` (`rut_trabajador`), ADD KEY `ARRIENDO_numero_arriendo` (`ARRIENDO_numero_arriendo`);

--
-- Indexes for table `venta_anulada`
--
ALTER TABLE `venta_anulada`
 ADD PRIMARY KEY (`numero_venta`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `arriendo`
--
ALTER TABLE `arriendo`
MODIFY `numero_arriendo` mediumint(9) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `arriendo`
--
ALTER TABLE `arriendo`
ADD CONSTRAINT `arriendo_ibfk_1` FOREIGN KEY (`cod_tarifa`) REFERENCES `historial_tarifa` (`cod_tarifa`) ON UPDATE CASCADE,
ADD CONSTRAINT `arriendo_ibfk_2` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`) ON UPDATE CASCADE;

--
-- Constraints for table `detalle_fact`
--
ALTER TABLE `detalle_fact`
ADD CONSTRAINT `FK-Detalle_Fact.rut_proveedor` FOREIGN KEY (`rut_proveedor`) REFERENCES `proveedores` (`rut_proveedor`) ON UPDATE CASCADE,
ADD CONSTRAINT `detalle_fact_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `producto` (`cod_producto`) ON UPDATE CASCADE,
ADD CONSTRAINT `detalle_fact_ibfk_2` FOREIGN KEY (`numero_factura`) REFERENCES `factura` (`numero_factura`) ON UPDATE CASCADE;

--
-- Constraints for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
ADD CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`numero_venta`) REFERENCES `venta` (`numero_venta`) ON UPDATE CASCADE,
ADD CONSTRAINT `producto` FOREIGN KEY (`cod_producto`) REFERENCES `producto` (`cod_producto`) ON UPDATE CASCADE;

--
-- Constraints for table `equipo`
--
ALTER TABLE `equipo`
ADD CONSTRAINT `equipo_ibfk_1` FOREIGN KEY (`tipo_equipo`) REFERENCES `tipo_equipo` (`tipo_equipo`);

--
-- Constraints for table `factura`
--
ALTER TABLE `factura`
ADD CONSTRAINT `FK-Factura.rut_proveedor-Proveedores.rut_proveedor` FOREIGN KEY (`rut_proveedor`) REFERENCES `proveedores` (`rut_proveedor`) ON UPDATE CASCADE;

--
-- Constraints for table `historial_precio`
--
ALTER TABLE `historial_precio`
ADD CONSTRAINT `historial_precio_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `producto` (`cod_producto`) ON UPDATE CASCADE;

--
-- Constraints for table `producto`
--
ALTER TABLE `producto`
ADD CONSTRAINT `FK_CATEGORIA_PRODUCTO` FOREIGN KEY (`cod_categoria`) REFERENCES `categoria` (`cod_categoria`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `venta`
--
ALTER TABLE `venta`
ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`rut_trabajador`) REFERENCES `usuario` (`rut`) ON UPDATE CASCADE,
ADD CONSTRAINT `venta_ibfk_2` FOREIGN KEY (`ARRIENDO_numero_arriendo`) REFERENCES `arriendo` (`numero_arriendo`) ON UPDATE CASCADE;

--
-- Constraints for table `venta_anulada`
--
ALTER TABLE `venta_anulada`
ADD CONSTRAINT `venta_anulada_ibfk_1` FOREIGN KEY (`numero_venta`) REFERENCES `venta` (`numero_venta`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
