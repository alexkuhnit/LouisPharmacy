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

--drop TRIGGER trigger_remaining_refills_delete
create TRIGGER trigger_remaining_refills_delete
on fulfillment
after delete
AS
    BEGIN
        DECLARE @fulfilled INT
        declare @fulPrescriptionID int
        declare @totalRefills int
		declare @remainingRefills int


        select @fulPrescriptionID = (select prescriptionID from deleted)
        SELECT @fulfilled = (SELECT count(*) from fulfillment where prescriptionID = @fulPrescriptionID)
        select @totalRefills = (select totalRefills from prescription  where prescriptionID = @fulPrescriptionID)
		select @remainingRefills = (select remainingRefills from prescription  where prescriptionID = @fulPrescriptionID)

				BEGIN
					update prescription
					set remainingRefills = @totalRefills - @fulfilled
					where prescriptionID = @fulPrescriptionID
				END

    END
GO
--drop trigger trigger_remaining_refills_update
create TRIGGER trigger_remaining_refills_update
on fulfillment
after update
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

/*CREATE TRIGGER Trigger_Patient_Visit_Cost
ON VISIT
FOR INSERT
AS
	BEGIN
		DECLARE @insertAmt money
		DECLARE @PATIENTID VARCHAR(7)
		
		SELECT @insertAmt = (SELECT COSTOFVISIT FROM INSERTED)
		SELECT @PATIENTID = (SELECT PATIENT_ID FROM INSERTED)

		IF @insertAmt > 0
			BEGIN
				UPDATE PATIENT
				SET ACCT_BAL = ACCT_BAL + @insertAmt
				WHERE PATIENT_ID = @PATIENTID
			END
	END
GO*/

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
        SELECT *
            from patient
            where (upper(lname)like '%' + upper(@lname) + '%' or upper(lname) = '')
            and (upper(fname)like '%' + upper(@fname) + '%' or upper(fname) = '')
            and (cast(patientID as varchar)like '%' + upper(@patientID) + '%' or cast(patientID as varchar) = '')
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
        SELECT *
            from prescription
            where (cast(patientID as varchar)like '%' + upper(@patientID) + '%' or cast(patientID as varchar) = '')
    END
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
		set patientID = isnull(@patientID, patientID),
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
/*
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

ALTER PROC [dbo].[SearchStudent2](
    @student_ID varchar(6),
    @fname varchar(25),
    @lname varchar(25)
)
AS
    BEGIN
        SELECT STUDENT_ID, FNAME, LNAME, TOTAL_CREDIT_HOURS
            from STUDENT
            where (upper(lname)like '%' + upper(@lname) + '%' or upper(lname) = '')
            and (upper(fname)like '%' + upper(@fname) + '%' or upper(fname) = '')
            and (upper(STUDENT_ID)like '%' + upper(@student_ID) + '%' or upper(student_id) = '')
    END
    go
create PROC [dbo].[SearchStudent3](
    @student_ID varchar(6)
)
AS
    BEGIN
        SELECT *
            from STUDENT
            where (upper(STUDENT_ID)like '%' + upper(@student_ID) + '%' or upper(student_id) = '')
    END
exec SearchStudent2 @student_ID = '', @fname = '', @lname = '';
*/