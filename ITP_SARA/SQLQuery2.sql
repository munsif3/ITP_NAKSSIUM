select * from student_attend_history
select * from student
alter table student_attend_history
drop column class 

select * from student_attend_history
ALTER TABLE student_attendance_history
add roll_no int, name varchar(30), surname varchar(40)

update student_attend_history
set class ='GA2'
where admission_no='BIS180'

insert into student_attend_history values ('BIS180', 3, 'Munsif','Musthafa',2014,215,200,93.02325,15,6.976744)

select a.admission_no, a.roll_no, a.first_name, a.last_name, a.year, a.tot_days, a.total_present, a.present_percentage, a.total_absent, a.absent_percentage
from student_attend_history a, student s
where a.admission_no = s.admission_no and present_grade='GA2'


