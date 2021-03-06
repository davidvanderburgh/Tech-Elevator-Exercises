USE [master]
GO
/****** Object:  Database [Employee]    Script Date: 2/15/2019 4:53:02 PM ******/
CREATE DATABASE [Employee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Employee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Employee.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Employee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Employee_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Employee] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Employee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Employee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Employee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Employee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Employee] SET ARITHABORT OFF 
GO
ALTER DATABASE [Employee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Employee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Employee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Employee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Employee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Employee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Employee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Employee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Employee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Employee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Employee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Employee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Employee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Employee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Employee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Employee] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Employee] SET  MULTI_USER 
GO
ALTER DATABASE [Employee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Employee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Employee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Employee] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Employee] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Employee] SET QUERY_STORE = OFF
GO
USE [Employee]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Employee]
GO
/****** Object:  Table [dbo].[department]    Script Date: 2/15/2019 4:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_department] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department_employee]    Script Date: 2/15/2019 4:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department_employee](
	[department_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
 CONSTRAINT [PK_department_employee] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC,
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2/15/2019 4:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[job_title] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[birthday] [datetime] NOT NULL,
	[hire_date] [datetime] NOT NULL,
 CONSTRAINT [pk_employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_project]    Script Date: 2/15/2019 4:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_project](
	[employee_id] [int] NOT NULL,
	[project_id] [int] NOT NULL,
 CONSTRAINT [PK_employee_project] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC,
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project]    Script Date: 2/15/2019 4:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project](
	[project_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[start_date] [datetime] NOT NULL,
 CONSTRAINT [pk_project] PRIMARY KEY CLUSTERED 
(
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[department] ON 

INSERT [dbo].[department] ([department_id], [name]) VALUES (1, N'Sales')
INSERT [dbo].[department] ([department_id], [name]) VALUES (2, N'HR')
INSERT [dbo].[department] ([department_id], [name]) VALUES (3, N'Software')
SET IDENTITY_INSERT [dbo].[department] OFF
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (1, 1)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (1, 4)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (1, 9)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (1, 10)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (2, 7)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (2, 8)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (3, 5)
INSERT [dbo].[department_employee] ([department_id], [employee_id]) VALUES (3, 11)
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (1, N'Sales rep', N'Geraldo', N'Bob', N'Male', CAST(N'1995-10-27T00:00:00.000' AS DateTime), CAST(N'2010-10-01T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (4, N'Sales rep', N'Anne', N'Anna', N'Female', CAST(N'1970-10-20T00:00:00.000' AS DateTime), CAST(N'1998-01-20T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (5, N'Software guru', N'Finn', N'Dewey', N'Male', CAST(N'1980-04-15T00:00:00.000' AS DateTime), CAST(N'2000-08-02T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (7, N'Hiring manager', N'Liz', N'Beth', N'Female', CAST(N'1998-07-03T00:00:00.000' AS DateTime), CAST(N'1998-07-04T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (8, N'Firing manager', N'Gerk', N'Ima', N'Male', CAST(N'1982-10-28T00:00:00.000' AS DateTime), CAST(N'2018-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (9, N'Accounts Rep', N'Gold', N'Likade', N'Female', CAST(N'1940-10-10T00:00:00.000' AS DateTime), CAST(N'2013-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (10, N'BA', N'McFly', N'Smarty', N'Male', CAST(N'2018-04-02T00:00:00.000' AS DateTime), CAST(N'2019-04-04T00:00:00.000' AS DateTime))
INSERT [dbo].[employee] ([employee_id], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date]) VALUES (11, N'Software newb', N'Vandy', N'Davey', N'Male', CAST(N'1985-10-27T00:00:00.000' AS DateTime), CAST(N'2019-04-25T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[employee] OFF
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (1, 2)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (4, 3)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (5, 4)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (7, 1)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (8, 1)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (9, 2)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (10, 3)
INSERT [dbo].[employee_project] ([employee_id], [project_id]) VALUES (11, 4)
SET IDENTITY_INSERT [dbo].[project] ON 

INSERT [dbo].[project] ([project_id], [name], [start_date]) VALUES (1, N'The big one', CAST(N'2000-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[project] ([project_id], [name], [start_date]) VALUES (2, N'Consultation', CAST(N'2001-10-04T00:00:00.000' AS DateTime))
INSERT [dbo].[project] ([project_id], [name], [start_date]) VALUES (3, N'Consultation', CAST(N'2002-10-04T00:00:00.000' AS DateTime))
INSERT [dbo].[project] ([project_id], [name], [start_date]) VALUES (4, N'New score', CAST(N'2018-03-03T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[project] OFF
ALTER TABLE [dbo].[department_employee]  WITH CHECK ADD  CONSTRAINT [fk_department_employee_department] FOREIGN KEY([department_id])
REFERENCES [dbo].[department] ([department_id])
GO
ALTER TABLE [dbo].[department_employee] CHECK CONSTRAINT [fk_department_employee_department]
GO
ALTER TABLE [dbo].[department_employee]  WITH CHECK ADD  CONSTRAINT [fk_department_employee_employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
ALTER TABLE [dbo].[department_employee] CHECK CONSTRAINT [fk_department_employee_employee]
GO
ALTER TABLE [dbo].[employee_project]  WITH CHECK ADD  CONSTRAINT [fk_employee_project_employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
ALTER TABLE [dbo].[employee_project] CHECK CONSTRAINT [fk_employee_project_employee]
GO
ALTER TABLE [dbo].[employee_project]  WITH CHECK ADD  CONSTRAINT [fk_employee_project_project_id] FOREIGN KEY([project_id])
REFERENCES [dbo].[project] ([project_id])
GO
ALTER TABLE [dbo].[employee_project] CHECK CONSTRAINT [fk_employee_project_project_id]
GO
USE [master]
GO
ALTER DATABASE [Employee] SET  READ_WRITE 
GO
