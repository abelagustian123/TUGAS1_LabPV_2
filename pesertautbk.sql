-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2022 at 04:15 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pesertautbk`
--

-- --------------------------------------------------------

--
-- Table structure for table `pesertautbk`
--

CREATE TABLE `pesertautbk` (
  `nomor_peserta` int(12) NOT NULL,
  `nama_peserta` varchar(50) NOT NULL,
  `tanggal_lahir` varchar(50) NOT NULL,
  `nisn` int(10) NOT NULL,
  `universitas1` varchar(50) NOT NULL,
  `pil1` varchar(50) NOT NULL,
  `universitas2` varchar(50) NOT NULL,
  `pil2` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pesertautbk`
--

INSERT INTO `pesertautbk` (`nomor_peserta`, `nama_peserta`, `tanggal_lahir`, `nisn`, `universitas1`, `pil1`, `universitas2`, `pil2`) VALUES
(201401031, 'Abel Agustian', '10 Agustus ', 31401201, 'UI', 'ILKOM', 'ITB', 'STEI'),
(201401032, 'Megawati', '1 Januari', 31401201, 'USU', 'Ekonomi', 'UNIMED', 'PGSD'),
(201401033, 'SUHARTO', '25 Februari', 31401201, 'ITENAS', 'Arsitek', 'GUNADARMA', 'Teknik Sipil'),
(201401035, 'Jokowi', '25 Agustus ', 31401201, 'UGM', 'Kehutanan', 'UGM', 'Ilmu Komputer'),
(201401039, 'Rocky Gerung', '25 Agustus ', 31401201, 'UI', 'Filsafat', 'UI', 'Teknik Fisika');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pesertautbk`
--
ALTER TABLE `pesertautbk`
  ADD PRIMARY KEY (`nomor_peserta`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pesertautbk`
--
ALTER TABLE `pesertautbk`
  MODIFY `nomor_peserta` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=201401040;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
