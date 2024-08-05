-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2024 at 02:29 AM
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
-- Database: `rhudatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `administrators`
--

CREATE TABLE `administrators` (
  `ID` int(11) NOT NULL,
  `AdminID` varchar(20) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `administrators`
--

INSERT INTO `administrators` (`ID`, `AdminID`, `FirstName`, `LastName`, `Gender`, `Address`, `Username`, `Password`) VALUES
(1, 'ADMIN001', 'DIPPER', 'PINES', 'MALE', 'GRAVITY FALLS', 'ADMIN', 'ADMIN'),
(2, 'ADMIN002', 'SAM', 'SALES', 'MALE', 'CAUAYAN CITY', 'DOC SAM', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `clinic`
--

CREATE TABLE `clinic` (
  `ClinicID` int(11) NOT NULL,
  `ClinicName` varchar(255) NOT NULL,
  `AccessCode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctorrequestfiles`
--

CREATE TABLE `doctorrequestfiles` (
  `FileID` int(11) NOT NULL,
  `RequestID` int(11) DEFAULT NULL,
  `FileName` varchar(255) DEFAULT NULL,
  `FileContent` blob DEFAULT NULL,
  `UploadDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctorrequests`
--

CREATE TABLE `doctorrequests` (
  `RequestID` int(11) NOT NULL,
  `SenderDoctorID` varchar(50) DEFAULT NULL,
  `ReceiverDoctorID` varchar(50) DEFAULT NULL,
  `PatientID` varchar(50) DEFAULT NULL,
  `RequestMessage` text DEFAULT NULL,
  `RequestDate` datetime DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `ID` int(11) NOT NULL,
  `DoctorID` varchar(20) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Specialization` varchar(50) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Clinic` varchar(50) DEFAULT NULL,
  `AccessCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctorspecializations`
--

CREATE TABLE `doctorspecializations` (
  `ID` int(11) NOT NULL,
  `Specialization` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctorspecializations`
--

INSERT INTO `doctorspecializations` (`ID`, `Specialization`) VALUES
(8, 'Anesthesiologist'),
(2, 'Cardiologist'),
(3, 'Dermatologist'),
(1, 'General Practitioner'),
(7, 'Obstetrician-Gynecologist'),
(4, 'Pediatrician'),
(6, 'Psychiatrist'),
(5, 'Surgeon');

-- --------------------------------------------------------

--
-- Table structure for table `illnesses`
--

