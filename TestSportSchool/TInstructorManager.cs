using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportSchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSportSchool
{
    [TestClass]
    public class TInstructorManager
    {
        [TestMethod] 
        public void TestAddInstructor_validData()
        {
            var mockrep = new Mock<IInstructorManager>();
            var testInstructor = new InstructorManager(mockrep.Object);

            var testValidInstructor = new Instructor()
            {
                FIO_Instructor = "Петров Пётр Петрович",
                Qualification = qualification.Первая,
                PhoneNumberInstructor = "88005553535",
                Section = section.Спортивный_туризм
            };

            mockrep.Setup(r => r.AddInstructor(testValidInstructor)).Returns(true);
            var actualResult = testInstructor.AddInstructor(testValidInstructor);
            Assert.AreEqual("Новый тренер успешно добавлен", actualResult);
            mockrep.Verify(r => r.AddInstructor(testValidInstructor), Times.Once);
        }

        [TestMethod]
        [DataRow("", qualification.Первая, "88005553535", section.Спортивный_туризм, "Введите ФИО тренера")]
        [DataRow("Петров Пётр Петрович", (qualification)123, "88005553535", section.Спортивный_туризм, "Выберите квалификацию")]
        [DataRow("Петров Пётр Петрович", qualification.Первая, "88005553535", (section)789, "Выберите секцию")]
        public void TestAddInstructor_invalidData(string Fio, qualification qualif, string phone, section section, string expectedResult)
        {
            var mockrep = new Mock<IInstructorManager>();
            var testInstructor = new InstructorManager(mockrep.Object);

            var testInvalidInstructor = new Instructor()
            {
                FIO_Instructor = Fio,
                Qualification = qualif,
                PhoneNumberInstructor = phone,
                Section = section
            };

            var actualResult = testInstructor.AddInstructor(testInvalidInstructor);
            Assert.AreEqual(expectedResult, actualResult);
            mockrep.Verify(r => r.AddInstructor(testInvalidInstructor), Times.Never);
        }
    }
}
