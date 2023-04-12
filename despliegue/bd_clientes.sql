-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-04-2023 a las 17:46:29
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_clientes`
--
CREATE DATABASE IF NOT EXISTS `bd_clientes` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `bd_clientes`;

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_getcustomers` ()  SELECT 
    id,
    email, nombre,
    apellido,
    fecha 
FROM user$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `apellido` varchar(255) NOT NULL,
  `fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `email`, `nombre`, `apellido`, `fecha`) VALUES
(5, 'nbmnb', 'nmbmnb', 'mnb', '2023-04-10'),
(7, 'aasdsaa', 'adfadas', 'asdadsa', '2023-10-20'),
(8, 'string', 'string', 'string', '2023-04-03'),
(9, 'string', 'string', 'string', '2023-04-03'),
(10, 'sdfds', 'string', 'string', '2023-04-03'),
(11, 'sdfds', 'string', 'string', '2023-04-03'),
(12, 'sdfds', 'string', 'string', '2023-01-03'),
(13, 'sdfds', 'string', 'string', '2023-01-10'),
(14, 'sdfds@gmail.com', 'string', 'string', '2023-01-10'),
(15, 'sdfds@gmail.com', 'string', 'string', '2023-04-03'),
(16, 'sdfds@gmail.com', 'string', 'string', '2023-04-03'),
(17, 'sdfds@gmail.com', 'string', 'string', '2023-04-03'),
(18, 'sdfds@gmail.com', 'strinbmng', 'strnmbnmbing', '2023-04-03'),
(19, 'sdfds@gmal.com', 'strinbmng', 'strnmbnmbing', '2023-04-03'),
(20, 'sdfds@gmal.com', 'strinbmng', 'strnmbnmbing', '2023-01-03'),
(21, 'sdfds@gmal.com', 'strinbmng', 'strnmbnmbing', '2023-01-03'),
(22, 'sfds@gmal.com', 'strinbmng', 'strnmbnmbing', '2023-01-03'),
(23, 'sfds@gmal.com', 'strinbmng', 'strnmbnmbing', '2023-01-03'),
(24, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(25, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(26, 'nikolas@gmail.com', 'nikolas', 'Santofimio', '2023-01-03'),
(27, 'sergio@gmail.com', 'Sergio', 'Moreno', '2023-01-03'),
(28, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(29, 'nikolas@gmail.com', 'nikolas', 'Santofimio', '2023-01-03'),
(30, 'sergio@gmail.com', 'Sergio', 'Moreno', '2023-01-03'),
(31, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(32, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(33, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(34, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(35, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(36, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(37, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(38, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(39, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(40, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(41, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(42, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(43, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(44, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(45, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(46, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(47, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(48, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(49, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(50, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(51, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(52, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(53, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(54, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(55, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(56, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(57, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(58, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(59, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(60, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(61, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(62, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(63, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(64, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(65, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(66, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(67, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(68, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(69, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(70, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(71, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(72, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(73, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(74, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(75, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(76, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(77, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(78, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(79, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(80, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(81, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(82, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(83, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(84, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(85, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(86, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(87, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(88, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(89, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(90, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(91, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(92, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(93, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(94, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(95, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(96, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(97, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(98, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03'),
(99, 'andres.arvelaez@gmail.com', 'andres', 'arvelaez', '2023-01-03');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
