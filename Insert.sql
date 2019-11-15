use Pharmacy
go

insert into patient
VALUES
    ('George', 'Detore', 'N', '01/02/1998', 'Male','3 south ave', null, 'Nerven', 'PA', 17866, 7176446464, null, null, 'georgied@gmail.com'),
	('Christian', 'Carabello', 'J', '10/24/1998', 'Male','4 south ave', null, 'Quarryville', 'PA', 62155, 7176445456, null, null, 'cj@gmail.com'),
	('Evan', 'Trowbridge', 'I', '11/01/1998', 'Male','5 south ave', null, 'Allentown', 'PA', 19845, 7175456345, null, null, 'Evani@gmail.com'),
	('Julian', 'Smith', 'V', '04/15/1998', 'Male','6 south ave', null, 'York', 'PA', 19548, 7174589836, null, null, 'Julianv@gmail.com'),
	('Cherry', 'Selless', 'R', '12/01/1998', 'Female','7 south ave', null, 'Nerven', 'PA', 17866, 7174256878, null, null, 'CherryS@gmail.com');

insert into physician
values
	('Henry', 'a','Fisker', 'Get Better Doctor Office', '7179854526', '147625'),
	('Larry','b', 'McStein', 'Get Better Doctor Office', '7179854526', '654982'),
	('Marissa','c', 'Sunderland', 'Dont die Doctor Office', '7179854526', '261684'),
	('Carol','d', 'Carabello', 'Dont die Doctor Office', '7179854526','982476'),
	('Hannibal','e', 'Lecter', 'Dont die Doctor Office', '7179854526','361975');

insert into drug
values
	('0009006607', 'xanax', '2 mg', '60'),
	('5374620401', 'Oxycodone', '10 mg', '100'),
	('6362915875', 'Prednisone', '20 mg', '10'),
	('6838211905', 'Azathioprine', '75 mg', '500'),
	('6878873313', 'Tacrolimus', '1 mg', '30')

insert into prescription
values
	('0009006607','1','1','4','4','11/13/2019'),
	('0009006607','2','2','4','4','11/13/2019'),

insert into fulfillment
values
	('1','11-14-2019 10:00:00 AM')
