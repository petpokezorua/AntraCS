using System;
using System.Collections.Generic;

namespace OOPDemo
{
    // Abstraction:
    public interface IPersonService
    {
        int CalculateAge();
        void AddAddress(string address);
        List<string> GetAddresses();
    }

    public interface IStudentService : IPersonService
    {
        void EnrollInCourse(Course course);
        double CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        decimal CalculateSalary();
    }

    // Abstraction: Base class Person
    public abstract class Person : IPersonService
    {
        private string _name;
        private DateTime _dateOfBirth;
        private List<string> _addresses = new List<string>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public Person(string name, DateTime dateOfBirth)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - _dateOfBirth.Year;
        }

        public void AddAddress(string address)
        {
            _addresses.Add(address);
        }

        public List<string> GetAddresses()
        {
            return _addresses;
        }
    }

    // Inheritance: Student class inherits from Person
    public class Student : Person, IStudentService
    {
        private List<Course> _courses = new List<Course>();
        private Dictionary<Course, char> _grades = new Dictionary<Course, char>();

        public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth) { }

        public void EnrollInCourse(Course course)
        {
            _courses.Add(course);
            course.EnrollStudent(this);
        }

        public void AddGrade(Course course, char grade)
        {
            if (_courses.Contains(course))
            {
                _grades[course] = grade;
            }
        }

        public double CalculateGPA()
        {
            double totalPoints = 0;
            int totalCourses = _grades.Count;

            foreach (var grade in _grades.Values)
            {
                totalPoints += GradeToPoint(grade);
            }

            return totalCourses > 0 ? totalPoints / totalCourses : 0;
        }

        private double GradeToPoint(char grade)
        {
            return grade switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => 0.0
            };
        }
    }

    // Inheritance: Instructor class inherits from Person
    public class Instructor : Person, IInstructorService
    {
        public Department Department { get; set; }
        public DateTime JoinDate { get; set; }
        private decimal _baseSalary;

        public Instructor(string name, DateTime dateOfBirth, decimal baseSalary, DateTime joinDate)
            : base(name, dateOfBirth)
        {
            _baseSalary = baseSalary;
            JoinDate = joinDate;
        }

        public decimal CalculateSalary()
        {
            int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
            decimal bonus = yearsOfExperience * 1000; // Example bonus calculation, 1 year = $1000
            return _baseSalary + bonus;
        }
    }

    // Course class
    public class Course
    {
        public string Name { get; set; }
        private List<Student> _enrolledStudents = new List<Student>();

        public Course(string name)
        {
            Name = name;
        }

        public void EnrollStudent(Student student)
        {
            _enrolledStudents.Add(student);
        }

        public List<Student> GetEnrolledStudents()
        {
            return _enrolledStudents;
        }
    }

    // Department class
    public class Department
    {
        public string Name { get; set; }
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public Department(string name, decimal budget)
        {
            Name = name;
            Budget = budget;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department csDepartment = new Department("Computer Science", 50000);

            Instructor instructor = new Instructor("Dr. Smith", new DateTime(1980, 5, 15), 60000, new DateTime(2010, 8, 1));
            csDepartment.Head = instructor;

            Course course1 = new Course("Data Structures");
            Course course2 = new Course("Algorithms");
            csDepartment.AddCourse(course1);
            csDepartment.AddCourse(course2);

            Student student = new Student("Alice", new DateTime(2002, 3, 10));
            student.EnrollInCourse(course1);
            student.EnrollInCourse(course2);

            student.AddGrade(course1, 'A');
            student.AddGrade(course2, 'B');

            Console.WriteLine($"Department: {csDepartment.Name}");
            Console.WriteLine($"Head: {csDepartment.Head.Name}");
            Console.WriteLine($"Instructor Salary: {instructor.CalculateSalary():C}");

            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Age: {student.CalculateAge()}");
            Console.WriteLine($"GPA: {student.CalculateGPA():F2}");
        }
    }
}