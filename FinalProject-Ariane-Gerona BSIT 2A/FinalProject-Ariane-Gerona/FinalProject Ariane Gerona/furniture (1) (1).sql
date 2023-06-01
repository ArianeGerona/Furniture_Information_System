-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 01, 2023 at 10:28 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `furniture`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `Admin Account ID` int(11) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Token` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`Admin Account ID`, `Username`, `Password`, `Token`) VALUES
(1, 'shiela', 'oraiz', '');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `Category ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`Category ID`, `Name`, `Description`) VALUES
(1, 'SOFA', 'Wooden'),
(2, 'BED', 'Wooden'),
(3, 'CABINET', 'Wooden'),
(4, 'TABLE', 'Wooden'),
(5, 'CHAIR', 'Wooden');

-- --------------------------------------------------------

--
-- Table structure for table `customer_info`
--

CREATE TABLE `customer_info` (
  `Customer ID` int(11) NOT NULL,
  `Customer Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Phone Number` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_info`
--

INSERT INTO `customer_info` (`Customer ID`, `Customer Name`, `Address`, `Phone Number`) VALUES
(1, 'Pacita Almine', 'Mercedes Silago', '09786545678'),
(2, 'Ariane', 'Tubod', '09746745664'),
(4, 'Grace Almosa', 'Tubod', '07473467662'),
(6, 'Ariane', 'Tubod', '09079339596'),
(7, 'Ariane', 'Tubod', '09079339596'),
(8, 'Celjane', 'Minoyho', '098765432'),
(9, 'Jomari', 'Basak', '09785634'),
(10, 'aeriane', 'gdsdusuus', '7694739'),
(11, 'dhdjdjd', 'sjdjshd', '6584397377'),
(12, 'Emannuel', 'Tabonan', '64389462384694');

-- --------------------------------------------------------

--
-- Table structure for table `furniture_available`
--

CREATE TABLE `furniture_available` (
  `Furniture ID` int(11) NOT NULL,
  `Category ID` int(11) NOT NULL,
  `Furniture Name` varchar(50) NOT NULL,
  `Price` double NOT NULL,
  `Wood Type Materials` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `furniture_available`
--

INSERT INTO `furniture_available` (`Furniture ID`, `Category ID`, `Furniture Name`, `Price`, `Wood Type Materials`) VALUES
(11, 1, 'Walker Edison Furniture Company Rustic Farmhouse W', 8999, 'Mahagony Wood'),
(22, 1, 'Christopher Knight Home Phinnaeus Fabric and Acaci', 9899, 'Acacia Wood'),
(33, 1, 'Simpli Home Acadian Solid Wood Sofa', 7666, 'Solid Wood'),
(44, 1, 'Rivet Sloane Mid-Century Modern Sofa with Tufted B', 10999, 'Oak Wood'),
(55, 1, 'Armen Living Javeline Mid-Century Modern Sofa in D', 10899, 'Walnut Wood'),
(111, 2, 'Zinus Suzanne Canopy Platform Bed', 11000, 'Oak Wood'),
(123, 3, 'Simpli Home Bedford Storage Cabinet', 10999, 'Oak Wood'),
(124, 3, 'Bush Furniture Cabot Tall Storage Cabinet with Doo', 16999, 'Oak Wood'),
(125, 3, 'Bush Furniture Salinas Accent Storage Cabinet with', 17999, 'Acacia Wood'),
(126, 3, 'Prepac Elite 32 Stackable Wall Cabinet', 15899, 'Brich Wood'),
(127, 3, 'WE Furniture Modern Farmhouse Buffet Entryway Bar ', 18799, 'Acacia Wood'),
(222, 2, 'Walker Edison Furniture Company Plank Metal Queen ', 19899, 'Birch Wood'),
(333, 2, 'Rivet Whit Contemporary Wood Platform Bed', 7666, 'Mahagony Wood'),
(444, 2, 'Modus Furniture Company Solid Wood Platform Bed', 11899, 'Solid Wood'),
(555, 2, 'WE Furniture Modern Farmhouse Wood Platform Bed', 10899, 'Oak Wood'),
(6473, 5, 'Ashley Furniture Signature Design-Haddigan Dining ', 11000, 'Mahagony Wood'),
(6474, 5, 'WE Furniture Rustic Farmhouse Wood Dining Chair', 12000, 'Oak Wood'),
(6475, 5, 'Poly and Bark Weave Modern Wooden Mid-Century Dini', 10000, 'Acacia Wood'),
(6476, 5, 'Modway Gear  rustic Farmhouse Elm Wood Rattan Dini', 13899, 'Rattan Wood'),
(6477, 5, 'Winsome Wood Windsor Chair in Natural and White Fi', 10999, 'Mahogany Wood'),
(8550, 4, 'Winsome Wood Groveland Dining Table', 9999, 'Mahogany Wood'),
(8560, 4, 'Zinus Becky Farmhouse Wood Dining Table', 9899, 'Brich Wood'),
(8570, 4, 'Rivet Industrial Hairpin Dining Table with Solid A', 10000, 'Acacia Wood'),
(8580, 4, 'WE Furniture Rustic Farmhouse Wood Dining Table', 8899, 'Oak Wood'),
(8590, 4, 'Ashley Furniture Signature Design-Bolanburg Dining', 7899, 'Brich Wood');

-- --------------------------------------------------------

--
-- Table structure for table `order_detail`
--

CREATE TABLE `order_detail` (
  `Order ID` int(11) NOT NULL,
  ` Customer ID` int(11) NOT NULL,
  `Furniture ID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `Sub-total` double NOT NULL,
  `Order_Date` timestamp NOT NULL DEFAULT current_timestamp(),
  `Status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_detail`
--

INSERT INTO `order_detail` (`Order ID`, ` Customer ID`, `Furniture ID`, `Quantity`, `Price`, `Sub-total`, `Order_Date`, `Status`) VALUES
(14, 8, 6474, 3, 12000, 36000, '2023-05-11 21:58:02', 'Unpaid'),
(15, 9, 126, 2, 15899, 31798, '2023-05-11 22:02:01', 'Unpaid'),
(16, 10, 11, 2, 120000, 240000, '2023-05-24 08:53:07', 'Paid'),
(17, 11, 44, 2, 10999, 21998, '2023-05-24 08:54:21', 'Unpaid'),
(18, 12, 333, 2, 7666, 15332, '2023-05-30 07:34:28', 'Unpaid');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`Admin Account ID`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`Category ID`);

--
-- Indexes for table `customer_info`
--
ALTER TABLE `customer_info`
  ADD PRIMARY KEY (`Customer ID`);

--
-- Indexes for table `furniture_available`
--
ALTER TABLE `furniture_available`
  ADD PRIMARY KEY (`Furniture ID`);

--
-- Indexes for table `order_detail`
--
ALTER TABLE `order_detail`
  ADD PRIMARY KEY (`Order ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `Admin Account ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `Category ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `customer_info`
--
ALTER TABLE `customer_info`
  MODIFY `Customer ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `furniture_available`
--
ALTER TABLE `furniture_available`
  MODIFY `Furniture ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8591;

--
-- AUTO_INCREMENT for table `order_detail`
--
ALTER TABLE `order_detail`
  MODIFY `Order ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
