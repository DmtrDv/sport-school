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
    }
}
