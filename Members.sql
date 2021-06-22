
CREATE TABLE Members (
    PersonID int IDENTITY(1,1) primary key,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255) NOT NULL,
    HomeAddress varchar(255) NOT NULL,
    PostCode varchar(255) NOT NULL,
	ContactNum varchar(20) NOT NULL,
	EmergencyContact varchar(20) NOT NULL,
	StartYear Date NOT NULL
);

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Porter', 'Harry', '132 Great Hayles Road', 
'BS14 0RY', '07801986058', '07801986058', '2021-06-21');

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Doe', 'Jane', '123 Address Street', 
'LC12 3ST', '07920310230', '07920310230', '2021-06-21');
