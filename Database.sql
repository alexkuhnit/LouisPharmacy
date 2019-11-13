/*
Author: Alex Kuhn, Connor Kaiser
Create Date: 10/31/2019
description: Pharmacy Database Final Project
*/
create database Pharmacy
go

use Pharmacy

--Patient Table
create table patient(
	patientID	 int identity(1,1) not null 
				constraint pk_patientID primary key,
	fName		varchar(25) not null,
	lName		varchar(50) not null,
	mInit		char(1) not null,
	street1		varchar(30) not null,
	street2		varchar(30),
	city		varchar(13) not null,
	state		char(2) not null,
	zip			char(5) not null,
	homePhone	char(10) not null,
	workPhone	char(10),
	cellPhone	char(10),
	email		varchar(75),
	DoB			date not null,
	gender		varchar(6) not null 
				check(gender in ('male', 'female')),
	acctBalance	money default 0,
)
--physician Table
create table physician(
	physicianID int identity(1,1) not null 
				constraint pk_physicianID primary key,
	fName		varchar(25) not null,
	lName		varchar(50) not null,
	office		vachar(60) not null,
)
--Drug Table
create table drug(
	NDCPackageCode int(10) not null 
		CONSTRAINT chk_NDC CHECK (phone not like '%[^0-9]%') 
		constraint pk_NDC primary key,
	productName varchar(150),
	strength varchar(20),
	amount int(4),


)

--Perscription Table
create table perscription(
	perscriptionID int identity(1,1) 
		constraint pk_perscriptionID primary key,
)
--Fulfillment table
create table fulfillment(
	fulfillmentID int identity(1,1)
		constraint pk_fulfillmentID primary key,,
)
