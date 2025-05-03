USE master;
GO
DROP DATABASE IF EXISTS CollegeMS;
GO
CREATE DATABASE CollegeMS;
GO
USE CollegeMS;
GO


CREATE TABLE [Users] (
    [UserId] nvarchar(50) NOT NULL PRIMARY KEY,
    [UserPass] nvarchar(50) NOT NULL,
    [UserRole] nvarchar(50) NOT NULL
);


CREATE TABLE [Courses] (
    [CId] nvarchar(50) NOT NULL PRIMARY KEY,
    [CName] nvarchar(50) NOT NULL,
    [CDescription] nvarchar(50) NOT NULL,
    [CCredits] int NOT NULL,
    [StartDate] datetime NOT NULL,
    [EndDate] datetime NOT NULL
);


CREATE TABLE [Students] (
    [StId] nvarchar(50) NOT NULL PRIMARY KEY,
    [StName] nvarchar(50) NOT NULL,
    [StPhone] nvarchar(50) NOT NULL UNIQUE,
    [StEmail] nvarchar(50) NOT NULL UNIQUE,
    [StGender] nvarchar(50) NOT NULL,
    [StAddress] nvarchar(50) NOT NULL,
    [StBirth] datetime NOT NULL,
    [StPath] nvarchar(1000) NOT NULL,
    FOREIGN KEY ([StId]) REFERENCES [Users]([UserId]) ON DELETE CASCADE
);


CREATE TABLE [Lecturers] (
    [LeId] nvarchar(50) NOT NULL PRIMARY KEY,
    [LeName] nvarchar(50) NOT NULL,
    [LePhone] nvarchar(50) NOT NULL UNIQUE,
    [LeEmail] nvarchar(50) NOT NULL UNIQUE,
    [LeGender] nvarchar(50) NOT NULL,
    [LeAddress] nvarchar(50) NOT NULL,
    [LePath] nvarchar(MAX) NOT NULL,
    [LeBirth] datetime NOT NULL,
    FOREIGN KEY ([LeId]) REFERENCES [Users]([UserId]) ON DELETE CASCADE
);


CREATE TABLE [Students_Courses] (
    [StId] nvarchar(50) NOT NULL,
    [CId] nvarchar(50) NOT NULL,
    [Fee] decimal(10,2) NOT NULL,
    [Mark] decimal(10,2) NOT NULL,
    PRIMARY KEY ([StId], [CId]),
    FOREIGN KEY ([StId]) REFERENCES [Students]([StId]) ON DELETE CASCADE,
    FOREIGN KEY ([CId]) REFERENCES [Courses]([CId]) ON DELETE CASCADE
);


CREATE TABLE [Lecturers_Courses] (
    [LeId] nvarchar(50) NOT NULL,
    [CId] nvarchar(50) NOT NULL,
    PRIMARY KEY ([LeId], [CId]),
    FOREIGN KEY ([LeId]) REFERENCES [Lecturers]([LeId]) ON DELETE CASCADE,
    FOREIGN KEY ([CId]) REFERENCES [Courses]([CId]) ON DELETE CASCADE
);


