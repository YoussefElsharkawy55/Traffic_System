Create database Traffic;
use Traffic;

create table Person(
	SSN char(14) UNIQUE NOT NULL,
    fname varchar(20) not null,
	lname varchar(20) not null,
	job varchar(20),
	Nationality varchar(20) default('egyptian'),
	person_addr varchar(50),
	blood_type char(3),
	dob date,
	primary key(ssn)
);

create table person_phones(
	ssn char(14) not null,
	phone char(11) UNIQUE NOT NULL,
	primary key(ssn, phone),
	foreign key(ssn) references Person(ssn) on delete cascade on update cascade
);


create table Vehicle(
	VIN char(8) UNIQUE NOT NULL,
	color varchar(10),
	year_made smallint,
	motor_no char(8),
	engine_size int,
	manufacturer varchar(30),
	vehicle_type char(12) check(vehicle_type in ('sedan', 'suv', 'small truck', 'large truck')),
	model varchar(30),
	owner_ssn char(14) not null,
	primary key (VIN),
	foreign key (owner_ssn) references person(ssn) on delete cascade on update cascade
);

create table Vehicle_license(
	License_plate varchar(12) UNIQUE NOT NULL,
	ROR varchar(20),
	DOR date,
	expiration_date date,
	VIN char(8) NOT NULL,
	primary key(License_plate),
	foreign key(VIN) references Vehicle(VIN) on delete cascade on update cascade
);

create table Driver_license(
	Degree smallint NOT NULL check(Degree in (1, 2, 3)),
	driver_ssn char(14) NOT NULL,
	ROR varchar(20),
	DOR date,
	expiration_date date,
	primary key(Degree, driver_ssn),
	foreign key(driver_ssn) references Person(ssn) on delete cascade on update cascade
);

create table violation_type(
	vtype varchar(20) UNIQUE NOT NULL,
	price float,
	primary key(vtype)
);

create table Violation(
	vstate varchar(10) NOT NULL,
	vtime time NOT NULL,
	vdate date NOT NULL,
	license_plate varchar(12) NOT NULL,
	vtype varchar(20) NOT NULL,
	primary key(vstate, vtime, vdate, license_plate),
	foreign key(license_plate) references Vehicle_license(license_plate) on delete cascade on update cascade,
	foreign key(vtype) references violation_type(vtype) on delete no action on update cascade
);

create table Drive_test(
	test_no int UNIQUE NOT NULL IDENTITY(1,1),
	region varchar(30),
	primary key(test_no)
);

create table test_applicants(
	app_ssn char(14) NOT NULL,
	test_no int NOT NULL,
	Degree smallint check(Degree in (1, 2, 3)),
	tstatus char(12) check(tstatus in('failed', 'succeeded', 'unevaluated')),
	primary key(app_ssn, test_no),
	foreign key(app_ssn) references person(ssn) on delete cascade on update cascade,
	foreign key(test_no) references drive_test(test_no) on delete cascade on update cascade
);
