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

        [TestMethod]
        public void TestAddFewInstructors_validData()
        {
            var mockrep = new Mock<IInstructorManager>();
            var testInstructor = new InstructorManager(mockrep.Object);

            List<Instructor> testInstructors = new List<Instructor>()
            {
                new Instructor()
                {
                    FIO_Instructor = "Петров Пётр Петрович",
                    Qualification = qualification.Первая,
                    PhoneNumberInstructor = "88005553535",
                    Section = section.Спортивный_туризм
                },
                new Instructor()
                {
                    FIO_Instructor = "Иванов Иван Иванович",
                    Qualification = qualification.Высшая,
                    PhoneNumberInstructor = "88001112233",
                    Section = section.Гребля
                },
                new Instructor()
                {
                    FIO_Instructor = "Дмитров Дмитрий Дмитриевич",
                    Qualification = qualification.Вторая,
                    PhoneNumberInstructor = "88007778899",
                    Section = section.Скалолазание
                }
            };

            foreach (var instructor in testInstructors)
            {
                mockrep.Setup(r => r.AddInstructor(instructor)).Returns(true);
            }

            for (int i = 0; i < testInstructors.Count; i++)
            {
                string actualResult = testInstructor.AddInstructor(testInstructors[i]);
                Assert.AreEqual("Новый тренер успешно добавлен", actualResult);
            }

            foreach (var instructor in testInstructors)
            {
                mockrep.Verify(r => r.AddInstructor(instructor), Times.Once);
            }
        }
    }
}
