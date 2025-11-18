using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportSchoolLib;
using SportSchoolLib.Inventors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSportSchool
{
    [TestClass]
    public class TInventoryManager
    {
        [TestMethod]
        public void TestAddInventory_validData()
        {
            var mockrep = new Mock<IInventoryManager>();
            var testInventory = new InventoryManager(mockrep.Object);

            var testValidInventory = new Inventory()
            {
                Name_Inventory = "Карабин (GURU)",
                Count_Inventory = 10,
                DateDelivery = new DateTime(2025, 11, 15)
            };

            List<Inventory> repositoryContent = new List<Inventory>();

            mockrep.Setup(r => r.AddInventory(testValidInventory))
                   .Returns("")
                   .Callback<Inventory>(inventory => repositoryContent.Add(inventory));
            var actualResult = testInventory.AddInventory(testValidInventory);

            Assert.AreEqual("Новая запись успешно добавлена", actualResult);
            mockrep.Verify(r => r.AddInventory(testValidInventory), Times.Once);

            Assert.IsTrue(repositoryContent.Contains(testValidInventory),
                "Запись не была сохранена в репозитории");
        }
        [TestMethod]
        [DataRow("", 10, 2025, 11, 15, "Введите наименование инвентаря")]
        [DataRow("Карабин (GURU)", null, 2025, 11, 15, "Введите корректное количество инвентаря")]
        [DataRow("Карабин (GURU)", 0, 2025, 11, 15, "Введите корректное количество инвентаря")]
        [DataRow("Карабин (GURU)", -1, 2025, 11, 15, "Введите корректное количество инвентаря")]
        [DataRow("Карабин (GURU)", null, "", "", "", "Введите дату поставки инвентаря")]
        public void TestAddInventory_invalidData(string name, int count, int year, int month, int day, string expectedResult)
        {
            var mockrep = new Mock<IInventoryManager>();
            var testInventory = new InventoryManager(mockrep.Object);
            var testInvalidInventory = new Inventory()
            {
                Name_Inventory = name,
                Count_Inventory = count,
                DateDelivery = new DateTime(year, month, day)
            };
            var actualResult = testInventory.AddInventory(testInvalidInventory);

            Assert.AreEqual(expectedResult, actualResult);
            mockrep.Verify(r => r.AddInventory(testInvalidInventory), Times.Once);
        }
    }
}
