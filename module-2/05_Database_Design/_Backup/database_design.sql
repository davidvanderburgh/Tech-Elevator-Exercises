

BEGIN TRANSACTION;

CREATE TABLE employee
(
	employee_id			int					identity(1,1),
	job_title			nvarchar(50)		not null,
	last_name			nvarchar(50)		not null,
	first_name			nvarchar(50)		not null,
	gender				nvarchar(10)		not null,
	birthday			datetime			not null,
	hire_date			datetime			not null,
	
	constraint pk_employee primary key (employee_id)
);

CREATE TABLE department
(
	department_id		int					identity(1,1),
	name				nvarchar(50)		not null,
	
	constraint pk_department primary key (department_id)
	
);

CREATE TABLE project
(
	project_id			int					identity(1,1),
	name				nvarchar(50)		not null,
	start_date			datetime			not null,
	
	constraint pk_project primary key (project_id)
);

CREATE TABLE department_employee
(
	department_id		int					not null,
	employee_id			int					not null,
	
	constraint fk_department_employee_department foreign key (department_id) references department(department_id),
	constraint fk_department_employee_employee foreign key (employee_id) references employee(employee_id)
);

CREATE TABLE employee_project
(
	employee_id			int					not null,
	project_id		int					not null,
	
	constraint fk_employee_project_employee foreign key (employee_id) references employee (employee_id),
	constraint fk_employee_project_project_id foreign key (project_id) references project (project_id)
);

COMMIT TRANSACTION