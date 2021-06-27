
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

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Porter', 'Harry', '132 Great Hayles Road', 
'BS14 0RY', '07801986058', '07801986058', '2021-06-21');

INSERT INTO Members(LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) values('Doe', 'Jane', '123 Address Street', 
'LC12 3ST', '07920310230', '07920310230', '2021-06-21');

create table mSessions(
	ID int primary key identity(1,1) not null,
	sessionID varchar(30) not null,
	sessionType varchar(30) not null,
	sessionDate date not null,
	sessionTime varchar(30) not null,
	memberID int foreign key references Members(PersonID)
)

/* example data */

insert into mSessions(sessionID, sessionType, sessionDate, sessionTime, memberID) values ('toddler/2021-06-26', 'toddler', '2021-06-26', '14:00', 1);

insert into mSessions(sessionID, sessionType, sessionDate, sessionTime, memberID) values ('openAccess/2021-06-26', 'openAccess', '2021-06-26', '16:00', 5);

insert into mSessions(sessionID, sessionType, sessionDate, sessionTime, memberID) values ('toddler/2021-06-26', 'toddler', '2021-06-26', '14:00', 4);

insert into mSessions(sessionID, sessionType, sessionDate, sessionTime, memberID) values ('openAccess/2021-06-26', 'openAccess', '2021-06-26', '16:00', 6);

/* query to select from both tables */

select [Members].[PersonID], FirstName, [Members].LastName , [mSessions].SessionType, [mSessions].SessionTime from Members inner join mSessions on [Members].PersonID = [mSessions].MemberID 
where [mSessions].SessionType = 'toddler';