CREATE TABLE [ReviewLecturers] (
    [ReviewId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [StId] nvarchar(50) NOT NULL,
    [LeId] nvarchar(50) NOT NULL,
    [CId] nvarchar(50) NOT NULL,
    [Comment] nvarchar(1000) NOT NULL,
    UNIQUE ([ReviewId], [StId], [LeId], [CId]),
    FOREIGN KEY ([StId]) REFERENCES [Students]([StId]) ON DELETE NO ACTION,
    FOREIGN KEY ([LeId]) REFERENCES [Lecturers]([LeId]) ON DELETE NO ACTION,
    FOREIGN KEY ([CId]) REFERENCES [Courses]([CId]) ON DELETE NO ACTION
);


CREATE TABLE [Problems] (
    [ProId] nvarchar(50) NOT NULL,
    [CourseId] nvarchar(50) NOT NULL,
    [StuId] nvarchar(50) NOT NULL,
    [Detail] nvarchar(1000) NOT NULL,
    PRIMARY KEY ([ProId], [CourseId], [StuId]),
    FOREIGN KEY ([CourseId]) REFERENCES [Courses]([CId]) ON DELETE CASCADE,
    FOREIGN KEY ([StuId]) REFERENCES [Students]([StId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Problems_StudentCourse] FOREIGN KEY ([StuId], [CourseId]) 
        REFERENCES [Students_Courses]([StId], [CId]) ON DELETE NO ACTION
);

INSERT INTO [Users] ([UserId], [UserPass], [UserRole]) VALUES
('U001', 'pass123', 'Admin'),
('S001', 'student1', 'Student'),
('S002', 'student2', 'Student'),
('S003', 'student3', 'Student'),
('S004', 'student4', 'Student'),
('S005', 'student5', 'Student'),
('L001', 'lecturer1', 'Lecturer'),
('L002', 'lecturer2', 'Lecturer'),
('L003', 'lecturer3', 'Lecturer'),
('L004', 'lecturer4', 'Lecturer'),
('L005', 'lecturer5', 'Lecturer');


INSERT INTO [Courses] ([CId], [CName], [CDescription], [CCredits], [StartDate], [EndDate]) VALUES
('CS101', 'Introduction to Programming', 'Basic programming concepts', 3, '2025-01-15', '2025-05-15'),
('CS201', 'Data Structures', 'Advanced data structures', 4, '2025-01-15', '2025-05-15'),
('MATH101', 'Calculus I', 'Limits, derivatives, and integrals', 4, '2025-01-15', '2025-05-15'),
('ENG101', 'English Composition', 'Writing and rhetoric', 3, '2025-01-15', '2025-05-15'),
('PHYS101', 'Physics I', 'Mechanics and thermodynamics', 4, '2025-01-15', '2025-05-15'),
('BIO101', 'Biology Fundamentals', 'Cell biology and genetics', 3, '2025-01-15', '2025-05-15');



INSERT INTO [Students] ([StId], [StName], [StPhone], [StEmail], [StGender], [StAddress], [StBirth], [StPath]) VALUES
('S001', 'John Smith', '123-456-7890', 'john.smith@email.com', 'Male', '123 Main St', '2000-05-15', ''),
('S002', 'Emma Johnson', '123-456-7891', 'emma.johnson@email.com', 'Female', '456 Oak Ave', '2001-03-22', ''),
('S003', 'Michael Brown', '123-456-7892', 'michael.brown@email.com', 'Male', '789 Pine Rd', '2000-11-08', ''),
('S004', 'Sophia Davis', '123-456-7893', 'sophia.davis@email.com', 'Female', '101 Elm Blvd', '2002-07-19', ''),
('S005', 'William Wilson', '123-456-7894', 'william.wilson@email.com', 'Male', '202 Maple Dr', '2001-09-30', '');



INSERT INTO [Lecturers] ([LeId], [LeName], [LePhone], [LeEmail], [LeGender], [LeAddress], [LePath], [LeBirth]) VALUES
('L001', 'Dr. Robert Chen', '987-654-3210', 'robert.chen@university.edu', 'Male', '101 Professor Ave', '', '1975-06-12'),
('L002', 'Dr. Patricia Miller', '987-654-3211', 'patricia.miller@university.edu', 'Female', '202 Academic Blvd', '', '1978-03-25'),
('L003', 'Dr. James Wilson', '987-654-3212', 'james.wilson@university.edu', 'Male', '303 Scholar St', '', '1970-11-18'),
('L004', 'Dr. Elizabeth Taylor', '987-654-3213', 'elizabeth.taylor@university.edu', 'Female', '404 Educator Rd', '', '1982-09-04'),
('L005', 'Dr. David Martin', '987-654-3214', 'david.martin@university.edu', 'Male', '505 Research Dr', '', '1973-12-30');



INSERT INTO [Students_Courses] ([StId], [CId], [Fee], [Mark]) VALUES
('S001', 'CS101', 1000.00, 85.0),
('S001', 'MATH101', 950.00, 78.5),
('S002', 'CS101', 1000.00, 88.0),
('S002', 'PHYS101', 1100.00, 90.0),
('S003', 'CS201', 1050.00, 75.0),
('S004', 'ENG101', 900.00, 92.0),
('S005', 'BIO101', 950.00, 86.5);


INSERT INTO [Lecturers_Courses] ([LeId], [CId]) VALUES
('L001', 'CS101'),
('L001', 'CS201'),
('L002', 'MATH101'),
('L003', 'PHYS101'),
('L004', 'ENG101'),
('L005', 'BIO101');



INSERT INTO [ReviewLecturers] ([StId], [LeId], [CId], [Comment]) VALUES
('S001', 'L001', 'CS101', 'Thay day de hieu.'),
('S002', 'L001', 'CS101', 'Giang vien vui tinh'),
('S003', 'L001', 'CS201', 'Giang bai hoi nhanh.'),
('S004', 'L004', 'ENG101', 'Thay dep trai'),
('S005', 'L005', 'BIO101', 'Co de thuong.');


INSERT INTO [Problems] ([ProId], [CourseId], [StuId], [Detail]) VALUES
('P001', 'CS101', 'S001', 'May tinh trong phong thuc hanh bi treo khi chay chuong trinh.'),
('P002', 'MATH101', 'S001', 'May chieu khong hoat dong trong tiet hoc.'),
('P003', 'CS101', 'S002', 'Ban phim khong nhan phim khi lam bai kiem tra.'),
('P004', 'CS201', 'S003', 'Phan mem lap trinh bi loi, khong chay duoc.'),
('P005', 'ENG101', 'S004', 'Loa trong phong hoc bi re, khong nghe ro am thanh.');
