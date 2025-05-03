USE master;
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
    [EndDate] datetime NOT NULL,
	[FeePerCredit] int,
	[Fee] int
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
	[StQRCodePath] nvarchar(max),
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
	[LeQRCodePath] nvarchar(max),
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

CREATE TABLE Problems (
    ProId NVARCHAR(50) PRIMARY KEY,
    CourseId NVARCHAR(50) NOT NULL,
    StuId NVARCHAR(50) NOT NULL,
    Detail NVARCHAR(500) NOT NULL,
    ReportedDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (CourseId) REFERENCES Courses(CId),
    FOREIGN KEY (StuId) REFERENCES Students(StId)
);

INSERT INTO [Users] ([UserId], [UserPass], [UserRole]) VALUES
('U001', 'pass123', 'admin'),
('S001', 'student1', 'student'),
('S002', 'student2', 'student'),
('S003', 'student3', 'student'),
('S004', 'student4', 'student'),
('S005', 'student5', 'student'),
('L001', 'lecturer1', 'lecturer'),
('L002', 'lecturer2', 'lecturer'),
('L003', 'lecturer3', 'lecturer'),
('L004', 'lecturer4', 'lecturer'),
('L005', 'lecturer5', 'lecturer');


INSERT INTO [Courses] ([CId], [CName], [CDescription], [CCredits], [StartDate], [EndDate], [FeePerCredit], [Fee]) VALUES
('CS101', 'Introduction to Programming', 'Basic programming concepts', 3, '2025-01-15', '2025-05-15',500,1500),
('CS201', 'Data Structures', 'Advanced data structures', 4, '2025-01-15', '2025-05-15',550,2200),
('MATH101', 'Calculus I', 'Limits, derivatives, and integrals', 4, '2025-01-15', '2025-05-15',600,2400),
('ENG101', 'English Composition', 'Writing and rhetoric', 3, '2025-01-15', '2025-05-15',650,1950),
('PHYS101', 'Physics I', 'Mechanics and thermodynamics', 4, '2025-01-15', '2025-05-15',700,2800),
('BIO101', 'Biology Fundamentals', 'Cell biology and genetics', 3, '2025-01-15', '2025-05-15',750,2250);



INSERT INTO [Students] ([StId], [StName], [StPhone], [StEmail], [StGender], [StAddress], [StBirth], [StPath], [StQRCodePath]) VALUES
('S001', 'John Smith', '123-456-7890', 'john.smith@email.com', 'Male', '123 Main St', '2000-05-15', 'Aubameyang.jpg', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\SinhVien\S001.png'),
('S002', 'Emma Johnson', '123-456-7891', 'emma.johnson@email.com', 'Female', '456 Oak Ave', '2001-03-22', 'cr7.jpg', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\SinhVien\S002.png'),
('S003', 'Michael Brown', '123-456-7892', 'michael.brown@email.com', 'Male', '789 Pine Rd', '2000-11-08', 'Fred.jpg', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\SinhVien\S003.png'),
('S004', 'Sophia Davis', '123-456-7893', 'sophia.davis@email.com', 'Female', '101 Elm Blvd', '2002-07-19', 'lukaku.jpg', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\SinhVien\S004.png'),
('S005', 'William Wilson', '123-456-7894', 'william.wilson@email.com', 'Male', '202 Maple Dr', '2001-09-30', 'RonaldoBeo.jpg', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\SinhVien\S005.png');


INSERT INTO [Lecturers] ([LeId], [LeName], [LePhone], [LeEmail], [LeGender], [LeAddress], [LePath], [LeBirth], [LeQRCodePath]) VALUES
('L001', 'Dr. Robert Chen', '987-654-3210', 'robert.chen@university.edu', 'Male', '101 Professor Ave', 'ArseneWenger.jpg', '1975-06-12', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\GiangVien\L001.png'),
('L002', 'Dr. Patricia Miller', '987-654-3211', 'patricia.miller@university.edu', 'Female', '202 Academic Blvd', 'AlexFerguson.jpg', '1978-03-25', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\GiangVien\L002.png'),
('L003', 'Dr. James Wilson', '987-654-3212', 'james.wilson@university.edu', 'Male', '303 Scholar St', 'PepGuardiola.jpg', '1970-11-18', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\GiangVien\L003.png'),
('L004', 'Dr. Elizabeth Taylor', '987-654-3213', 'elizabeth.taylor@university.edu', 'Female', '404 Educator Rd', 'WalterWhite.jpg', '1982-09-04', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\GiangVien\L004.png'),
('L005', 'Dr. David Martin', '987-654-3214', 'david.martin@university.edu', 'Male', '505 Research Dr', 'ErikTenHag.jpg', '1973-12-30', 'D:\LTCSDL\OtherFile\Bao3\CollegeManagementSystem\QRCode\GiangVien\L005.png');

INSERT INTO [Students_Courses] ([StId], [CId], [Fee], [Mark]) VALUES 
('S001', 'CS101', 1500.00, 85.0),
('S001', 'MATH101', 2400.00, 78.5),
('S002', 'CS101', 1500.00, 88.0),
('S002', 'PHYS101', 2800.00, 90.0),
('S003', 'CS201', 2200.00, 75.0),
('S004', 'ENG101', 1950.00, 92.0),
('S005', 'BIO101', 2250.00, 86.5);


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


INSERT INTO [Problems] ([ProId], [CourseId], [StuId], [Detail], [ReportedDate]) VALUES 
('P001', 'CS101', 'S001', 'May tinh trong phong thuc hanh bi treo khi chay chuong trinh.', GETDATE()),
('P002', 'MATH101', 'S001', 'May chieu khong hoat dong trong tiet hoc.', GETDATE()),
('P003', 'CS101', 'S002', 'Ban phim khong nhan phim khi lam bai kiem tra.', GETDATE()),
('P004', 'CS201', 'S003', 'Phan mem lap trinh bi loi, khong chay duoc.', GETDATE()),
('P005', 'ENG101', 'S004', 'Loa trong phong hoc bi re, khong nghe ro am thanh.', GETDATE());
