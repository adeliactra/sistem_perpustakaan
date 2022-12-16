-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2022 at 01:30 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `koleksi`
--

CREATE TABLE `koleksi` (
  `Id_koleksi` int(10) UNSIGNED NOT NULL,
  `nama_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `dir_gambar` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `penerbit` varchar(255) NOT NULL DEFAULT '0',
  `jenis_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `tahun_terbit` year(4) NOT NULL,
  `lokasi` varchar(255) NOT NULL DEFAULT '0',
  `tanggal_masuk_koleksi` date NOT NULL,
  `stock` int(11) NOT NULL DEFAULT 0,
  `bahasa` varchar(50) NOT NULL DEFAULT '0',
  `kategori` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `koleksi`
--

INSERT INTO `koleksi` (`Id_koleksi`, `nama_koleksi`, `dir_gambar`, `deskripsi`, `penerbit`, `jenis_koleksi`, `tahun_terbit`, `lokasi`, `tanggal_masuk_koleksi`, `stock`, `bahasa`, `kategori`) VALUES
(2, 'nama', 'C:/Users/Adrian Pratama/Pictures/Acer/Acer_Wallpaper_01_5000x2814.jpg', 'desc', 'penerbit', 'Koran', 2022, 'lokasi', '2022-12-07', 12, 'Indonesia', 'Sosial|');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `registered_at` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `username`, `password`, `registered_at`) VALUES
(1, 'admin', '81dc9bdb52d04dc20036dbd8313ed055', '2022-12-12'),
(2, 'adel', '0f8fcbb2f5230dc17f124c31311c09e8', '2022-12-12');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `koleksi`
--
ALTER TABLE `koleksi`
  ADD PRIMARY KEY (`Id_koleksi`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `koleksi`
--
ALTER TABLE `koleksi`
  MODIFY `Id_koleksi` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
