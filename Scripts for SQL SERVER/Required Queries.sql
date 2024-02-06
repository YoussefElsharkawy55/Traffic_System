use traffic;

--Insert a new Drive Test
INSERT INTO Drive_test(region) values('CAIRO');

--Delete applicant with the ssn = 12142363254782 from table test_applicants:
DELETE from test_applicants 
	WHERE app_ssn = '12142363254782' and test_no = 7;
    
--Update the engine size to 6000 for the vehicle with VIN = 12143574
UPDATE vehicle set engine_size = 6000
	where VIN = '12143574';
    
--Select VIN, Manufacturere and model for each vehicle made in year 2004
SELECT VIN, manufacturer, model
	from vehicle
    where year_made = '2004';
    
--Count number of people live in Nasr City
SELECT count(*) as 'people in NC' from person
	where person_addr = 'nasr city';
    

--Select the max engine size and min engine size for all vehicles
select max(engine_size) as 'max motor #', min(engine_size) as 'min motor #'
	from vehicle;
    

--Select the VIN, Onwner fname and violation location for all seatbelt violation
select vehicle.VIN as VIN, fname as owner_name, Vstate
	from violation
    join vehicle_license
		on violation.License_plate = vehicle_license.License_plate
	join vehicle
		on vehicle.VIN = vehicle_license.VIN
	join person
		on vehicle.owner_ssn = person.ssn
	where vtype = 'seatbelt';
    
--Select Driver fname, job, license valid time and degree for all Driver licenses registered in CAIRO
select fname as driver_name, job, year(expiration_date) - year(DOR) as Valid_time, degree
	from driver_license
    join person
		on person.ssn = driver_license.driver_ssn
	where ROR = 'CAIRO';