--vacancy
INSERT INTO vacancy 
	VALUES ('VC00020', 'Teacher', 1, 'Mr.', 'Sarath', 'Fonseka', '1984-04-07', 'Male', '2006-11-02', '2006-11-30')
INSERT INTO vacancy 
	VALUES ('VC00023', 'Sectional Head', 1, 'Ms.', 'Naomi', 'Rajapakshe', '1994-04-07', 'Female', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00024', 'Teacher', 1, 'Ms.', 'Mithra', 'Sirisena', '1994-04-07', 'Female', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00025', 'Teacher', 1, 'Ms.', 'Rani', 'Wickramasinghe', '1994-04-07', 'Female', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00026', 'Teacher', 1, 'Mr.', 'Wimol', 'Wiwangse', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00027', 'Teacher', 1, 'Mr.', 'Magenthiran', 'Somasundaram', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00028', 'Teacher', 1, 'Mr.', 'Abraham', 'Lincoln', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00029', 'Teacher', 1, 'Mrs.', 'Jane', 'Bindh', '1994-04-07', 'Female', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00030', 'Teacher', 1, 'Mr.', 'Abraham', 'Lincoln', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00031', 'Librarian', 1, 'Mr.', 'Garry', 'Rathnayake', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00040', 'Inventory Handler', 1, 'Mr.', 'Rand', 'Squat', '1986-05-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00050', 'Clerk', 1, 'Ms.', 'Isuri', 'Perera', '1990-05-10', 'Female', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00045', 'Data Entry Operator', 1, 'Mr.', 'John', 'Mann', '1996-04-07', 'Male', '2007-11-02', '2007-11-30')
INSERT INTO vacancy 
	VALUES ('VC00032', 'Librarian', 0, 'Mr.', 'Alex', 'Pandiyan', '1994-04-07', 'Male', '2007-11-02', '2007-11-30')

select * from vacancy


--staff
INSERT INTO staff 
	VALUES ('ST00001', 'Mr.', 'Tommy', 'Vercetti', '1986-04-07', 30, 'Male', 'Single', 
	null, '2006-11-02', '2007-01-01', 9, 'Permanent', 'Administrator','rb76@gmail.com', 'Christianity', 
	'Sri Lankan', '861232208V', '1234567890', 'O+', 0775839292, 0772316575, '20070102ST00001', 
	'C:\Users\User\Pictures\Untitled-Optimized')
INSERT INTO staff 
	VALUES ('ST00002', 'Mr.', 'Robinson', 'Anandhan', '1976-04-07', 40, 'Male', 'Married', 
	null, '2006-11-02', '2007-01-02', 9, 'Permanent', 'Principal','rb76@gmail.com', 'Hinduism', 
	'Sri Lankan', '761232208V', '1234567890', 'B+', 0718939292, 0778456575, '20070102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00003', 'Mr.', 'Sarath', 'Fonseka', '1984-04-07', 32, 'Male', 'Married', 
	'VC00020', '2006-11-02', '2007-01-02', 9, 'Permanent', 'Teacher','sf84@gmail.com', 'Buddhism', 
	'Sri Lankan', '941232208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00004', 'Ms.', 'Naomi', 'Rajapakshe', '1994-04-07', 22, 'Female', 'Single', 
	'VC00023', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Sectional Head','nf94@gmail.com', 'Buddhism', 
	'Sri Lankan', '941232208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00005', 'Mr.', 'Garry', 'Rathnayake', '1994-04-07', 22, 'Male', 'Single', 
	'VC00031', '2007-11-02', '2007-11-30', 9, 'Permanent', 'Librarian','gr94@gmail.com', 'Buddhism', 
	'Sri Lankan', '941232208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00006', 'Mr.', 'Rand', 'Squat', '1986-05-07', 30, 'Male', 'Single', 
	'VC00040', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Inventory Handler','rs86@gmail.com', 'Buddhism', 
	'Sri Lankan', '687832208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00007', 'Mr.', 'Isuri', 'Perera', '1990-05-10', 26, 'Female', 'Single', 
	'VC00050', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Clerk','ip90@gmail.com', 'Buddhism', 
	'Sri Lankan', '903232208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00008', 'Mr.', 'John', 'Mann', '1996-04-07', 20, 'Male', 'Single', 
	'VC00045', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Data Entry Operator','jm94@gmail.com', 'Buddhism', 
	'Sri Lankan', '961230008V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00010', 'Mr.', 'Greg', 'De Silva', '1994-03-15', 22, 'Male', 'Single', 
	'VC00027', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Teacher','sf94@gmail.com', 'Buddhism', 
	'Sri Lankan', '943582208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00011', 'Mr.', 'Abe', 'Lionel', '1994-08-01', 22, 'Male', 'Single', 
	'VC00028', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Teacher','sf94@gmail.com', 'Buddhism', 
	'Sri Lankan', '941239208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')
