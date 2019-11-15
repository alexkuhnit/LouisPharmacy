use Pharmacy
go

insert into patient
VALUES
    ('George', 'Detore', 'N','3 south ave', null, 'Nerven', 'PA', 17866, 7176446464, null, null, 'georgied@gmail.com', '01/02/1998', 'Male'),
	('Christian', 'Carabello', 'J','4 south ave', null, 'Quarryville', 'PA', 62155, 7176445456, null, null, 'cj@gmail.com', '10/24/1998', 'Male'),
	('Evan', 'Trowbridge', 'I','5 south ave', null, 'Allentown', 'PA', 19845, 7175456345, null, null, 'Evani@gmail.com', '11/01/1998', 'Male'),
	('Julian', 'Smith', 'V','6 south ave', null, 'York', 'PA', 19548, 7174589836, null, null, 'Julianv@gmail.com', '04/15/1998', 'Male'),
	('Cherry', 'Selless', 'R','7 south ave', null, 'Nerven', 'PA', 17866, 7174256878, null, null, 'CherryS@gmail.com', '12/01/1998', 'Female');

insert into physician
values
	('Henry', 'Fisker', 'Get Better Doctor Office'),
	('Larry', 'McStein', 'Get Better Doctor Office'),
	('Marissa', 'Sunderland', 'Dont die Doctor Office'),
	('Carol', 'Carabello', 'Dont die Doctor Office'),
	('Hannibal', 'Lecter', 'Dont die Doctor Office');

insert into drug
values
	('0009006607', 'xanax', '2 mg', '60'),
	('5374620401', 'Oxycodone', '10 mg', '100'),
	('6362915875', 'Prednisone', '20 mg', '10'),
	('6838211905', 'Azathioprine', '75 mg', '500'),
	('6878873313', 'Tacrolimus', '1 mg', '30')

insert into prescription
values
	('0009006607','1','1','4','4','11/13/2019')

insert into fulfillment
values
	('1','11-13-2019 10:00:00 AM')
