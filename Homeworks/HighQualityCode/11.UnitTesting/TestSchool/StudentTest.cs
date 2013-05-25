using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ConstructorName_IsNameCorrect()
        {
            Student student = new Student("Bill Gates", 11111);
            Assert.AreEqual("Bill Gates", student.Name);
        }

        [TestMethod]
        public void ConstructorNumber_IsNumberCorrect()
        {
            Student student = new Student("Bill Gates", 11111);
            Assert.AreEqual(11111, student.Number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorName_NameIsNotEmptyString()
        {
            Student student = new Student("", 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorName_NameIsNotNull()
        {
            Student student = new Student(null, 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorNumber_NumberIsNotInBottomRange()
        {
            Student student = new Student("Bill Gates", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorNumber_NumberIsNotInTopRange()
        {
            Student student = new Student("Bill Gates", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorNumber_NumberIsNotZero()
        {
            Student student = new Student("Bill Gates", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorNumber_NumberIsNotNegative()
        {
            Student student = new Student("Bill Gates", -123);
        }

        [TestMethod]
        public void OvverideToString_IsToStringInCorrectFormat()
        {
            Student student = new Student("Bill Gates", 12345);
            string actual = student.ToString();
            string expected = "Student's name: Bill Gates, ID: 12345";
            Assert.AreEqual(expected, actual);
        }
    }
}
