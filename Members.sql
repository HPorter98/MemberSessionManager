
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

/* example data */

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Bishop', 'John', '44 North End Road', 
'BL32 5AH', '07730365221', '07801986058', '2021-06-21');

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Doe', 'Jane', '123 Address Street', 
'LC12 3ST', '07920310230', '07920310230', '2021-06-21');

create table SessionDetails(
	SessionID varchar(50) primary key,
	SessionStartTime varchar(5),
	SessionEndTime varchar(5),
	SessionDate date,
	SessionType varchar(30)
)

create table MemberSession(
	ID int primary key identity(1,1),
	SessionID varchar(50) foreign key references SessionDetails(SessionID),
	PersonID int not null,
	FirstName varchar(50) not null,
	LastName varchar(50) not null
)
