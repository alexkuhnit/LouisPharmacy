use pharmacy
go

--drop TRIGGER trigger_remaining_refills
create TRIGGER trigger_remaining_refills
on fulfillment
after insert
AS
    BEGIN
        DECLARE @fulfilled INT
        declare @fulPrescriptionID int
        declare @totalRefills int
		declare @remainingRefills int

        select @fulPrescriptionID = (select prescriptionID from inserted)
        SELECT @fulfilled = (SELECT count(*) from fulfillment where prescriptionID = @fulPrescriptionID)
        select @totalRefills = (select totalRefills from prescription  where prescriptionID = @fulPrescriptionID)
		select @remainingRefills = (select remainingRefills from prescription  where prescriptionID = @fulPrescriptionID)

			IF @remainingRefills > 0
				BEGIN
					update prescription
					set remainingRefills = @totalRefills - @fulfilled
					where prescriptionID = @fulPrescriptionID
				END
			ELSE
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to update record.',16,1)
				END
    END
GO






/*
Stored Procedures-----------------------
*/

--add physician
create proc [dbo].[AddPhysician](
	@fName		varchar(25),
	@mInit		char(1),
	@lName		varchar(50),
	@office		varchar(60),
	@phoneNum	char(10),
	@licenseNum	int
)
as	
	BEGIN
		begin transaction
			INSERT into physician(fname, minit, lname, office, phoneNum, Licensenum)
			values (@fname, @mInit, @lName, @office, @phoneNum, @licenseNum)
					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO

--add patient
CREATE PROC AddPatient(
	@FNAME			VARCHAR(25),
	@LNAME			VARCHAR(25),
	@MINIT			CHAR(1) = NULL,
	@DOB			DATE,

	@GENDER			varCHAR(6),
	@STREET1		VARCHAR(30) = NULL,
	@STREET2		VARCHAR(30) = NULL,
	@CITY			VARCHAR(30) = NULL,

	@STATE		CHAR(2) = NULL,
	@ZIP			INT = NULL,
	@HOMEPHONE		VARCHAR(15) = NULL,
	@WORKPHONE		VARCHAR(15) = NULL,

	@CELLPHONE		VARCHAR(15) = NULL,
	@EMAIL		VARCHAR(100) = NULL
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO PATIENT( FNAME, LNAME, MINIT, DOB, GENDER, STREET1, STREET2, CITY, STATE, ZIP, HOMEPHONE, WORKPHONE, CELLPHONE, EMAIL)
			VALUES (@FNAME, @LNAME, @MINIT, @DOB, @GENDER, @STREET1, @STREET2, @CITY, @STATE, @ZIP, @HOMEPHONE, @WORKPHONE, @CELLPHONE, @EMAIL)

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO


--add prescription
CREATE PROC AddPrescription(
	@NDCPackageCode		varchar(11),
	@patientID			int,
	@physicianID		int,
	@totalRefills		int,

	@remainingRefills	int,
	@time				datetime
	)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO PRESCRIPTION(NDCPackageCode, patientID, physicianID, totalRefills, remainingRefills, time)
			VALUES (@NDCPackageCode, @patientID, @physicianID, @totalRefills, @remainingRefills, @time)

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO

--SearchPatients

create PROC [dbo].[SearchPatient](
    @patientID varchar(20),
    @fname varchar(25),
    @lname varchar(25)
)
AS
    BEGIN
        SELECT	patientID as 'Patient ID',
				fName as 'First Name',
				lName as 'Last Name',
				mInit as 'Middle Initial',
				DOB as 'Date of Birth',
				gender as 'Gender',
				street1 as 'Street 1',
				street2 as 'Street 2',
				city as 'City',
				state as 'State',
				zip as 'zip',
				homePhone as 'Home Phone',
				workPhone as 'Work Phone',
				cellPhone as 'Cell Phone',
				email as 'Email'
            from patient
            where (upper(lname)like '%' + upper(@lname) + '%' or upper(lname) = '')
            and (upper(fname)like '%' + upper(@fname) + '%' or upper(fname) = '')
            and (cast(patientID as varchar)like '%' + upper(@patientID) + '%' or cast(patientID as varchar) = '')
    END
go

create PROC [dbo].[SearchPhysician](
    @physicianID varchar(20),
    @fname varchar(25),
    @lname varchar(25)
)
AS
    BEGIN
        SELECT	physicianID as 'Physician ID',
				fName as 'First Name',
				lName as 'Last Name',
				mInit as 'Middle Initial',
				office as 'Office',
				phoneNum as 'Phone Number',
				licenseNum as 'License Number'
            from physician
            where (upper(lname)like '%' + upper(@lname) + '%' or upper(lname) = '')
            and (upper(fname)like '%' + upper(@fname) + '%' or upper(fname) = '')
            and (cast(physicianID as varchar)like '%' + upper(@physicianID) + '%' or cast(physicianID as varchar) = '')
    END
go

create PROC [dbo].[FillPatient]
AS
    BEGIN
        SELECT *
            from patient
    END
go



create PROC [dbo].[SearchPrescription](
    @patientID varchar(20)
)
AS
    BEGIN
        SELECT	prescription.prescriptionID as 'Prescription ID',
				prescription.NDCPackageCode as 'NDC Package Code',
				productName + ', ' + strength + ', ' + convert(varchar(11), amount) as 'Drug Info',
				--Select productName + ', ' + strength + ', ' + convert(varchar(11), amount) + ' Pills, NDC Code ' + NDCPackageCode as combo,
				--Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), patientid) as combo, 
				convert(varchar(11), prescription.patientID)as 'Patient ID',
				patient.lName+ ', ' + patient.mInit + ', ' + patient.fName as 'Patient Name',
				--Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), patientid) as combo, 
				prescription.physicianID as 'Physician ID',
				physician.lName + ', ' + physician.mInit + ', ' + physician.fName as 'Physician Name',
				--Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), PhysicianID) as combo ,
				prescription.totalRefills as 'Total fulfillments',
				prescription.remainingRefills as 'Fulfillments remaining',
				prescription.time as 'Time Prescribed'
            from prescription
			left join patient 
			on patient.patientID = prescription.patientID
			left join physician
			on prescription.physicianID = physician.physicianID
			left join drug
			on prescription.NDCPackageCode = drug.NDCPackageCode
            where (cast(patient.patientID as varchar)like '%' + upper(@patientID) + '%' or cast(patient.patientID as varchar) = '')
    END
