using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SportSchoolLib.Inventors
{
    public class SQLInventoryManager: IInventoryManager
    {
        MySqlConnection conn;

        public List<Inventory> GetInventories()
        {
            List<Inventory> result = new List<Inventory>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = "SELECT IdInventory, NameInventory, CountInventory, DateDelivery FROM inventory";
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
        public string AddInventory(Inventory inventory)
        {
            using (MySqlConnection conn = new MySqlConnection(AppSettings.ConnectionString))
            {
                try
                {
                    conn.Open();
                    const string request = @"INSERT INTO inventory 
                                           (NameInventory, CountInventory, DateDelivery )
                                            VALUES (@NameInventory, @CountInventory, @DateDelivery )";
                    using (MySqlCommand command = new MySqlCommand(request, conn))
                    {
                        command.Parameters.AddWithValue("@NameInventory", inventory.Name_Inventory);
                        command.Parameters.AddWithValue("@CountInventory", inventory.Count_Inventory);
                        command.Parameters.AddWithValue("@DateDelivery", inventory.DateDelivery);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Новая запись успешно добавлена";
                        }
                        else
                        {
                            return "Ошибка: запись не была добавлена";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Ошибка при добавлении: " + ex;
                }
            }
        }
        public string UpdateInventory(Inventory inventory)
        {
            return "";
        }
    }
}
