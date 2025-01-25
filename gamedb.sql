-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 25-01-2025 a las 01:30:30
-- Versión del servidor: 8.2.0
-- Versión de PHP: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gamedb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `scores`
--

DROP TABLE IF EXISTS `scores`;
CREATE TABLE IF NOT EXISTS `scores` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `PlayerName` varchar(50) NOT NULL,
  `Score` int NOT NULL,
  `Timestamp` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `scores`
--

INSERT INTO `scores` (`Id`, `PlayerName`, `Score`, `Timestamp`) VALUES
(1, 'Player1', 100, '2025-01-24 17:03:13'),
(11, 'Carlos', 10, '2025-01-24 18:48:31'),
(12, 'Marta', 10, '2025-01-24 18:50:04'),
(13, 'Ana', 40, '2025-01-24 19:02:37'),
(14, 'May', 20, '2025-01-24 19:36:54'),
(15, 'Fernanda', 80, '2025-01-24 19:38:44'),
(10, 'Mayury', 90, '2025-01-24 18:40:10');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