go

create PROC [dbo].[SearchPrescriptionPrescriptionID](
    @prescriptionID varchar(20)
)
AS
    BEGIN
        SELECT *
            from prescription
            where (cast(prescriptionID as varchar)like '%' + upper(@prescriptionID) + '%' or cast(prescriptionID as varchar) = '')
    END
GO

create proc GetFulfillment(
	@fulfillmentID int
)
as
	begin
		select * from fulfillment where fulfillmentID = @fulfillmentID
	end
go
--Update Patient
CREATE PROC UpdatePatient(
	@patientID		int,

	@FNAME			VARCHAR(25) = NULL,
	@LNAME			VARCHAR(25) = NULL,
	@MINIT			CHAR(1) = NULL,
	@DOB			DATE = NULL,

	@GENDER			varCHAR(6) = NULL,
	@STREET1		VARCHAR(30) = NULL,
	@STREET2		VARCHAR(30) = NULL,
	@CITY			VARCHAR(30) = NULL,

	@STATE			CHAR(2),
	@ZIP			INT,
	@HOMEPHONE		VARCHAR(15),
	@WORKPHONE		VARCHAR(15) = NULL,

	@CELLPHONE		VARCHAR(15) = NULL,
	@EMAIL		VARCHAR(100)
)
AS
	BEGIN
		update patient
		set
			fname = isnull(@FNAME, fname),
			lname = isnull(@LNAME , lname),
			minit = isnull(@MINIT , minit),
			dob = isnull(@DOB ,dob ),
			gender = isnull(@GENDER , gender),
			street1 = isnull(@STREET1 ,street1 ),
			street2 = isnull(@STREET2 , street2),
			city = isnull(@CITY ,city ),
			state = isnull(@STATE , state),
			zip = isnull(@ZIP ,zip ),
			homephone = isnull(@HOMEPHONE ,homephone ),
			workphone = isnull(@WORKPHONE ,workphone ),
			cellphone = isnull(@CELLPHONE ,cellphone ),
			email = isnull(@EMAIL ,email )
		from patient
		where patientID = @patientID
	end
