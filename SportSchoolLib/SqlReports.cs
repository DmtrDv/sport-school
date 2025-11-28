using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SportSchoolLib
{
    public class SqlReports
    {
        MySqlConnection conn;

        public BindingList<Inventory> GetLowInventoryStock()
        {
            BindingList<Inventory> result = new BindingList<Inventory>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = "SELECT IdInventory, NameInventory, CountInventory, DateDelivery " +
                    "FROM inventory " +
                    "WHERE CountInventory < 11 " +
                    "ORDER BY CountInventory ASC";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32("IdInventory");

                        Inventory inventory = new Inventory(Id);
                        inventory.Name_Inventory = reader.GetString("NameInventory");
                        inventory.Count_Inventory = reader.GetInt32("CountInventory");
                        inventory.DateDelivery = reader.GetDateTime("DateDelivery");

                        result.Add(inventory);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке инвентаря: " + ex.Message);
            }
            return result;
        }
    }
}
