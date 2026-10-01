-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 01, 2026 at 09:05 AM
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
-- Database: `registrar_dbnew`
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
  `DateProcessed` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `ProcessedBy` int(11) DEFAULT NULL,
  `ORNo` varchar(50) DEFAULT NULL,
  `ORDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblrequest`
--

INSERT INTO `tblrequest` (`RequestID`, `RequestNo`, `StudentID`, `TotalAmount`, `PaymentStatus`, `Status`, `RequestDate`, `DateProcessed`, `CreatedBy`, `ProcessedBy`, `ORNo`, `ORDate`) VALUES
(30, 'REQ-2026-00001', '1023-26', 150.00, 'Paid', 'Processing', '2026-10-01 14:06:42', '2026-10-01 14:54:21', '3', 3, '1104-26', '2026-10-01'),
(31, 'REQ-2026-00002', '2194-26', 150.00, 'Paid', 'Ready for Release', '2026-10-01 14:22:22', NULL, '2', NULL, '2111-26', '2026-10-01');

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
(49, 30, 1, 1, 150.00, 150),
(50, 31, 1, 1, 150.00, 150);

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
('1023-26', '987654321098', 'Maria Clara', 'Santos', 'Reyes', 'CTHM', '2', 'A2', '09171234567', 'Active'),
('1187-26', '741852963074', 'Samantha', 'Flores', 'Castro', 'BSIT', '2', 'A2', '09885556666', 'Active'),
('2194-26', '123456789012', 'Juan', 'Dela Cruz', 'Santos', 'BSIT', '1', 'A1', '09948118996', 'Active'),
('3319-26', '789123456078', 'Angela', 'Mendoza', 'Cruz', 'BSIT', '4', 'A4', '09223334444', 'Active'),
('4582-26', '456789123045', 'Mark', 'Bautista', 'Aquino', 'BSCRIM', '3', 'A3', '09189876543', 'Active'),
('5230-26', '357951486035', 'Bea', 'Alvarez', 'Navarro', 'CTHM', '4', 'A4', '09661112222', 'Active'),
('6405-26', '654987321065', 'Patricia', 'Garcia', 'Dizon', 'BSCRIM', '2', 'A2', '09477778888', 'Active'),
('7192-26', '159753486015', 'Christian', 'Gonzales', 'Torres', 'BSIT', '3', 'A3', '09569990000', 'Active'),
('8821-26', '321654987032', 'John Paul', 'Reyes', 'Garcia', 'CTHM', '1', 'A1', '09355556666', 'Active'),
('9041-26', '852963741085', 'Gabriel', 'Ramos', 'Roxas', 'BSCRIM', '1', 'A1', '09773334444', 'Active');

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
  `CourseAssigned` varchar(50) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `Username`, `Password`, `FullName`, `Role`, `CourseAssigned`, `Status`) VALUES
(1, 'admin', 'admin123', 'Jonnidel Reales', 'Administrator', NULL, 'Active'),
(2, 'staff_bsit', 'staff_bsit123', 'Sho Uno Sabesaje', 'Registrar Staff', 'BSIT', 'Active'),
(3, 'staff_cthm', 'staff_cthm123', 'Jancris Tiu', 'Registrar Staff', 'CTHM', 'Active'),
(4, 'staff_bscrim', 'staff_bscrim123', 'Joshua Vilacorte', 'Registrar Staff', 'BSCRIM', 'Active');

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
  ADD KEY `fk_request_student` (`StudentID`),
  ADD KEY `fk_processed_by` (`ProcessedBy`);

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
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  MODIFY `RequestDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

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
  ADD CONSTRAINT `fk_processed_by` FOREIGN KEY (`ProcessedBy`) REFERENCES `tblusers` (`UserID`),
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
