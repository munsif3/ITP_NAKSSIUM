select COUNT(admission_no)
from student_attendance 
where status='Present' and admission_no='bis776' and [date] between '2016/07/01' and '2016/07/28'



select * 
from student_attendance 
where admission_no='bis776'

select COUNT(admission_no)
from student_attendance 
where status='Present' and admission_no='bis180' and [date] between '2016/07/01' and '2016/07/28'


select * 
from student_attendance 
where admission_no='bis180' 
		and date = '2016-07-23' 



select * 
from student_attendance 
where admission_no='bis180'

select admission_no,name, date,status
from student_attendance 
where admission_no='bis180' and status='Absent' and  date >= '2016-06-01'
group by admission_no,name, date,status

