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

            List<Instructor> repositoryContent = new List<Instructor>();

            mockrep.Setup(r => r.AddInstructor(testValidInstructor))
                   .Returns("")
                   .Callback<Instructor>(instructor => repositoryContent.Add(instructor));
            var actualResult = testInstructor.AddInstructor(testValidInstructor);

            Assert.AreEqual("Новый тренер успешно добавлен", actualResult);
            mockrep.Verify(r => r.AddInstructor(testValidInstructor), Times.Once);

            Assert.IsTrue(repositoryContent.Contains(testValidInstructor),
                "Тренер не был сохранен в репозитории");
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

            List<Instructor> repositoryContent = new List<Instructor>();

            mockrep.Setup(r => r.AddInstructor(It.IsAny<Instructor>()))
                   .Returns("")
                   .Callback<Instructor>(instructor => repositoryContent.Add(instructor));

            foreach (Instructor instructor in testInstructors)
            {
                string result = testInstructor.AddInstructor(instructor);
                Assert.AreEqual("Новый тренер успешно добавлен", result);
            }

            CollectionAssert.AreEqual(testInstructors.Select(i => i.FIO_Instructor).ToList(),
                                      repositoryContent.Select(i => i.FIO_Instructor).ToList(),
                                      "Списки инструкторов не совпадают");

            foreach (var expectedInstructor in testInstructors)
            {
                var actualInstructor = repositoryContent.FirstOrDefault(i =>
                    i.FIO_Instructor == expectedInstructor.FIO_Instructor);

                Assert.IsNotNull(actualInstructor);
                Assert.AreEqual(expectedInstructor.PhoneNumberInstructor, actualInstructor.PhoneNumberInstructor);
            }

            mockrep.Verify(r => r.AddInstructor(It.IsAny<Instructor>()), Times.Exactly(3));

            [TestMethod]
            public void DeleteInstructor_Success()
            {
                // Arrange
                var instructor = new Instructor();
                _mockStorage.Setup(s => s.DeleteInstructor(instructor))
                           .Returns("Тренер успешно удалён");

                // Act
                string result = _instructorManager.DeleteInstructor(instructor);

                // Assert
                Assert.AreEqual("Тренер успешно удалён", result, "Система должна сообщать об успехе операции удаления");

                [TestMethod]
                public void DeleteInstructor_Success_InstructorRemovedFromSystem()
                {
                    // Arrange
                    var instructor = new Instructor();
                    _mockStorage.Setup(s => s.DeleteInstructor(instructor))
                               .Returns("Тренер успешно удалён");

                    // Act
                    string result = _instructorManager.DeleteInstructor(instructor);

                    // Assert
                    _mockStorage.Verify(s => s.DeleteInstructor(instructor), Times.Once(),
                                       "Операция удаления должна быть вызвана один раз для указанного тренера");
                    Assert.AreEqual("Тренер успешно удалён", result, "Должно возвращаться сообщение об успешном удалении");
                }

                
                }
            }
        }
    }
}
