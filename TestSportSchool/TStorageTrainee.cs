using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportSchoolLib;

namespace TestSportSchool
{
    [TestClass]
    public class TStorageTrainee
    {
        [TestMethod]
        public void TestAddTrainee_validData()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testValidTrainee = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 1, 1),
                Section = section.Спортивный_туризм,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            mockRep.Setup(r => r.Id_TraineeExists(1))
                   .Returns(false);
            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Ученик успешно добавлен", actualResult, "При успешном добавлении возвращается: Ученик успешно добавлен");
            mockRep.Verify(r => r.AddTrainee(testValidTrainee), Times.Once);
        }
        [TestMethod]
        [DataRow("", 1999,01,01, section.Спортивный_туризм, category.I_юношеский_спортивный_разряд, "Петров Пётр Николаевич", "88005553535", "Введите ФИО ученика")]
        [DataRow("Петров Пётр Петрович", 1999, 13, 01, section.Спортивный_туризм, category.I_юношеский_спортивный_разряд, "Петров Пётр Николаевич", "88005553535", "Введите правильную дату")]
        [DataRow("Петров Пётр Петрович", 1999, 01, 01, (section)1123456543, category.I_юношеский_спортивный_разряд, "Петров Пётр Николаевич", "88005553535", "Выберите одну из существующих секций")]
        [DataRow("Петров Пётр Петрович", 1999, 01, 01, section.Спортивный_туризм, (category)3452443, "Петров Пётр Николаевич", "88005553535", "Выберите один из существующих разрядов")]
        [DataRow("Петров Пётр Петрович", 1999, 01, 01, section.Спортивный_туризм, category.I_юношеский_спортивный_разряд, "", "88005553535", "Введите ФИО родителя")]
        [DataRow("Петров Пётр Петрович", 1999, 01, 01, section.Спортивный_туризм, category.I_юношеский_спортивный_разряд, "Петров Пётр Николаевич", "", "Введите номер телефона родителя")]
        public void TestAddTrainee_invalidData(string fio, int year, int month, int day, section section, category category,
                                               string fioParent, string phoneNumberParent, string expectedError)
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);
            var testTraineeData = new Trainee
            {
                Id_Trainee = 1,
                FIO = fio,
                Birthday = new DateTime(year, month, day),
                Section = section,
                Category = category,
                FIOParent = fioParent,
                PhoneNumberParent = phoneNumberParent
            };

            var actualResult = testTrainee.AddTrainee(testTraineeData);
            Assert.AreEqual(expectedError, actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }

        
        [TestMethod]
        public void TestAddTrainee_ExistingID()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var firstTrainee = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 1, 1),
                Section = section.Спортивный_туризм,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            var duplicateTrainee = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Иванов Иван Иванович",
                Birthday = new DateTime(2000, 2, 2),
                Section = section.Спортивный_туризм,
                Category = category.II_юношеский_спортивный_разряд,
                FIOParent = "Иванов Иван Николаевич",
                PhoneNumberParent = "88005553536"
            };

            bool idExists = false;
            mockRep.Setup(r => r.Id_TraineeExists(1))
                   .Returns(() => idExists)
                   .Callback(() => idExists = true);

            mockRep.Setup(r => r.AddTrainee(It.IsAny<Trainee>())/*r => r.Id_TraineeExists(1)*/);


            var firstResult = testTrainee.AddTrainee(firstTrainee);
            var actualResult = testTrainee.AddTrainee(duplicateTrainee);

            Assert.AreEqual("Такой ID ученика уже существует", actualResult);

            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Once);
            mockRep.Verify(r => r.Id_TraineeExists(1), Times.Exactly(2));

            /*var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testValidTrainee = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 1, 1),
                Section = section.Спортивный_туризм,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            mockRep.Setup(r => r.Id_TraineeExists(1))
                   .Returns(true);
            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Такой ID ученика уже существует", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);*/
        }
    }
}