INSERT INTO staff 
	VALUES ('ST00009', 'Mr.', 'Bae', 'Boice', '1994-08-01', 22, 'Male', 'Single', 
	'VC00028', '2007-11-02', '2008-01-02', 9, 'Permanent', 'Teacher','sf94@gmail.com', 'Buddhism', 
	'Sri Lankan', '941239208V', '1234567890', 'B+', 0718939292, 0778456575, '20080102ST00001', 'path')


select * from staff

--academic_staff
INSERT INTO academic_staff
	VALUES ('ST00003', 'Grade1', 'Red', 'Drama Society', 'Teacher-in-Charge')
INSERT INTO academic_staff
	VALUES ('ST00004', 'Grade2', 'Green', 'English Club', 'Teacher-in-Charge')
INSERT INTO academic_staff
	VALUES ('ST00005', 'Grade2', 'Blue', 'Drama Society', 'Coordinator')
INSERT INTO academic_staff
	VALUES ('ST00011', 'Grade2', 'Black', 'Swimming Club', 'Teacher-in-Charge')
INSERT INTO academic_staff
	VALUES ('ST00009', 'Grade2', 'Yellow', 'Scouts Association', 'Teacher-in-Charge')


select * from academic_staff


--family
INSERT INTO health_issues VALUES ('ST00001', 'HI00001', 'Skin Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00001', 'HI00002', 'Peanut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00002', 'HI00003', 'Skin Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00002', 'HI00004', 'Nut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00003', 'HI00005', 'Skin Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00003', 'HI00006', 'Nut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00003', 'HI00007', 'Cold Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00004', 'HI00008', 'Skin Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00004', 'HI00009', 'Skin Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00005', 'HI00010', 'Nut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00005', 'HI00011', 'Peanut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00006', 'HI00012', 'Nut Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00006', 'HI00013', 'Shellfish Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00007', 'HI00014', 'Latex Allergy', 'None')
INSERT INTO health_issues VALUES ('ST00007', 'HI00015', 'Dust Allergy', 'None')

select * from family