go

CREATE PROC UpdatePhysician(
	@physicianID		int,

	@FNAME			VARCHAR(25) = NULL,
	@LNAME			VARCHAR(25) = NULL,
	@MINIT			CHAR(1) = NULL,
	@office			varchar(60) = NULL,
	@phonenum		CHAR(10) = null,
	@licenseNum		int = NULL
)
AS
	BEGIN
		update physician
		set
			fname = isnull(@FNAME, fname),
			lname = isnull(@LNAME , lname),
			minit = isnull(@MINIT , minit),
			office = isnull(@office, office),
			phonenum = isnull(@phonenum, phonenum),
			licenseNum = isnull(@licenseNum, licenseNum)
		from physician
		where physicianID = @physicianID
	end
go

create proc searchRefills(
    @prescriptionID varchar(20)
)
AS
    BEGIN
        SELECT fulfillmentID as 'Fulfillment ID',
				prescriptionID as 'Prescription ID',
				time as 'Time fulfilled'
            from fulfillment
            where (cast(prescriptionID as varchar)like '%' + upper(@prescriptionID) + '%' or cast(prescriptionID as varchar) = '')
    END
GO

create proc AddRefill(
	@prescriptionID int,
	@Time datetime,
	@remainingRefills int = null
)
AS
	BEGIN
		select @remainingRefills = (select remainingRefills from prescription  where prescriptionID = @prescriptionID)
		if @remainingRefills > 0
			Begin
			SET NOCOUNT ON;
				BEGIN TRANSACTION
					INSERT INTO fulfillment(prescriptionID, Time)
					VALUES (@prescriptionID, @Time)
					update prescription
						set remainingRefills = (select totalRefills from prescription where prescriptionID = @prescriptionID) - @remainingRefills
					from prescription where prescriptionID = @prescriptionID
					IF @@ERROR <> 0
						BEGIN
							ROLLBACK TRANSACTION
							RAISERROR ('Unable to insert record.',16,1)
							RETURN -1
						END
					ELSE
						BEGIN
							COMMIT TRANSACTION
							PRINT 'Record added successfully!'
						END
			End
		else
			BEGIN
				RAISERROR ('No refills remaining',16,1)
			END
	END
GO


create proc UpdatePrescription(
	@prescriptionID		int,
	@NDCPackageCode		varchar(11),
	@patientID			int,
	@physicianID		int,
	@totalRefills		int,
	@TimesFulfilled int = null,
	@remainingRefills int = null,
	@time				datetime
	)
AS
	BEGIN
	select @TimesFulfilled = (SELECT count(*) from fulfillment where prescriptionID = @PrescriptionID)
	if @totalRefills >= @TimesFulfilled
		begin
			SET NOCOUNT ON;
				BEGIN TRANSACTION
				update prescription
					set NDCPackageCode = isnull(@NDCPackageCode, NDCPackageCode),
						patientID= isnull(@patientID ,patientID ),
						physicianID= isnull(@physicianID , physicianID),
						totalRefills = isnull(@totalRefills ,totalRefills ),
						time= isnull(@time ,time ),
						remainingRefills = @totalRefills - @TimesFulfilled
				from prescription where prescriptionID = @prescriptionID

					IF @@ERROR <> 0
						BEGIN
							ROLLBACK TRANSACTION
							RAISERROR ('Unable to update record.',16,1)
							RETURN -1
						END
					ELSE
						BEGIN
							COMMIT TRANSACTION
							PRINT 'Record update successfully!'
						END
		end
	else
		BEGIN
			RAISERROR ('Cannot insert a lower Total Refills than refills have been completed',16,1)
		END
	END
GO

create proc UpdateFulfillment(
	@FulfillmentID		int,
	@originalPrescriptionID int,
	@prescriptionID		int,
	@totalRefills		int = null,
	@TimesFulfilled int = null,
	@originalTotalRefills		int = null,
	@originalTimesFulfilled int = null,
	@remainingRefills int = null,
	@time				datetime
	)
