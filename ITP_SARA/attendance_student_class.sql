CREATE TABLE attendance_student_class
(
	[admission_no] [char](7) NOT NULL,
	[roll_no] [int] NULL,
	[grade] [varchar] (7) NOT NULL,
	[name] [varchar](30) NULL,
	[surname] [varchar](40) NULL,
	[date] [date] NOT NULL,
	[dateStatus] [varchar](20) NULL,
	[time_in] [time](7) NULL,
	[status] [varchar](10) NULL,
	[reason] [varchar](10) NULL,
 CONSTRAINT [pk_stud_class] PRIMARY KEY (admission_no, grade, date)
);

drop table attendance_student_class

select * from attendance_student_class
select * from student_attendance
select * from student

insert into attendance_student_class values ('BIS145',8,'GAS','Nahanaa','Gunasekaran','2016-07-01','School day','07:10:00','Present',NULL)
insert into attendance_student_class values ('BIS180',3,'GA2','Munsif','Musthafa','2016-07-22','School day','07:05:00.0000000','Present',NULL)
insert into attendance_student_class values ('BIS345 ',5,'G10','Kaushek','Roshan','2016-07-01','School day','07:14:32.0000000','Present',NULL)
insert into attendance_student_class values ('BIS776 ',1,'G10','Saranki','Rajah','2016-07-01','School day','07:00:40.0000000','Present',NULL)
insert into attendance_student_class values ('BIS145  ',8,'GAS','Nahanaa','Gunasekaran','2016-07-02','School day','07:20:10.0000000','Present',NULL)

select * from attendance_student_class where grade='G10' AND DATE='2016-07-01'