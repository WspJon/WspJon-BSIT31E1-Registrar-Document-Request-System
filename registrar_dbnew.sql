-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 26, 2026 at 03:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `registrar_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbldocuments`
--

CREATE TABLE `tbldocuments` (
  `DocumentID` int(11) NOT NULL,
  `DocumentName` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Fee` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbldocuments`
--

INSERT INTO `tbldocuments` (`DocumentID`, `DocumentName`, `Description`, `Fee`, `Status`) VALUES
(1, 'Transcript of Records', 'Official record of grades and courses taken', 150.00, 'Active'),
(2, 'Certificate of Enrollment', 'Proof that the student is currently enrolled', 50.00, 'Active'),
(3, 'Certificate of Good Moral', 'Certifies good conduct while enrolled in the school', 100.00, 'Active'),
(4, 'Certification', 'General certification issued by the registrar', 50.00, 'Active'),
(5, 'Honorable Dismissal', 'Document for transfer to another institution', 100.00, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblrequest`
--

CREATE TABLE `tblrequest` (
  `RequestID` int(11) NOT NULL,
  `RequestNo` varchar(30) NOT NULL,
  `StudentID` varchar(20) NOT NULL,
  `TotalAmount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `PaymentStatus` varchar(20) NOT NULL DEFAULT 'Unpaid',
  `Status` varchar(30) NOT NULL DEFAULT 'Pending',
  `RequestDate` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblrequest`
--

INSERT INTO `tblrequest` (`RequestID`, `RequestNo`, `StudentID`, `TotalAmount`, `PaymentStatus`, `Status`, `RequestDate`, `CreatedBy`) VALUES
(1, 'REQ-2026-00001', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:12:27', '3'),
(2, 'REQ-2026-00002', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:13:47', '3'),
(3, 'REQ-2026-00003', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:14:09', '3'),
(4, 'REQ-2026-00004', '2024-00101', 150.00, 'Paid', 'Approved', '2026-09-26 09:15:00', '3'),
(5, 'REQ-2026-00005', '2024-00102', 300.00, 'Unpaid', 'Pending', '2026-09-26 09:16:00', '3'),
(6, 'REQ-2026-00006', '2024-00103', 150.00, 'Paid', 'Completed', '2026-09-26 09:17:00', '3'),
(7, 'REQ-2026-00007', '2024-00104', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:18:00', '3'),
(8, 'REQ-2026-00008', '2023-00105', 450.00, 'Paid', 'Approved', '2026-09-26 09:19:00', '3'),
(9, 'REQ-2026-00009', '2023-00106', 300.00, 'Paid', 'Completed', '2026-09-26 09:20:00', '3'),
(10, 'REQ-2026-00010', '2023-00107', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:21:00', '3'),
(11, 'REQ-2026-00011', '2023-00108', 300.00, 'Paid', 'Approved', '2026-09-26 09:22:00', '3'),
(12, 'REQ-2026-00012', '2022-00109', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:23:00', '3'),
(13, 'REQ-2026-00013', '2022-00110', 150.00, 'Paid', 'Completed', '2026-09-26 09:24:00', '3'),
(14, 'REQ-2026-00014', '2022-00111', 450.00, 'Paid', 'Approved', '2026-09-26 09:25:00', '3'),
(15, 'REQ-2026-00015', '2022-00112', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:26:00', '3'),
(16, 'REQ-2026-00016', '2021-00113', 300.00, 'Paid', 'Completed', '2026-09-26 09:27:00', '3'),
(17, 'REQ-2026-00017', '2021-00114', 450.00, 'Paid', 'Approved', '2026-09-26 09:28:00', '3'),
(18, 'REQ-2026-00018', '2021-00115', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:29:00', '3'),
(19, 'REQ-2026-00019', '2021-00116', 150.00, 'Paid', 'Completed', '2026-09-26 09:30:00', '3'),
(20, 'REQ-2026-00020', '2024-00117', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:31:00', '3'),
(21, 'REQ-2026-00021', '2023-00118', 300.00, 'Paid', 'Approved', '2026-09-26 09:32:00', '3'),
(22, 'REQ-2026-00022', '2022-00119', 300.00, 'Paid', 'Completed', '2026-09-26 09:33:00', '3'),
(23, 'REQ-2026-00023', '2021-00120', 450.00, 'Unpaid', 'Pending', '2026-09-26 09:34:00', '3'),
(24, 'REQ-2026-00024', '2021-00114', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:33:33', '3'),
(25, 'REQ-2026-00025', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:34:19', '3'),
(26, 'REQ-2026-00026', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:34:48', '3'),
(27, 'REQ-2026-00027', '1395-24', 150.00, 'Unpaid', 'Pending', '2026-09-26 09:40:49', '3');

-- --------------------------------------------------------

--
-- Table structure for table `tblrequestdetails`
--

CREATE TABLE `tblrequestdetails` (
  `RequestDetailID` int(11) NOT NULL,
  `RequestID` int(11) NOT NULL,
  `DocumentID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 1,
  `Subtotal` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Amount` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblrequestdetails`
--

INSERT INTO `tblrequestdetails` (`RequestDetailID`, `RequestID`, `DocumentID`, `Quantity`, `Subtotal`, `Amount`) VALUES
(1, 2, 1, 1, 150.00, 150),
(2, 3, 1, 0, 0.00, 150),
(23, 4, 1, 1, 150.00, 150),
(24, 5, 1, 2, 300.00, 150),
(25, 6, 1, 1, 150.00, 150),
(26, 7, 1, 1, 150.00, 150),
(27, 8, 1, 3, 450.00, 150),
(28, 9, 1, 2, 300.00, 150),
(29, 10, 1, 1, 150.00, 150),
(30, 11, 1, 2, 300.00, 150),
(31, 12, 1, 1, 150.00, 150),
(32, 13, 1, 1, 150.00, 150),
(33, 14, 1, 3, 450.00, 150),
(34, 15, 1, 1, 150.00, 150),
(35, 16, 1, 2, 300.00, 150),
(36, 17, 1, 3, 450.00, 150),
(37, 18, 1, 1, 150.00, 150),
(38, 19, 1, 1, 150.00, 150),
(39, 20, 1, 1, 150.00, 150),
(40, 21, 1, 2, 300.00, 150),
(41, 22, 1, 2, 300.00, 150),
(42, 23, 1, 3, 450.00, 150),
(43, 24, 1, 1, 150.00, 150),
(44, 25, 1, 0, 0.00, 150),
(45, 26, 1, -1, -150.00, 150),
(46, 27, 1, 1, 150.00, 150);

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `StudentID` varchar(20) NOT NULL,
  `LRN` varchar(20) DEFAULT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `Course` varchar(50) NOT NULL,
  `YearLevel` varchar(5) NOT NULL,
  `Section` varchar(20) DEFAULT NULL,
  `ContactNo` varchar(20) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`StudentID`, `LRN`, `FirstName`, `LastName`, `MiddleName`, `Course`, `YearLevel`, `Section`, `ContactNo`, `Status`) VALUES
('1395-24', '123123123', 'Sophia Cassandra', 'Villacorte', 'Solis', 'BSIT', '3', '31E1', '09123131231', 'Active'),
('2021-00001', '133445566778', 'Michael', 'Santiago', 'Domingo', 'BSIT', '4', '4A', '09281230013', 'Active'),
('2021-00002', '133445566779', 'Nicole', 'Navarro', 'Castro', 'BSIT', '4', '4A', '09291230014', 'Active'),
('2021-00003', '133445566780', 'Oliver', 'De Leon', 'Gutierrez', 'BSCS', '4', '4B', '09301230015', 'Active'),
('2021-00004', '133445566781', 'Patricia', 'Salazar', 'Rivera', 'BSCS', '4', '4B', '09311230016', 'Active'),
('2021-00005', '133445566782', 'Trisha', 'Roxas', 'Tan', 'BSIT', '4', '4B', '09351230020', 'Active'),
('2021-00113', '501234567813', 'Marco', 'Galang', 'Estrella', 'BSIT', '4', '4A', '09451110013', 'Active'),
('2021-00114', '501234567814', 'Nadine', 'Miranda', 'Cabrera', 'BSIT', '4', '4B', '09451110014', 'Active'),
('2021-00115', '501234567815', 'Owen', 'Pascua', 'Legaspi', 'BSCS', '4', '4A', '09451110015', 'Active'),
('2021-00116', '501234567816', 'Pia', 'Fajardo', NULL, 'BSCS', '4', '4B', '09451110016', 'Active'),
('2021-00120', '501234567820', 'Vanessa', 'Zapata', 'Coronel', 'BSIT', '4', '4C', '09451110020', 'Active'),
('2022-00001', '112233445566', 'Ivan', 'Villanueva', 'Mercado', 'BSIT', '3', '3A', '09241230009', 'Active'),
('2022-00002', '112233445567', 'Julia', 'Cruz', 'Diaz', 'BSIT', '3', '3A', '09251230010', 'Active'),
('2022-00003', '112233445568', 'Kevin', 'Alvarez', 'Soriano', 'BSIT', '3', '31E1', '09261230011', 'Active'),
('2022-00004', '112233445569', 'Lara', 'Valdez', NULL, 'BSCS', '3', '3B', '09271230012', 'Active'),
('2022-00005', '112233445570', 'Samuel', 'Mendoza', NULL, 'BSCS', '3', '3A', '09341230019', 'Active'),
('2022-00109', '501234567809', 'Ian', 'Magno', 'Ilagan', 'BSIT', '3', '3A', '09451110009', 'Active'),
('2022-00110', '501234567810', 'Janine', 'Pineda', 'Serrano', 'BSIT', '3', '3B', '09451110010', 'Active'),
('2022-00111', '501234567811', 'Kyle', 'Ocampo', NULL, 'BSIT', '3', '31E1', '09451110011', 'Active'),
('2022-00112', '501234567812', 'Lianne', 'Cordova', 'Morales', 'BSCS', '3', '3A', '09451110012', 'Active'),
('2022-00119', '501234567819', 'Timothy', 'Solis', 'Arce', 'BSCS', '3', '3B', '09451110019', 'Active'),
('2023-00001', '123456789012', 'Juan', 'Dela Cruz', 'Santos', 'BSIT', '3', 'A', '09171234567', 'Active'),
('2023-00002', '123456789013', 'Maria', 'Clara', 'De Los Santos', 'BSIT', '3', 'A', '09179876543', 'Active'),
('2023-00003', '123456789014', 'Mark', 'Bautista', NULL, 'BSCS', '2', 'B', '09181112222', 'Active'),
('2023-00004', '123456789015', 'Ethan', 'Gonzales', 'Perez', 'BSIT', '2', '2A', '09201230005', 'Active'),
('2023-00005', '123456789016', 'Fiona', 'Bautista', 'Lopez', 'BSIT', '2', '2A', '09211230006', 'Active'),
('2023-00006', '123456789017', 'Gabriel', 'Castillo', NULL, 'BSCS', '2', '2B', '09221230007', 'Active'),
('2023-00007', '123456789018', 'Hannah', 'Aquino', 'Morales', 'BSCS', '2', '2B', '09231230008', 'Active'),
('2023-00008', '123456789019', 'Rochelle', 'Tolentino', 'Fernandez', 'BSIT', '2', '2C', '09331230018', 'Active'),
('2023-00105', '501234567805', 'Enrique', 'Salvador', 'Guevarra', 'BSIT', '2', '2A', '09451110005', 'Active'),
('2023-00106', '501234567806', 'Francine', 'Macaraeg', 'David', 'BSIT', '2', '2B', '09451110006', 'Active'),
('2023-00107', '501234567807', 'Gerald', 'Samson', 'Velasco', 'BSCS', '2', '2A', '09451110007', 'Active'),
('2023-00108', '501234567808', 'Hazel', 'Evangelista', 'Valdez', 'BSCS', '2', '2B', '09451110008', 'Active'),
('2023-00118', '501234567818', 'Stephanie', 'Abad', 'Robles', 'BSIT', '2', '2C', '09451110018', 'Active'),
('2024-00001', '109876543210', 'Angelo', 'Mendoza', 'Ramos', 'BSIT', '1', '1A', '09171230001', 'Active'),
('2024-00002', '109876543211', 'Bea', 'Santos', 'Garcia', 'BSIT', '1', '1A', '09171230002', 'Active'),
('2024-00003', '109876543212', 'Christian', 'Reyes', 'Torres', 'BSCS', '1', '1B', '09181230003', 'Active'),
('2024-00004', '109876543213', 'Danielle', 'Flores', 'Navarro', 'BSCS', '1', '1B', '09191230004', 'Active'),
('2024-00005', '109876543214', 'Quentin', 'Pascual', 'Manalo', 'BSIT', '1', '1C', '09321230017', 'Active'),
('2024-00101', '501234567801', 'Aaron', 'Del Rosario', 'Cruz', 'BSIT', '1', '1A', '09451110001', 'Active'),
('2024-00102', '501234567802', 'Bianca', 'Soriano', 'Lim', 'BSIT', '1', '1B', '09451110002', 'Active'),
('2024-00103', '501234567803', 'Carlo', 'Villanueva', 'Padilla', 'BSCS', '1', '1A', '09451110003', 'Active'),
('2024-00104', '501234567804', 'Daphne', 'Bernardo', NULL, 'BSCS', '1', '1B', '09451110004', 'Active'),
('2024-00117', '501234567817', 'Rafael', 'Gomez', 'Quinto', 'BSIT', '1', '1C', '09451110017', 'Active'),
('2194-24', '110403', 'shouno', 'sabesaje', 'constatino', 'BSIT', '3', 'bsit31e1', '09465372799', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(64) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Role` varchar(20) NOT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `Username`, `Password`, `FullName`, `Role`, `Status`) VALUES
(1, 'ShoIcheeze', 'password123', 'Sho Uno Sabesaje', 'Registrar Staff', 'Active'),
(2, 'JReales', 'password123', 'Jonnidel Reales', 'Administrator', 'Active'),
(3, 'Jcris', 'password123', 'Jancris Tiu', 'Registrar Staff', 'Active'),
(4, 'JVillacorte', 'password123', 'Joshua Villacorte', 'Registrar Staff', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbldocuments`
--
ALTER TABLE `tbldocuments`
  ADD PRIMARY KEY (`DocumentID`);

--
-- Indexes for table `tblrequest`
--
ALTER TABLE `tblrequest`
  ADD PRIMARY KEY (`RequestID`),
  ADD UNIQUE KEY `RequestNo` (`RequestNo`),
  ADD KEY `fk_request_student` (`StudentID`);

--
-- Indexes for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  ADD PRIMARY KEY (`RequestDetailID`),
  ADD KEY `fk_detail_request` (`RequestID`),
  ADD KEY `fk_detail_document` (`DocumentID`);

--
-- Indexes for table `tblstudents`
--
ALTER TABLE `tblstudents`
  ADD PRIMARY KEY (`StudentID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbldocuments`
--
ALTER TABLE `tbldocuments`
  MODIFY `DocumentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblrequest`
--
ALTER TABLE `tblrequest`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  MODIFY `RequestDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblrequest`
--
ALTER TABLE `tblrequest`
  ADD CONSTRAINT `fk_request_student` FOREIGN KEY (`StudentID`) REFERENCES `tblstudents` (`StudentID`);

--
-- Constraints for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  ADD CONSTRAINT `fk_detail_document` FOREIGN KEY (`DocumentID`) REFERENCES `tbldocuments` (`DocumentID`),
  ADD CONSTRAINT `fk_detail_request` FOREIGN KEY (`RequestID`) REFERENCES `tblrequest` (`RequestID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
