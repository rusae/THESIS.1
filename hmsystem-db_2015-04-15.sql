-- phpMyAdmin SQL Dump
-- version 4.3.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 15, 2015 at 04:40 AM
-- Server version: 5.5.42
-- PHP Version: 5.4.39

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";
USE hmsystem;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hmsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `check in`
--

CREATE TABLE `check in` (
  `Gfirstname` varchar(50) NOT NULL,
  `Glastname` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `contact info` varchar(20) NOT NULL,
  `id type` varchar(50) NOT NULL,
  `id number` varchar(20) NOT NULL,
  `vehicle type` varchar(20) NOT NULL,
  `vehicle color` varchar(20) NOT NULL,
  `plate no.` varchar(10) NOT NULL,
  `room type` varchar(50) NOT NULL,
  `room no` varchar(5) NOT NULL,
  `check in date` date NOT NULL,
  `check out date` date NOT NULL,
  `total time` varchar(20) NOT NULL,
  `sub total` varchar(20) NOT NULL,
  `discount` varchar(20) NOT NULL,
  `amount paid` varchar(20) NOT NULL,
  `balance` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `uid` int(11) NOT NULL,
  `username` varchar(60) NOT NULL,
  `name` varchar(60) NOT NULL,
  `password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
