-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2022 at 05:48 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbfutsal`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbmember`
--

CREATE TABLE `tbmember` (
  `id` int(11) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `no_ktp` varchar(16) NOT NULL,
  `no_hp` varchar(12) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `kode_anggota` varchar(4) NOT NULL,
  `tgl_daftar` date NOT NULL,
  `biaya` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbpenyewaan`
--

CREATE TABLE `tbpenyewaan` (
  `id` int(11) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tgl_sewa` date NOT NULL,
  `lama_sewa` int(2) NOT NULL,
  `kode_lapangan` varchar(4) NOT NULL,
  `biaya` int(7) NOT NULL,
  `status` varchar(10) NOT NULL,
  `jam_sewa` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbmember`
--
ALTER TABLE `tbmember`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbpenyewaan`
--
ALTER TABLE `tbpenyewaan`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbmember`
--
ALTER TABLE `tbmember`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbpenyewaan`
--
ALTER TABLE `tbpenyewaan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
