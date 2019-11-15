/*
Author: Alex Kuhn, Connor Kaiser
Create Date: 10/31/2019
description: Pharmacy Database Final Project
*/
create database Pharmacy
go

use pharmacy

--Patient Table
create table patient(
	patientID	 int identity(1,1) not null 
				constraint pk_patientID primary key,
	fName		varchar(25) not null,
	lName		varchar(25) not null,
	mInit		char(1) not null,
	DoB			date not null,

	gender		varchar(6) not null 
				check(gender in ('male', 'female')),
	street1		varchar(30) not null,
	street2		varchar(30),
	city		varchar(13) not null,

	state		char(2) not null,
	zip			char(5) not null,
	homePhone	char(10) not null,
	workPhone	char(10),

	cellPhone	char(10),
	email		varchar(75)
	
)
--physician Table
create table physician(
	physicianID int identity(1,1) not null 
				constraint pk_physicianID primary key,
	fName		varchar(25) not null,
	mInit		char(1) not null,
	lName		varchar(50) not null,
	office		varchar(60) not null,
	phoneNum	char(10) not null,
	licenseNum	int not null
)
--Drug Table
create table drug(
	NDCPackageCode varchar(11) not null 
		constraint pk_NDC primary key,
	productName varchar(150),
	strength varchar(20),
	amount int,


)

--Prescription Table
create table prescription(
	prescriptionID int identity(1,1) 
		constraint pk_prescriptionID primary key,
	NDCPackageCode varchar(11) not NULL FOREIGN key (NDCPackageCode) REFERENCES drug(NDCPackageCode),
	patientID 	int not null FOREIGN key (patientID) REFERENCES patient(patientID),
	physicianID int not null FOREIGN key (physicianID) REFERENCES physician(physicianID),
	totalRefills int not NULL,
	remainingRefills int null,
	TIME DATETIME not null
)
--Fulfillment table
create table fulfillment(
	fulfillmentID int identity(1,1)
		constraint pk_fulfillmentID primary key,
	prescriptionID int not NULL FOREIGN KEY (prescriptionID) REFERENCES prescription(prescriptionID),
	TIME DATETIME not null,
)
go

Select productName + ' ' + strength + ' ' + convert(varchar(11), amount) + ' NDC Code ' + NDCPackageCode as combo , NDCPackageCode from [dbo].[drug]