select * from student_attendance_history

Update student_attendance
set time_in=null
where admission_no='BIS345 ' and date='2016-07-22' 

select * from student_attendance where (date>='2016-07-01' and date<= '2016-07-23') and (name like '%mun%' or surname like '%mus%') 