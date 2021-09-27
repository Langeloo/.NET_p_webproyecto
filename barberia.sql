-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-09-2021 a las 07:28:37
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `barberia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `Correo` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Nombre1` varchar(30) NOT NULL,
  `Nombre2` varchar(30) DEFAULT NULL,
  `Apellido1` varchar(30) NOT NULL,
  `Apellido2` varchar(30) NOT NULL,
  `Rol` varchar(30) NOT NULL,
  `Edad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Esta es la tabla de los usuarios de la barberia';

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`Correo`, `Password`, `Nombre1`, `Nombre2`, `Apellido1`, `Apellido2`, `Rol`, `Edad`) VALUES
('administrador@gmail.com', '12345678', 'Miguel', 'Ramirez', 'Cordoba', 'Aguilar', 'Administrador', 20),
('Chirrigomez@gmail.com', 'amoalaura', 'Juan', 'David', 'Penelope', 'Paez', 'Usuario', 15),
('comemamas@gmail.com', 'edwinsandob', 'Julian', 'Alexis', 'Cordoba', 'parreaz', 'Usuario', 26),
('Cristian@gmail.com', 'afcasf', 'Camilo', '', 'Caicedo', 'Binkowsky', 'Barbero', 21),
('CristianVinasco@hotmail.com', 'egesgseg', 'Andres', 'phillip', 'Gomez', 'Parra', 'Barbero', 18),
('Edwinsandoval090@gmail.com', 'edwin123', 'Edwin', '', 'Sandoval', 'Vaquiro', 'Barbero', 21),
('holas@gmail.com', 'wdwdwdwdwdwd', 'Laura', '', 'Sandoval', 'Vaquiro', 'Usuario', 22),
('robamamas@gmail.com', 'ijsmab123', 'David', 'Santiago', 'Lopez', 'Diaz', 'Barbero', 32),
('robamamasaaa@gmail.com', 'afdawf', 'Camilo', '', 'Sandoval', 'Vaquiro', 'Barbero', 16),
('toto@gmail.com', '12345678', 'Edwin', '', 'Lopez', 'Obrador', 'Barbero', 20),
('Vaquiro1212@gmail.com', 'edwin123', 'Ramiro', 'Alexis', 'Cordoba', 'Correa', 'Usuario', 19),
('vaquiro@gmail.com', '125412', 'David', '', 'Lopez', 'Garcia', 'Barbero', 32);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Correo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