--family
INSERT INTO family VALUES('ST00001', 'Spouse', 'Alex', 'Common', 'Doctor', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00001', 'Parent', 'Some', 'OnePerson', 'Teacher', 0714444589, 'No. 52, 31st Lane, Colombo 6, 06000', 0);
INSERT INTO family VALUES('ST00002', 'Spouse', 'Shey', 'Gosha', 'Businessperson', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00003', 'Parent', 'Perera', 'Kaydee', 'Businessperson', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 0);
INSERT INTO family VALUES('ST00004', 'Child', 'Rahman', 'Rakka', 'Doctor', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00004', 'Spouse', 'Emin', 'Aem', 'Businessperson', 0718936589, 'No. 62, 31st Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00005', 'Child', 'Bruce', 'Wayne', 'Doctor', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 0);
INSERT INTO family VALUES('ST00006', 'Parent', 'Robinson', 'Banner', 'Engineer', 0718936589, 'No. 52, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00007', 'Spouse', 'Cray', 'Deen', 'Doctor', 0718936589, 'No. 62, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00008', 'Spouse', 'Amy', 'Ram', 'Businessperson', 0718936589, 'No. 52, 32nd Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00009', 'Parent', 'Rand', 'Gen', 'Businessperson', 0718936589, 'No. 62, 32nd Lane, Colombo 7, 06000', 1);
INSERT INTO family VALUES('ST00010', 'Spouse', 'Shiren', 'Goyal', 'Businessperson', 0718936589, 'No. 62, 32nd Lane, Colombo 7, 06000', 1);
INSERT INTO family VALUES('ST00004', 'Parent', 'Shehan', 'Guna', 'Businessperson', 0718936589, 'No. 52, 32nd Lane, Colombo 7, 06000', 1);
INSERT INTO family VALUES('ST00005', 'Spouse', 'Mevin', 'Davin', 'Doctor', 0718936589, 'No. 62, 31st Lane, Colombo 6, 06000', 1);
INSERT INTO family VALUES('ST00011', 'Parent', 'Grady', 'Phill', 'Teacher', 0718936589, 'No. 62, 32nd Lane, Colombo 7, 06000', 1);


select * from family


--address
INSERT INTO address VALUES ('ST00001', 'No. 62, 32nd Lane', 'Colombo 8', 'Western', 01000)
INSERT INTO address VALUES ('ST00001', 'No. 40, 42nd Lane', 'Colombo 6', 'Western', 06000)
INSERT INTO address VALUES ('ST00002', 'No. 21, 32nd Lane', 'Colombo 2', 'Western', 04000)
INSERT INTO address VALUES ('ST00003', 'No. 55, 32nd Lane', 'Colombo 1', 'Western', 06000)
INSERT INTO address VALUES ('ST00004', 'No. 12/5, 52nd Lane', 'Colombo 10', 'Western', 01000)
INSERT INTO address VALUES ('ST00005', 'No. 78/1, 22nd Lane', 'Colombo 9', 'Western', 09000)
INSERT INTO address VALUES ('ST00006', 'No. 62/3, 1st Lane', 'Colombo 5', 'Western', 05000)


select * from address


--qualification
INSERT INTO qualification VALUES ('ST00001', 'Academic', 'AL', 'Advanced Level' , 'Rajakeeya Vidhyalaya', '-', 2, 2002)
INSERT INTO qualification VALUES ('ST00001', 'Academic', 'BSc', 'BSc(Hons) in Science' , '-', 'Colombo University', 5, 2007)
INSERT INTO qualification VALUES ('ST00001', 'Professional', 'CISCO', '-' , '-', 'CISCO Institute', 1, 2003)
INSERT INTO qualification VALUES ('ST00002', 'Academic', 'AL', 'Advanced Level' , 'Baudhaloka Vidhyalaya', '-', 2, 2003)
INSERT INTO qualification VALUES ('ST00002', 'Academic', 'AL', 'Advanced Level' , 'Don International School', '-', 2, 2005)
INSERT INTO qualification VALUES ('ST00003', 'Academic', 'AL', 'Advanced Level' , 'Carey College', '-', 2, 2004)
INSERT INTO qualification VALUES ('ST00004', 'Academic', 'AL', 'Advanced Level' , 'Bradmon College', '-', 2, 2004)
INSERT INTO qualification VALUES ('ST00004', 'Professional', 'CISCO', '-' , '-', 'CISCO Institute', 2, 2002)


select * from qualification


--administrative_staff
INSERT INTO administrative_staff VALUES ('ST00001', 'Administrative')
INSERT INTO administrative_staff VALUES ('ST00002', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00003', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00004', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00005', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00006', 'Administrative')
INSERT INTO administrative_staff VALUES ('ST00007', 'Administrative')
INSERT INTO administrative_staff VALUES ('ST00008', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00009', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00010', 'Academic')
INSERT INTO administrative_staff VALUES ('ST00011', 'Academic')


select * from administrative_staff