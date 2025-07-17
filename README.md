# CareerConnect

**Job Portal & Applicant Management System**

CareerConnect is a database-driven job portal designed to streamline job applications for seekers, while giving employers powerful tools to manage postings and analyze hiring processes. Through intuitive interfaces and structured SQL-backed data analysis, this project aims to modernize recruitment workflows and enhance data-driven hiring decisions.

---

## 🚀 Features

- Role-based user management (job seekers and employers)
- Job posting and editing functionalities
- Application tracking for candidates
- Company profiles and recruitment analytics
- Interview scheduling and process tracking
- Real-time notifications and alerts
- Insightful hiring metrics via SQL queries

---

## 🧩 Project Modules

| Module               | Description                                                                                      | Entity Schema |
|----------------------|--------------------------------------------------------------------------------------------------|---------------|
| **User Management**  | Handles registration, login, and access controls for both seekers and employers                  | `Users(UserID, Name, Email, Password, Role)` |
| **Job Management**   | Employers can create, update, and manage listings                                                | `Jobs(JobID, CompanyID, Title, Description, PostedDate, Status)` |
| **Applications**     | Job seekers can apply, monitor, and manage job applications                                     | `Applications(ApplicationID, UserID, JobID, AppliedDate, Status)` |
| **Company Module**   | Stores company data and hiring behavior insights                                                 | `Companies(CompanyID, Name, Industry, ResponseTime, Location)` |
| **Hiring Metrics**   | Tracks and analyzes trends like success rates and employer responsiveness                        | `HiringMetrics(MetricID, JobID, ApplicationsReceived, AvgResponseTime, SuccessRate)` |
| **Notifications**    | Sends alerts to users regarding jobs and application updates                                     | `Notifications(NotificationID, UserID, Message, DateSent)` |
| **Interviews**       | Schedules interviews and monitors interview statuses                                             | `Interviews(InterviewID, ApplicationID, DateTime, Status)` |
| **Recruitment Flow** | Tracks applications through stages—from applied to hired                                         | `RecruitmentProcess(JobID, ApplicationsReceived, Shortlisted, Interviewed, OffersMade, Hired)` |

---

## 🛠️ Technologies Used

- **Frontend:** Visual Studio
- **Backend:** Oracle Database XE
- **Languages:** C#, SQL

---

## 📈 Data-Driven Insights

This system employs SQL-driven analysis to provide actionable hiring recommendations, surface application trends, and measure employer responsiveness. It supports scalable recruitment operations with transparent metrics.

---
---

## 🖼️ Screenshots

Visual glimpses of the CareerConnect interface and workflows.

| Feature                           | Screenshot |
|----------------------------------|------------|
| 👤 **User Sign In** | ![Sign In](<img width="1567" height="957" alt="SignIn" src="https://github.com/user-attachments/assets/1664c1f6-de0a-4b4b-b962-d7291d7c9efd" />) |
| 👤 **User Sign UP** | ![Sign Up](<img width="1443" height="747" alt="SignUp" src="https://github.com/user-attachments/assets/592d62a2-4a0f-470e-b618-6bc20a7ba9fe" />) |



---
