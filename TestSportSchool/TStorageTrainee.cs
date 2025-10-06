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
        public void TestAddTrainee_emptyFIO()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testEmptyFIO = new Trainee
            {
                Id_Trainee = 1,
                FIO = "",
                Birthday = new DateTime(1999, 1, 1),
                Section = section.Спортивный_туризм,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            var actualResult = testTrainee.AddTrainee(testEmptyFIO);
            Assert.AreEqual("Введите ФИО ученика", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_InvalidBirthday()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testBirthdayInvalid = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 13, 1),
                Section = section.Спортивный_туризм,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            var actualResult = testTrainee.AddTrainee(testBirthdayInvalid);

            Assert.AreEqual("Введите правильную дату", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_InvalidSection()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testBirthdayInvalid = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 12, 1),
                Section = (section)1123456543,
                Category = category.I_юношеский_спортивный_разряд,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            var actualResult = testTrainee.AddTrainee(testBirthdayInvalid);

            Assert.AreEqual("Выберите одну из существующих секций", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_InvalidCategory()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var testTrainee = new TraineeDBManager(mockRep.Object);

            var testValidTrainee = new Trainee
            {
                Id_Trainee = 1,
                FIO = "Петров Пётр Петрович",
                Birthday = new DateTime(1999, 1, 1),
                Section = section.Спортивный_туризм,
                Category = (category)3452443,
                FIOParent = "Петров Пётр Николаевич",
                PhoneNumberParent = "88005553535"
            };

            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Выберите один из существующих разрядов", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_emptyFIOParent()
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
                FIOParent = "",
                PhoneNumberParent = "88005553535"
            };

            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Введите ФИО родителя", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_emptyPhoneNumberParent()
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
                PhoneNumberParent = ""
            };

            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Введите номер телефона родителя", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
        [TestMethod]
        public void TestAddTrainee_ExistingID()
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
                   .Returns(true);
            var actualResult = testTrainee.AddTrainee(testValidTrainee);

            Assert.AreEqual("Такой ID ученика уже существует", actualResult);
            mockRep.Verify(r => r.AddTrainee(It.IsAny<Trainee>()), Times.Never);
        }
    }
}
