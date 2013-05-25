using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void ConstructorCourse_Name()
        {
            Course course = new Course("Rocket Science", new List<Student>() { new Student("Bill", 11111), new Student("Mark", 99999) });
            Assert.AreEqual("Rocket Science", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorCourse_NameIsNotNull()
        {
            Course course = new Course(null, new List<Student>() { new Student("Bill", 11111), new Student("Mark", 99999) });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorCourse_NameIsNotEmptyString()
        {
            Course course = new Course("", new List<Student>() { new Student("Bill", 11111), new Student("Mark", 99999) });
        }

        [TestMethod]
        public void ConstructorCourse_ListIsCountOne()
        {
            List<Student> students = new List<Student>() { new Student("Bill", 11111) };
            Course course = new Course("Rocket Science", students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorCourse_ListIsNotCountZero()
        {
            List<Student> students = new List<Student>();
            Course course = new Course("Rocket Science", students);
        }

        [TestMethod]
        public void AddNewStudentsToCourse_Is29MaxStudentsCount()
        {
            List<Student> students = new List<Student>() { new Student("Bill", 11111) };
            Course course = new Course("Rocket Science", students);

            int count = 28;
            for (int i = 0; i < count; i++)
            {
                course.AddNewStudentsToCourse(new Student("Bill", 11111 + i * 2 + 1));
            }

            Assert.AreEqual(course.MaxStudentsCount, students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddNewStudentsToCourse_Is30MaxStudentsCountInvalid()
        {
            List<Student> students = new List<Student>() { new Student("Bill", 11111) };
            Course course = new Course("Rocket Science", students);

            int count = 29;
            for (int i = 0; i < count; i++)
            {
                course.AddNewStudentsToCourse(new Student("Bill", 11111 + i * 2 + 1));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnsignStudentFromCourse_CanunsignStudentNotInTheList()
        {
            List<Student> students = new List<Student>() { new Student("Bill", 11001) };
            Course course = new Course("Rocket Science", students);

            int count = 20;
            for (int i = 0; i < count; i++)
            {
                course.AddNewStudentsToCourse(new Student("Bill", 11111 + i * 2 + 1));
            }
            course.UnsignStudentFromCourse(new Student("Zuckerburg", 11111));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddNewStudentsToCourse_SameNumberStudentsAdd()
        {
            List<Student> students = new List<Student>() { new Student("Bill", 11111) };
            Course course = new Course("Rocket Science", students);
            course.AddNewStudentsToCourse(new Student("Bill", 11111 ));
        }
    }
}