CREATE TABLE `illnesses` (
  `IllnessID` int(11) NOT NULL,
  `IllnessName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `illnesses`
--

INSERT INTO `illnesses` (`IllnessID`, `IllnessName`) VALUES
(6, 'Allergies'),
(19, 'Anxiety Disorders'),
(7, 'Asthma'),
(27, 'Cancer'),
(22, 'Chronic Bronchitis'),
(3, 'Common Cold'),
(24, 'COPD (Chronic Obstructive Pulmonary Disease)'),
(1, 'COVID 19'),
(18, 'Depression'),
(9, 'Diabetes'),
(11, 'GERD (Gastroesophageal Reflux Disease)'),
(25, 'Heart Disease'),
(10, 'Hyperlipidemia (High Cholesterol)'),
(8, 'Hypertension (High Blood Pressure)'),
(4, 'Influenza (Flu)'),
(20, 'Insomnia'),
(14, 'Kidney Stones'),
(17, 'Migraine'),
(21, 'Obesity'),
(15, 'Osteoarthritis'),
(12, 'Peptic Ulcer Disease'),
(23, 'Pneumonia'),
(16, 'Rheumatoid Arthritis'),
(5, 'Sinusitis'),
(26, 'Stroke'),
(13, 'Urinary Tract Infection (UTI)');

-- --------------------------------------------------------

--
-- Table structure for table `laboratories`
--

CREATE TABLE `laboratories` (
  `LaboratoryID` int(11) NOT NULL,
  `LaboratoryName` varchar(50) NOT NULL,
  `AccessCode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `laboratoryresults`
--

CREATE TABLE `laboratoryresults` (
  `LabResultID` int(11) NOT NULL,
  `PatientID` varchar(50) NOT NULL,
  `ResultDescription` text DEFAULT NULL,
  `LabResultImage` longblob DEFAULT NULL,
  `InChargePerson` text DEFAULT NULL,
  `RecordDate` datetime DEFAULT NULL,
  `LaboratoryName` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `laboratoryusers`
--

CREATE TABLE `laboratoryusers` (
  `LaboratoryUserID` int(11) NOT NULL,
  `FirstName` varchar(100) DEFAULT NULL,
  `LastName` varchar(100) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Position` varchar(50) NOT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Laboratory` varchar(50) NOT NULL,
  `AccessCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `maritalstatus`
--

CREATE TABLE `maritalstatus` (
  `ID` int(11) NOT NULL,
  `MaritalStatusName` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `maritalstatus`
--

INSERT INTO `maritalstatus` (`ID`, `MaritalStatusName`) VALUES
(2, 'MARRIED'),
(1, 'SINGLE'),
(3, 'WIDOWED');

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `MedicineID` int(11) NOT NULL,
  `MedicineName` varchar(255) DEFAULT NULL,
  `Dosage` varchar(50) DEFAULT NULL,
  `StockQuantity` int(11) DEFAULT NULL,
  `Category` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`MedicineID`, `MedicineName`, `Dosage`, `StockQuantity`, `Category`) VALUES
(1, 'PARACETAMOL', '200', 24, 'PAIN Relief'),
(2, 'PARACETAMOL', '500', 80, 'PAIN KILLER'),
(3, 'Amoxicillin', '250', 50, 'Antibiotic'),
(4, 'Lisinopril', '10', 64, 'Blood Pressure'),
(5, 'Atorvastatin', '20', 60, 'Cholesterol'),
(6, 'Metformin', '500', 80, 'Diabetes'),
(7, 'Omeprazole', '20', 50, 'Digestive'),
(8, 'Loratadine', '10', 80, 'Allergy'),
(9, 'Aspirin', '325', 89, 'Pain Relief'),
(10, 'Simvastatin', '40', 55, 'Cholesterol'),
(11, 'Ibuprofen', '200 ', 80, 'Pain Relief');

-- --------------------------------------------------------

--
-- Table structure for table `medicineout`
--

CREATE TABLE `medicineout` (
  `TransactionID` int(11) NOT NULL,
  `TransactionDate` datetime DEFAULT NULL,
  `PatientID` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `medicineoutdetails`
--

CREATE TABLE `medicineoutdetails` (
  `TransactionID` int(11) DEFAULT NULL,
  `MedicineID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `nurses`
--

CREATE TABLE `nurses` (
  `ID` int(11) NOT NULL,
  `NurseID` varchar(20) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Specialization` varchar(50) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Clinic` varchar(50) DEFAULT NULL,
  `AccessCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `nursespecializations`
--

CREATE TABLE `nursespecializations` (
  `ID` int(11) NOT NULL,
  `Specialization` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `ID` int(11) NOT NULL,
  `PatientID` varchar(20) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `MaritalStatus` varchar(20) DEFAULT NULL,
  `Citizenship` varchar(50) DEFAULT NULL,
  `Religion` varchar(50) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `PhilhealthID` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`ID`, `PatientID`, `FirstName`, `MiddleName`, `LastName`, `Gender`, `DOB`, `Age`, `MaritalStatus`, `Citizenship`, `Religion`, `Address`, `ContactNumber`, `PhilhealthID`) VALUES
(1, 'Patient0001', 'BENEDICT', 'S', 'RAMIREZ', 'MALE', '2000-02-14', 23, 'MARRIED', 'FILIPINO', 'RC', '49 PILAR ST CAUAYAN CITY', '90909890', '78696967'),
(2, 'Patient0002', 'JOHN', 'D', 'DOE', 'MALE', '1995-08-23', 29, 'SINGLE', 'AMERICAN', 'CHRISTIAN', '123 MAIN ST ANYTOWN', '5551234567', '98765432'),
(3, 'Patient0003', 'JANE', 'M', 'SMITH', 'FEMALE', '1980-05-10', 44, 'MARRIED', 'CANADIAN', 'PROTESTANT', '567 MAPLE AVE CITYVILLE', '9998765432', '12345678'),
(4, 'Patient0004', 'ALICE', 'A', 'WONG', 'FEMALE', '1999-11-30', 24, 'SINGLE', 'CHINESE', 'BUDDHIST', '789 CHERRY RD TOWNCITY', '3334445555', '87654321'),
(5, 'Patient0005', 'MICHAEL', 'J', 'JACKSON', 'MALE', '1970-12-25', 53, 'DIVORCED', 'BRITISH', 'OTHER', '456 OXFORD ST LONDON', '7778889999', '65432187'),
(6, 'Patient0006', 'MARIA', 'C', 'GARCIA', 'FEMALE', '1985-03-18', 39, 'WIDOWED', 'SPANISH', 'CATHOLIC', '321 MADRID AVE MADRID', '1112223333', '45678901'),
(7, 'Patient0007', 'DAVID', 'L', 'LEE', 'MALE', '1975-07-12', 48, 'MARRIED', 'KOREAN', 'BUDDHIST', '987 SEOUL ST SEOUL', '2223334444', '76543210'),
(8, 'Patient0008', 'EMILY', 'K', 'WILLIAMS', 'FEMALE', '1990-04-05', 32, 'SINGLE', 'AUSTRALIAN', 'CHRISTIAN', '741 SYDNEY RD SYDNEY', '6667778888', '23456789'),
(9, 'Patient0009', 'ROBERT', 'E', 'MILLER', 'MALE', '1988-09-15', 33, 'MARRIED', 'GERMAN', 'PROTESTANT', '852 BERLIN AVE BERLIN', '9990001111', '98765432'),
(10, 'Patient0010', 'SARAH', 'R', 'JOHNSON', 'FEMALE', '1978-06-08', 45, 'DIVORCED', 'IRISH', 'CATHOLIC', '369 DUBLIN ST DUBLIN', '3332221111', '12345678'),
(11, 'Patient0011', 'WILLIAM', 'B', 'BROWN', 'MALE', '1983-01-20', 39, 'SINGLE', 'ITALIAN', 'OTHER', '258 ROME AVE ROME', '4445556666', '87654321'),
(12, 'Patient0012', 'MELISSA', 'T', 'MARTINEZ', 'FEMALE', '1992-12-03', 29, 'MARRIED', 'MEXICAN', 'CATHOLIC', '123 MEXICO ST MEXICO CITY', '1112223333', '65432187'),
(13, 'Patient0013', 'CHRISTOPHER', 'P', 'GONZALEZ', 'MALE', '1976-04-15', 48, 'DIVORCED', 'ARGENTINIAN', 'OTHER', '456 BUENOS AIRES AVE BUENOS AIRES', '7778889999', '45678901'),
(14, 'Patient0014', 'LISA', 'M', 'PEREZ', 'FEMALE', '1996-07-29', 25, 'SINGLE', 'BRAZILIAN', 'PROTESTANT', '789 RIO AVE RIO DE JANEIRO', '8887776666', '76543210'),
(15, 'Patient0015', 'MATTHEW', 'S', 'LOPEZ', 'MALE', '1982-08-12', 39, 'MARRIED', 'CANADIAN', 'CATHOLIC', '963 TORONTO ST TORONTO', '9998887777', '23456789'),
(16, 'Patient0016', 'AMANDA', 'W', 'YOUNG', 'FEMALE', '1998-05-20', 26, 'SINGLE', 'AUSTRALIAN', 'OTHER', '741 MELBOURNE RD MELBOURNE', '1112223333', '98765432'),
(17, 'Patient0017', 'JAMES', 'R', 'MARTIN', 'MALE', '1987-11-17', 34, 'MARRIED', 'GERMAN', 'PROTESTANT', '852 BERLIN AVE BERLIN', '3334445555', '12345678'),
(18, 'Patient0018', 'ASHLEY', 'L', 'HALL', 'FEMALE', '1989-03-02', 33, 'DIVORCED', 'FRENCH', 'CATHOLIC', '369 PARIS ST PARIS', '6667778888', '87654321'),
(19, 'Patient0019', 'CHARLES', 'W', 'ALLEN', 'MALE', '1984-09-05', 37, 'WIDOWED', 'BRITISH', 'PROTESTANT', '258 LONDON AVE LONDON', '2223334444', '45678901'),
(20, 'Patient0020', 'KAREN', 'G', 'KIM', 'FEMALE', '1993-02-28', 28, 'SINGLE', 'KOREAN', 'BUDDHIST', '987 SEOUL ST SEOUL', '7778889999', '76543210');

-- --------------------------------------------------------

--
-- Table structure for table `pharmacist`
--

CREATE TABLE `pharmacist` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Position` varchar(50) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `queue`
--

CREATE TABLE `queue` (
  `QueueID` int(11) NOT NULL,
  `PatientID` varchar(50) DEFAULT NULL,
  `DoctorID` varchar(50) DEFAULT NULL,
  `Clinic` varchar(50) DEFAULT NULL,
  `QueueNumber` varchar(10) DEFAULT NULL,
  `QueueStatus` varchar(255) DEFAULT NULL,
  `QueueTime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `QueueDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `timelogs`
--

CREATE TABLE `timelogs` (
  `ID` int(11) NOT NULL,
  `FullName` varchar(255) NOT NULL,
  `TimeIn` timestamp NOT NULL DEFAULT current_timestamp(),
  `TimeOut` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `treatment`
--

CREATE TABLE `treatment` (
  `TreatmentID` int(11) NOT NULL,
  `DoctorName` varchar(255) DEFAULT NULL,
  `PatientID` varchar(50) DEFAULT NULL,
  `Findings` text DEFAULT NULL,
  `Prescription` text DEFAULT NULL,
  `DateRecorded` datetime DEFAULT NULL,
  `PatientIllnessID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `treatmentrecordhas`
--

CREATE TABLE `treatmentrecordhas` (
  `TreatmentID` int(11) NOT NULL,
  `DoctorName` varchar(55) DEFAULT NULL,
  `PatientID` varchar(55) DEFAULT NULL,
  `HIV_AIDS_Status` text DEFAULT NULL,
  `STI_Status` text DEFAULT NULL,
  `HIV_AIDS_Medication` text DEFAULT NULL,
  `STI_Medication` text DEFAULT NULL,
  `HealthStatus` text DEFAULT NULL,
  `DateRecorded` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `treatment_motherhood`
--

CREATE TABLE `treatment_motherhood` (
  `TreatmentID` int(11) NOT NULL,
  `DoctorName` varchar(255) NOT NULL,
  `PatientID` varchar(255) NOT NULL,
  `PregnancyTest` text DEFAULT NULL,
  `UltrasoundResult` text DEFAULT NULL,
  `PatientComplains` text DEFAULT NULL,
  `PatientHistory` text DEFAULT NULL,
  `PelvicResult` text DEFAULT NULL,
  `Medications` text DEFAULT NULL,
  `DateRecorded` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `treatment_tb`
--

CREATE TABLE `treatment_tb` (
  `TreatmentID` int(11) NOT NULL,
  `DoctorName` varchar(255) DEFAULT NULL,
  `PatientID` varchar(255) DEFAULT NULL,
  `TBTest` text DEFAULT NULL,
  `PatientHistory` text DEFAULT NULL,
  `PatientComplains` text DEFAULT NULL,
  `MedicalHistory` text DEFAULT NULL,
  `Medications` text DEFAULT NULL,
  `DateRecorded` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `vitalsigns`
--

CREATE TABLE `vitalsigns` (
  `ID` int(11) NOT NULL,
  `PatientID` varchar(20) DEFAULT NULL,
  `BodyTemp` varchar(20) NOT NULL,
  `BloodPressure` varchar(20) NOT NULL,
  `RespirationRate` varchar(20) NOT NULL,
  `PulseRate` varchar(20) NOT NULL,
  `Weight` varchar(20) NOT NULL,
  `Height` varchar(20) NOT NULL,
  `Diagnosis` text DEFAULT NULL,
  `Timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `administrators`
--
ALTER TABLE `administrators`
  ADD PRIMARY KEY (`AdminID`),
  ADD KEY `ID` (`ID`);

--
-- Indexes for table `clinic`
--
ALTER TABLE `clinic`
  ADD PRIMARY KEY (`ClinicID`);

--
-- Indexes for table `doctorrequestfiles`
--
ALTER TABLE `doctorrequestfiles`
  ADD PRIMARY KEY (`FileID`),
  ADD KEY `fk_RequestID` (`RequestID`);

--
-- Indexes for table `doctorrequests`
--
ALTER TABLE `doctorrequests`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `SenderDoctorID` (`SenderDoctorID`),
  ADD KEY `ReceiverDoctorID` (`ReceiverDoctorID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`DoctorID`),
  ADD KEY `ID` (`ID`);

--
-- Indexes for table `doctorspecializations`
--
ALTER TABLE `doctorspecializations`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Specialization` (`Specialization`);

--
-- Indexes for table `illnesses`
--
ALTER TABLE `illnesses`
  ADD PRIMARY KEY (`IllnessID`),
  ADD UNIQUE KEY `IllnessName` (`IllnessName`);

--
-- Indexes for table `laboratories`
--
ALTER TABLE `laboratories`
  ADD PRIMARY KEY (`LaboratoryID`),
  ADD UNIQUE KEY `LaboratoryName` (`LaboratoryName`);

--
-- Indexes for table `laboratoryresults`
--
ALTER TABLE `laboratoryresults`
  ADD PRIMARY KEY (`LabResultID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `laboratoryusers`
--
ALTER TABLE `laboratoryusers`
  ADD PRIMARY KEY (`LaboratoryUserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `maritalstatus`
--
ALTER TABLE `maritalstatus`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `MaritalStatusName` (`MaritalStatusName`);

--
-- Indexes for table `medicine`
--
ALTER TABLE `medicine`
  ADD PRIMARY KEY (`MedicineID`);

--
-- Indexes for table `medicineout`
--
ALTER TABLE `medicineout`
  ADD PRIMARY KEY (`TransactionID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `medicineoutdetails`
--
ALTER TABLE `medicineoutdetails`
  ADD KEY `TransactionID` (`TransactionID`),
  ADD KEY `MedicineID` (`MedicineID`);

--
-- Indexes for table `nurses`
--
ALTER TABLE `nurses`
  ADD PRIMARY KEY (`NurseID`),
  ADD KEY `ID` (`ID`);

--
-- Indexes for table `nursespecializations`
--
ALTER TABLE `nursespecializations`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Specialization` (`Specialization`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`PatientID`),
  ADD KEY `ID` (`ID`);

--
-- Indexes for table `pharmacist`
--
ALTER TABLE `pharmacist`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `queue`
--
ALTER TABLE `queue`
  ADD PRIMARY KEY (`QueueID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `DoctorID` (`DoctorID`);

--
-- Indexes for table `timelogs`
--
ALTER TABLE `timelogs`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `treatment`
--
ALTER TABLE `treatment`
  ADD PRIMARY KEY (`TreatmentID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `FK_PatientIllness_Treatment` (`PatientIllnessID`);

--
-- Indexes for table `treatmentrecordhas`
--
ALTER TABLE `treatmentrecordhas`
  ADD PRIMARY KEY (`TreatmentID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `treatment_motherhood`
--
ALTER TABLE `treatment_motherhood`
  ADD PRIMARY KEY (`TreatmentID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `treatment_tb`
--
ALTER TABLE `treatment_tb`
  ADD PRIMARY KEY (`TreatmentID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `vitalsigns`
--
ALTER TABLE `vitalsigns`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `administrators`
--
ALTER TABLE `administrators`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `clinic`
--
ALTER TABLE `clinic`
  MODIFY `ClinicID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctorrequestfiles`
--
ALTER TABLE `doctorrequestfiles`
  MODIFY `FileID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctorrequests`
--
ALTER TABLE `doctorrequests`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctorspecializations`
--
ALTER TABLE `doctorspecializations`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `illnesses`
--
ALTER TABLE `illnesses`
  MODIFY `IllnessID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `laboratories`
--
ALTER TABLE `laboratories`
  MODIFY `LaboratoryID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `laboratoryresults`
--
ALTER TABLE `laboratoryresults`
  MODIFY `LabResultID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `laboratoryusers`
--
ALTER TABLE `laboratoryusers`
  MODIFY `LaboratoryUserID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `maritalstatus`
--
ALTER TABLE `maritalstatus`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `medicine`
--
ALTER TABLE `medicine`
  MODIFY `MedicineID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `nurses`
--
ALTER TABLE `nurses`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `nursespecializations`
--
ALTER TABLE `nursespecializations`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `pharmacist`
--
ALTER TABLE `pharmacist`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `queue`
--
ALTER TABLE `queue`
  MODIFY `QueueID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `timelogs`
--
ALTER TABLE `timelogs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `treatment`
--
ALTER TABLE `treatment`
  MODIFY `TreatmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `treatmentrecordhas`
--
ALTER TABLE `treatmentrecordhas`
  MODIFY `TreatmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `treatment_motherhood`
--
ALTER TABLE `treatment_motherhood`
  MODIFY `TreatmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `treatment_tb`
--
ALTER TABLE `treatment_tb`
  MODIFY `TreatmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `vitalsigns`
--
ALTER TABLE `vitalsigns`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doctorrequestfiles`
--
ALTER TABLE `doctorrequestfiles`
  ADD CONSTRAINT `fk_RequestID` FOREIGN KEY (`RequestID`) REFERENCES `doctorrequests` (`RequestID`);

--
-- Constraints for table `doctorrequests`
--
ALTER TABLE `doctorrequests`
  ADD CONSTRAINT `doctorrequests_ibfk_1` FOREIGN KEY (`SenderDoctorID`) REFERENCES `doctors` (`DoctorID`),
  ADD CONSTRAINT `doctorrequests_ibfk_2` FOREIGN KEY (`ReceiverDoctorID`) REFERENCES `doctors` (`DoctorID`),
  ADD CONSTRAINT `doctorrequests_ibfk_3` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `laboratoryresults`
--
ALTER TABLE `laboratoryresults`
  ADD CONSTRAINT `laboratoryresults_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `medicineout`
--
ALTER TABLE `medicineout`
  ADD CONSTRAINT `medicineout_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `medicineoutdetails`
--
ALTER TABLE `medicineoutdetails`
  ADD CONSTRAINT `medicineoutdetails_ibfk_1` FOREIGN KEY (`TransactionID`) REFERENCES `medicineout` (`TransactionID`),
  ADD CONSTRAINT `medicineoutdetails_ibfk_2` FOREIGN KEY (`MedicineID`) REFERENCES `medicine` (`MedicineID`);

--
-- Constraints for table `queue`
--
ALTER TABLE `queue`
  ADD CONSTRAINT `queue_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`),
  ADD CONSTRAINT `queue_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `doctors` (`DoctorID`);

--
-- Constraints for table `treatment`
--
ALTER TABLE `treatment`
  ADD CONSTRAINT `FK_PatientIllness_Treatment` FOREIGN KEY (`PatientIllnessID`) REFERENCES `illnesses` (`IllnessID`),
  ADD CONSTRAINT `treatment_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `treatmentrecordhas`
--
ALTER TABLE `treatmentrecordhas`
  ADD CONSTRAINT `treatmentrecordhas_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `treatment_motherhood`
--
ALTER TABLE `treatment_motherhood`
  ADD CONSTRAINT `treatment_motherhood_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `treatment_tb`
--
ALTER TABLE `treatment_tb`
  ADD CONSTRAINT `treatment_tb_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);

--
-- Constraints for table `vitalsigns`
--
ALTER TABLE `vitalsigns`
  ADD CONSTRAINT `vitalsigns_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
