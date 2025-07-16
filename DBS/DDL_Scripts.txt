CREATE TABLE Company(CompanyID varchar(5), Name varchar(20), Industry varchar(20) CHECK(Industry IN('IT', 'Finance', 'Education', 'Healthcare')), Location varchar(30), PRIMARY KEY(CompanyID));

CREATE TABLE Job(JobID varchar(5), CompanyID varchar(5), Title varchar(20), Description varchar(100), MinPay int CHECK(MinPay>0), MaxPay int, PRIMARY KEY(JobID, CompanyID), FOREIGN KEY(CompanyID) REFERENCES Company(CompanyID), CHECK(MaxPay>MinPay));

CREATE TABLE Users(UserID varchar(5), Name varchar(20), Gender varchar(6) CHECK(Gender='Female' OR Gender='Male'), DoB date, Password varchar(15), Role varchar(10) CHECK(Role IN('Job Seeker', 'Employer')), PRIMARY KEY(UserID));

CREATE TABLE Employers(UserID varchar(5), CompanyID varchar(5), PRIMARY KEY(UserID, CompanyID), FOREIGN KEY(CompanyID) REFERENCES Company(CompanyID), FOREIGN KEY(UserID) REFERENCES Users(UserID));

CREATE TABLE Application(ApplicationID varchar(5), UserID varchar(5), CompanyID varchar(5), JobID varchar(5), ApplicationDate date, Status varchar(10) CHECK(Status IN('Accepted', 'Rejected', 'Pending'), PRIMARY KEY(ApplicationID, UserID, CompanyID, JobID), FOREIGN KEY(UserID) REFERENCES Users, FOREIGN KEY(JobID, CompanyID) REFERENCES Job(JobID, CompanyID));

CREATE TABLE Interview(InterviewID varchar(5), ApplicationID varchar(5), UserID varchar(5), CompanyID varchar(5), JobID varchar(5), PRIMARY KEY(InterviewID, ApplicationID), FOREIGN KEY(ApplicationID, UserID, CompanyID, JobID) REFERENCES Application(ApplicationID, UserID, CompanyID, JobID));

CREATE TABLE RecruitmentProcess(JobID varchar(5), CompanyID varchar(5), ApplicationsReceived int, OffersMade int, Interviewed int, Hired int, Shortlisted int, PRIMARY KEY(JobID), FOREIGN KEY(JobID, CompanyID) REFERENCES Job(JobID, CompanyID));

CREATE TABLE HiringMetrics(MetricID varchar(5), JobID varchar(5), CompanyID varchar(5), AvgResponseTime int, SuccessRate numeric(3,2), PRIMARY KEY(JobID, MetricID), FOREIGN KEY(JobID, CompanyID) REFERENCES Job(JobID, CompanyID));

CREATE TABLE Notifications(NotificationID varchar(5), UserID varchar(5), Message varchar(50), DateSent date, PRIMARY KEY(NotificationID, UserID), FOREIGN KEY(UserID) REFERENCES Users);