AS
	BEGIN
	select @TimesFulfilled = (SELECT count(*) from fulfillment where prescriptionID = @PrescriptionID)
	select @totalRefills = (SELECT totalRefills from prescription where prescriptionID = @PrescriptionID)
	select @OriginalTimesFulfilled = (SELECT count(*) from fulfillment where prescriptionID = @originalPrescriptionID)
	select @originalTotalRefills = (SELECT totalRefills from prescription where prescriptionID = @originalPrescriptionID)
	if @originalPrescriptionID != @prescriptionID
		if @totalRefills > @TimesFulfilled
			begin
				SET NOCOUNT ON;
					BEGIN TRANSACTION
					update fulfillment
						set prescriptionID = isnull(@prescriptionID, prescriptionID),
							time= isnull(@time ,time)
					from fulfillment where fulfillmentID = @FulfillmentID
					update prescription
						set remainingRefills = @originalTotalRefills - @originalTimesFulfilled
					from prescription where prescriptionID = @originalPrescriptionID
					update prescription
						set remainingRefills = @totalRefills - @TimesFulfilled
					from prescription where prescriptionID = @prescriptionID
						IF @@ERROR <> 0
							BEGIN
								ROLLBACK TRANSACTION
								RAISERROR ('Unable to update record.',16,1)
								RETURN -1
							END
						ELSE
							BEGIN
								COMMIT TRANSACTION
								PRINT 'Record update successfully!'
							END
			end
		else
			BEGIN
				RAISERROR ('Prescription is out of refills',16,1)
			END
	else
		if @totalRefills >= @TimesFulfilled
				begin
					SET NOCOUNT ON;
						BEGIN TRANSACTION
						update fulfillment
							set prescriptionID = isnull(@prescriptionID, prescriptionID),
								time= isnull(@time ,time)
						from fulfillment where fulfillmentID = @FulfillmentID
						update prescription
							set remainingRefills = @totalRefills - @TimesFulfilled
						from prescription where prescriptionID = @prescriptionID
							IF @@ERROR <> 0
								BEGIN
									ROLLBACK TRANSACTION
									RAISERROR ('Unable to update record.',16,1)
									RETURN -1
								END
							ELSE
								BEGIN
									COMMIT TRANSACTION
									PRINT 'Record update successfully!'
								END
				end
			else
				BEGIN
					RAISERROR ('Prescription is out of refills',16,1)
				END
	END
GO


/*
-----------------stored procedures for deleting things-------------------------------------------------------
*/
create proc RemoveRefill(
	@fulfillmentID int
)
as
	begin
	set nocount on;
		begin transaction
			delete from fulfillment
			where fulfillmentID = @fulfillmentID

					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to delete record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record deleted successfully!'
				END
	END
GO

create proc RemovePrescription(
	@prescriptionID int
)
as
	begin
	set nocount on;
		begin transaction
			delete from fulfillment
			where  prescriptionID = @prescriptionID
			delete from prescription
			where prescriptionID = @prescriptionID

					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to delete record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record deleted successfully!'
				END
	END
GO

create proc RemovePatient(
	@PatientID int
)
as
	begin
	set nocount on;
		begin transaction
			begin
			delete from fulfillment
			where prescriptionID in (select prescriptionID from prescription where patientID = @PatientID)
			end
			begin
			delete from prescription
			where patientID = @PatientID
			end
			begin
			delete from patient
			where patientID = @PatientID
			end

					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to delete record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record deleted successfully!'
				END
	END
GO
create proc RemovePhysician(
	@PhysicianID int
)
as
	begin
	set nocount on;
		begin transaction
			begin
			delete from fulfillment
			where prescriptionID in (select prescriptionID from prescription where physicianID = @PhysicianID)
			end
			begin
			delete from prescription
			where physicianID = @PhysicianID
			end
			begin
			delete from physician
			where physicianID = @PhysicianID
			end

					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to delete record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record deleted successfully!'
				END
	END
GO


--combo box filling
create proc FillCBOPatient(
	@patientID int
)
AS
    BEGIN
		Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), patientid) as combo, 
		patientid 
		from patient
		where patientID = @patientID
    END
GO

create proc FillCBODrug
AS
    BEGIN
		Select productName + ', ' + strength + ', ' + convert(varchar(11), amount) + ' Pills, NDC Code ' + NDCPackageCode as combo, 
		NDCPackageCode from [dbo].[drug]
    END
GO

create proc FillCBOPhysician
AS
    BEGIN
		Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), PhysicianID) as combo ,
		PhysicianID 
		from [dbo].[physician]
    END
GO
