CREATE TABLE vacancy(
	vacancy_no varchar(10),
	position_applied varchar(50),
	status bit,
	salutation varchar(10),
	first_name varchar(30),
	last_name varchar(30),
	date_of_birth date,
	gender varchar(7),
	applied_date date,
	interview_date date,
	
	CONSTRAINT pk_vacancy PRIMARY KEY (vacancy_no)	
);

ALTER TABLE vacancy ADD contact_no int
ALTER TABLE vacancy ADD address varchar(100)
ALTER TABLE vacancy ADD email varchar(100)
ALTER TABLE vacancy ADD nic_no char(10)

select * from vacancy
-----------------------------------------------------------------------------------

CREATE TABLE staff(
	staff_id char(7),
	salutation varchar(10),
	first_name varchar(30),
	last_name varchar(30),
	date_of_birth date,
	age int,
	gender varchar(7),
	marital_status varchar(10),
	vacancy_no varchar(10),
	appointment_date date,
	start_date date,
	service_period real,
	permanency varchar(15),
	designation varchar(20),
	email varchar(100),
	religion varchar(20),
	nationality varchar(20),
	nic_no char(10),
	bank_account_no char(10),
	blood_group varchar(5),
	phone_no_1 int,
	phone_no_2 int,
	barcode varchar(255),
	profile_picture image,
	
	CONSTRAINT pk_staff PRIMARY KEY (staff_id),
	CONSTRAINT fk_staff FOREIGN KEY (vacancy_no) REFERENCES vacancy(vacancy_no)
	
);

select * from staff

ALTER TABLE staff DROP COLUMN age
ALTER TABLE staff DROP COLUMN service_period


ALTER TABLE staff ADD house varchar(20)
ALTER TABLE staff ADD union_name varchar(50)
ALTER TABLE staff ADD union_position varchar(50)

-----------------------------------------------------------------------------------

CREATE TABLE address(
	staff_id char(7),
	street varchar(50),
	city varchar(50),
	province varchar(50),
	postal_code int,
	
	CONSTRAINT pk_address PRIMARY KEY (staff_id, street),
	CONSTRAINT fk_address FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);
-----------------------------------------------------------------------------------

CREATE TABLE health_issues(
	staff_id char(7),
	health_id char(7),
	allergy varchar(50),
	medical_history varchar(50),
	
	CONSTRAINT pk_health PRIMARY KEY (health_id),
	CONSTRAINT fk_health FOREIGN KEY (staff_id) REFERENCES staff (staff_id)

);
-----------------------------------------------------------------------------------

CREATE TABLE academic_staff(
	staff_id char(7),
	grade_level varchar(10),
	house varchar(20),
	union_name varchar(50),
	union_position varchar(50),
	
	CONSTRAINT pk_academic PRIMARY KEY (staff_id),
	CONSTRAINT fk_academic FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
);
-----------------------------------------------------------------------------------

CREATE TABLE administrative_staff(
	staff_id char(7),
	admin_type varchar(30),	

	CONSTRAINT pk_admin PRIMARY KEY (staff_id),
	CONSTRAINT fk_admin FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
);

-----------------------------------------------------------------------------------

CREATE TABLE salary(
	staff_id char(7),
	payment_id varchar(10),
	basic_salary real,
	salary_increment real,
	gross_salary real,
	net_salary real,
	date_from date,
	date_to date,
	bonus real,
	allowance real,
	epf_amount real,
	etf_amount real,
	prepared_by varchar(100),
	
	CONSTRAINT pk_salary PRIMARY KEY (payment_id),
	CONSTRAINT fk_salary FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);
-----------------------------------------------------------------------------------

CREATE TABLE loan_details(
	staff_id char(7),
	loan_id varchar(10),
	loan_name varchar(50),
	maximum_loan real,
	loan_amount real,
	deduction_rate real,
	
	CONSTRAINT pk_loan PRIMARY KEY (loan_id),
	CONSTRAINT fk_loan FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);
-----------------------------------------------------------------------------------

CREATE TABLE family(
	staff_id char(7),
	guardian_type varchar(20),
	first_name varchar(50),
	last_name varchar(50),
	occupation varchar(50),
	phone_no int,
	address varchar(255),
	is_emergency_contact bit,
	
	CONSTRAINT pk_guard PRIMARY KEY (staff_id, guardian_type),
	CONSTRAINT fk_guard FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);

-----------------------------------------------------------------------------------

CREATE TABLE qualification(
	staff_id char(7),
	qualification_type varchar(20),
	qualification_name varchar(20),
	description varchar(255),
	college varchar(100),
	university varchar(100),
	duration int,
	completion_year date,
	
	CONSTRAINT pk_qualification PRIMARY KEY (qualification_type),
	CONSTRAINT fk_qualification FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);


ALTER TABLE qualification DROP COLUMN completion_year
ALTER TABLE qualification ADD completion_year int

--refer 'holds' table
--2
ALTER TABLE qualification
DROP CONSTRAINT pk_qualification
--3
ALTER TABLE qualification
ALTER COLUMN staff_id char(7) NOT NULL
--4
ALTER TABLE qualification
ADD CONSTRAINT pk_qualification PRIMARY KEY (staff_id,qualification_type)
-----------------------------------------------------------------------------------

CREATE TABLE holds(
	staff_id char(7),
	qualification_type varchar(20),
	
	CONSTRAINT pk_holds PRIMARY KEY (staff_id, qualification_type),
	CONSTRAINT fk_holds_s FOREIGN KEY (staff_id) REFERENCES staff (staff_id),
	CONSTRAINT fk_holds_q FOREIGN KEY (qualification_type) REFERENCES qualification (qualification_type)
	
); --staff holds qualification

--1
DROP TABLE holds 
-----------------------------------------------------------------------------------

CREATE TABLE termination(
	staff_id char(7),
	termination_no varchar(10),
	terminated_date date,
	reason varchar(255),
	final_payment real,
	paid bit,
	
	CONSTRAINT pk_termination PRIMARY KEY (termination_no),
	CONSTRAINT fk_termination FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
	
);
