-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2022 at 07:38 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `adpbank`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `info_id` int(11) NOT NULL,
  `creation` datetime NOT NULL DEFAULT current_timestamp(),
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`, `type`, `info_id`, `creation`, `active`) VALUES
(1, 'admin', '12345678', 'Admin', 1, '2022-11-29 20:24:26', 1),
(2, 'clerk', '12345678', 'Clerk', 2, '2022-12-04 22:39:17', 1),
(3, 'teller', '12345678', 'Teller', 3, '2022-12-05 13:39:12', 1);

-- --------------------------------------------------------

--
-- Table structure for table `accounts_client`
--

CREATE TABLE `accounts_client` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `client_info` int(11) NOT NULL,
  `total_amount` double NOT NULL,
  `account_number` varchar(100) NOT NULL,
  `creation` datetime NOT NULL DEFAULT current_timestamp(),
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts_client`
--

INSERT INTO `accounts_client` (`id`, `username`, `password`, `client_info`, `total_amount`, `account_number`, `creation`, `active`) VALUES
(1, 'gene', '12345678', 1, 4900, 'CLNT-CI9P9L52', '2022-12-04 21:27:13', 1),
(2, 'jerrald', '12345678', 2, 5000, 'CLNT-QRIVNC8B', '2022-12-05 11:33:21', 1),
(3, 'liam', '12345678', 3, 3000, 'CLNT-LKELYUM1', '2022-12-05 11:33:43', 1),
(4, 'erica', '12345678', 4, 5000, 'CLNT-3CBCXYMF', '2022-12-05 11:33:58', 1),
(5, 'ronald', '12345678', 5, 5000, 'CLNT-DE4QQB9U', '2022-12-05 12:53:56', 1);

-- --------------------------------------------------------

--
-- Table structure for table `info_client`
--

CREATE TABLE `info_client` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `birthdate` varchar(100) NOT NULL,
  `occupation` varchar(255) NOT NULL,
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `info_client`
--

INSERT INTO `info_client` (`id`, `first_name`, `last_name`, `contact`, `email`, `address`, `birthdate`, `occupation`, `active`) VALUES
(1, 'Gene', 'Hilario', '09280123902', 'hilariooo@gmail.com', 'Makati', '02/01/1980', 'Auditor', 1),
(2, 'Jerrald', 'Otogan', '09435902344', 'jotogan@gmail.com', 'Mandaluyong', '03/20/1995', 'Teaching Assistant', 1),
(3, 'Liam', 'Recio', '09880234582', 'recioliam@gmail.com', 'Pasig', '07/14/2001', 'Student', 1),
(4, 'Erica', 'Robin', '09990804675', 'ericaqt@gmail.com', 'Taguig', '09/20/1998', 'Nurse', 1),
(5, 'Ronald', 'Thomas', '09230453785', 'thomasron@gmail.com', 'Pateros', '12/05/1992', 'Software Consultant', 1);

-- --------------------------------------------------------

--
-- Table structure for table `info_employee`
--

CREATE TABLE `info_employee` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `birthdate` varchar(100) NOT NULL,
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `info_employee`
--

INSERT INTO `info_employee` (`id`, `first_name`, `last_name`, `contact`, `email`, `address`, `birthdate`, `active`) VALUES
(1, 'Adrian Don', 'Pagtakhan', '09290344647', 'pagtakhan83@gmail.com', 'Pateros', '05/19/2000', 1),
(2, 'Xavier', 'Froggo', '09835426715', 'xavier@gmail.com', 'Makati', '10/22/1994', 1),
(3, 'Zyrah Kae', 'Avila', '09684359451', 'avila.zyrah@gmail.com', 'Taguig', '07/08/2000', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id` int(11) NOT NULL,
  `transaction_type` varchar(100) NOT NULL,
  `client_id` int(11) NOT NULL,
  `og_amount` double NOT NULL,
  `tr_amount` double NOT NULL,
  `new_amount` double NOT NULL,
  `tr_dt` datetime NOT NULL DEFAULT current_timestamp(),
  `tr_id` varchar(100) NOT NULL,
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`id`, `transaction_type`, `client_id`, `og_amount`, `tr_amount`, `new_amount`, `tr_dt`, `tr_id`, `active`) VALUES
(1, 'Deposit', 1, 5000, 1000, 6000, '2022-12-05 12:24:58', 'DP1-B2QA3P0Q', 1),
(2, 'Withdraw', 1, 6000, 100, 5900, '2022-12-05 13:54:01', 'WD1-VPGU3ZXD', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transfer`
--

CREATE TABLE `transfer` (
  `id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `r_acc` varchar(100) NOT NULL,
  `amount` double NOT NULL,
  `tf_dt` datetime NOT NULL DEFAULT current_timestamp(),
  `tf_id` varchar(100) NOT NULL,
  `active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `emp_info` (`info_id`);

--
-- Indexes for table `accounts_client`
--
ALTER TABLE `accounts_client`
  ADD PRIMARY KEY (`id`),
  ADD KEY `info_client` (`client_info`);

--
-- Indexes for table `info_client`
--
ALTER TABLE `info_client`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `info_employee`
--
ALTER TABLE `info_employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id`),
  ADD KEY `client` (`client_id`);

--
-- Indexes for table `transfer`
--
ALTER TABLE `transfer`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tf_from` (`client_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `accounts_client`
--
ALTER TABLE `accounts_client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `info_client`
--
ALTER TABLE `info_client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `info_employee`
--
ALTER TABLE `info_employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `transfer`
--
ALTER TABLE `transfer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accounts`
--
ALTER TABLE `accounts`
  ADD CONSTRAINT `emp_info` FOREIGN KEY (`info_id`) REFERENCES `info_employee` (`id`);

--
-- Constraints for table `accounts_client`
--
ALTER TABLE `accounts_client`
  ADD CONSTRAINT `info_client` FOREIGN KEY (`client_info`) REFERENCES `info_client` (`id`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `client` FOREIGN KEY (`client_id`) REFERENCES `accounts_client` (`id`);

--
-- Constraints for table `transfer`
--
ALTER TABLE `transfer`
  ADD CONSTRAINT `tf_from` FOREIGN KEY (`client_id`) REFERENCES `accounts_client` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
