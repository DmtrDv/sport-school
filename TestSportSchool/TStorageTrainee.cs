using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportSchoolLib;

namespace TestSportSchool
{
    [TestClass]
    public class TStorageTrainee
    {
        private IStorageTrainee _storageTrainee;
        private Trainee _testTrainee;
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
        public void TestDeleteTrainee_Success()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var traineeManager = new TraineeDBManager(mockRep.Object);
            int traineeId = 1;
            bool userConfirmed = true;

            mockRep.Setup(r => r.Id_TraineeExists(traineeId))
                   .Returns(true);
            mockRep.Setup(r => r.DeleteTrainee(traineeId))
                   .Returns(true);

            var result = traineeManager.DeleteTrainee(traineeId, userConfirmed);

            Assert.AreEqual("Учащийся успешно удалён", result);
            mockRep.Verify(r => r.Id_TraineeExists(traineeId), Times.Once);
            mockRep.Verify(r => r.DeleteTrainee(traineeId), Times.Once);
        }

        [TestMethod]
        public void TestDeleteTrainee_TraineeNotFound()
        {
            var mockRep = new Mock<IStorageTrainee>();
            var traineeManager = new TraineeDBManager(mockRep.Object);
            int traineeId = 999; // Несуществующий ID
            bool userConfirmed = true;

            mockRep.Setup(r => r.Id_TraineeExists(traineeId))
                   .Returns(false);

            var result = traineeManager.DeleteTrainee(traineeId, userConfirmed);

            Assert.AreEqual($"Обучающийся с ID ^{traineeId}^ не найден", result);
            mockRep.Verify(r => r.Id_TraineeExists(traineeId), Times.Once);
            mockRep.Verify(r => r.DeleteTrainee(It.IsAny<int>()), Times.Never);
        }
    }
}
