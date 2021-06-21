
CREATE TABLE Members (
    PersonID int IDENTITY(1,1) primary key,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255) NOT NULL,
    HomeAddress varchar(255) NOT NULL,
    PostCode varchar(255) NOT NULL,
	ContactNum bigint NOT NULL,
	EmergencyContact bigint NOT NULL,
	StartYear Date NOT NULL
);

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Porter', 'Harry', '132 Great Hayles Road', 
'BS14 0RY', 07801986058, 07801986058, '2021-06-21');
