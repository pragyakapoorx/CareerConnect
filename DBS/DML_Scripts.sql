INSERT INTO Company VALUES ('C001', 'TechCorp', 'IT', 'New York');
INSERT INTO Company VALUES ('C002', 'FinServe', 'Finance', 'San Francisco');
INSERT INTO Company VALUES ('C003', 'EduWorld', 'Education', 'Boston');
INSERT INTO Company VALUES ('C004', 'MediCare', 'Healthcare', 'Chicago');
INSERT INTO Company VALUES ('C005', 'CodeBase', 'IT', 'Seattle');

INSERT INTO Job VALUES ('J001', 'C001', 'Software Engineer', 'Develops software solutions', 70000, 120000);
INSERT INTO Job VALUES ('J002', 'C002', 'Financial Analyst', 'Analyzes financial data', 60000, 100000);
INSERT INTO Job VALUES ('J003', 'C003', 'Teacher', 'Teaches high school students', 40000, 70000);
INSERT INTO Job VALUES ('J004', 'C004', 'Nurse', 'Provides medical assistance', 50000, 90000);
INSERT INTO Job VALUES ('J005', 'C005', 'Data Scientist', 'Analyzes big data', 80000, 150000);

INSERT INTO Users VALUES ('U001', 'Alice Johnson', 'Female', '12-JUN-1995', 'alice123');
INSERT INTO Users VALUES ('U002', 'Bob Smith', 'Male', '25-APR-1990', 'bobpass');
INSERT INTO Users VALUES ('U003', 'Charlie Adams', 'Male', '30-NOV-1988', 'charlie88');
INSERT INTO Users VALUES ('U004', 'Diana Moore', 'Female', '19-AUG-1993', 'dianaM');
INSERT INTO Users VALUES ('U005', 'Ethan Brown', 'Male', '05-JAN-1997', 'ethanB');

INSERT INTO Users VALUES ('U1001', 'Mary Kate', 'Female', '12-JUN-1995', 'maryk', 'Employer');
INSERT INTO Users VALUES ('U1002', 'Elliott Smith', 'Male', '25-APR-1990', 'ellio', 'Employer');
INSERT INTO Users VALUES ('U1003', 'James Mackerson', 'Male', '30-NOV-1988', 'jamesM', 'Employer');
INSERT INTO Users VALUES ('U1004', 'Olivia Smith', 'Female', '19-AUG-1993', 'oliviaS', 'Employer');
INSERT INTO Users VALUES ('U1005', 'Barry Avoy', 'Male', '05-JAN-1997', 'barryM', 'Employer');

INSERT INTO Employers VALUES ('U1001', 'C001');
INSERT INTO Employers VALUES ('U1002', 'C002');
INSERT INTO Employers VALUES ('U1003', 'C003');
INSERT INTO Employers VALUES ('U1004', 'C004');
INSERT INTO Employers VALUES ('U1005', 'C005');

INSERT INTO Application VALUES ('A001', 'U001', 'C001', 'J001', '01-MAR-2024', 'Pending');
INSERT INTO Application VALUES ('A002', 'U002', 'C002', 'J002', '02-MAR-2024', 'Accepted');
INSERT INTO Application VALUES ('A003', 'U003', 'C003', 'J003', '03-MAR-2024', 'Rejected');
INSERT INTO Application VALUES ('A004', 'U004', 'C004', 'J004', '04-MAR-2024', 'Pending');
INSERT INTO Application VALUES ('A005', 'U005', 'C005', 'J005', '05-MAR-2024', 'Accepted');


INSERT INTO Interview VALUES ('I001', 'A001', 'U001', 'C001', 'J001');
INSERT INTO Interview VALUES ('I002', 'A002', 'U002', 'C002', 'J002');
INSERT INTO Interview VALUES ('I003', 'A003', 'U003', 'C003', 'J003');
INSERT INTO Interview VALUES ('I004', 'A004', 'U004', 'C004', 'J004');
INSERT INTO Interview VALUES ('I005', 'A005', 'U005', 'C005', 'J005');


INSERT INTO RecruitmentProcess VALUES ('J001', 'C001', 50, 10, 30, 5, 15);
INSERT INTO RecruitmentProcess VALUES ('J002', 'C002', 40, 8, 25, 4, 12);
INSERT INTO RecruitmentProcess VALUES ('J003', 'C003', 30, 5, 20, 3, 10);
INSERT INTO RecruitmentProcess VALUES ('J004', 'C004', 35, 7, 22, 4, 11);
INSERT INTO RecruitmentProcess VALUES ('J005', 'C005', 60, 12, 40, 6, 20);

INSERT INTO HiringMetrics VALUES ('M001', 'J001', 'C001', 7, 0.50);
INSERT INTO HiringMetrics VALUES ('M002', 'J002', 'C002', 10, 0.40);
INSERT INTO HiringMetrics VALUES ('M003', 'J003', 'C003', 5, 0.60);
INSERT INTO HiringMetrics VALUES ('M004', 'J004', 'C004', 8, 0.55);
INSERT INTO HiringMetrics VALUES ('M005', 'J005', 'C005', 6, 0.70);


INSERT INTO Notifications VALUES ('N001', 'U001', 'Your application is under review', '06-MAR-2024');
INSERT INTO Notifications VALUES ('N002', 'U002', 'Congratulations, you got the job!', '07-MAR-2024');
INSERT INTO Notifications VALUES ('N003', 'U003', 'Your application was rejected', '08-MAR-2024');
INSERT INTO Notifications VALUES ('N004', 'U004', 'Interview scheduled for 10 AM', '09-MAR-2024');
INSERT INTO Notifications VALUES ('N005', 'U005', 'Your job offer has been sent', '10-MAR-2024');

SELECT * FROM Company;
SELECT * FROM Users;
SELECT * FROM Employers;
SELECT * FROM Job;
SELECT * FROM Application;
SELECT * FROM Interview;
SELECT * FROM RecruitmentProcess;
SELECT * FROM HiringMetrics;
SELECT * FROM Notifications;