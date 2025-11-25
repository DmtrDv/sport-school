using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.WrittenOffInventory
{
    public class SQLWriteOffManager: IWriteOffManager
    {
        MySqlConnection conn;

        public string WriteOffInventory(Inventory inventory, int writeOffCount)//метод списания
        {
            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string request = @"INSERT INTO written_off_inventory 
                                       (NameInventory, CountWrittenOff, WriteOffDate, OriginalInventoryId)
                                       VALUES (@NameInventory, @CountWrittenOff, @WriteOffDate, @OriginalInventoryId)";//подключение

                using (MySqlCommand command = new MySqlCommand(request, conn)) //передаём параметры
                {
                    command.Parameters.AddWithValue("@NameInventory", inventory.Name_Inventory);
                    command.Parameters.AddWithValue("@CountWrittenOff", writeOffCount);
                    command.Parameters.AddWithValue("@WriteOffDate", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@OriginalInventoryId", inventory.Id_Inventory);

                    command.ExecuteNonQuery();
                }

                if (writeOffCount == inventory.Count_Inventory)
                {
                    const string deleteQuery = "DELETE FROM inventory WHERE IdInventory = @IdInventory"; //запрос на удаление
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@IdInventory", inventory.Id_Inventory);
                        deleteCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    const string updateQuery = @"UPDATE inventory 
                                               SET CountInventory = CountInventory - @WriteOffCount 
                                               WHERE IdInventory = @IdInventory"; //запрос на обновление
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))// обновление параметров
                    {
                        updateCommand.Parameters.AddWithValue("@WriteOffCount", writeOffCount);
                        updateCommand.Parameters.AddWithValue("@IdInventory", inventory.Id_Inventory);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                return "Инвентарь успешно списан";
            }
            catch(Exception ex)
            {
                return "Ошибка при списании: " + ex.Message;
            }
        }
        public List<WrittenOffInventory> GetWrittenOffArchive()
        {
            List<WrittenOffInventory> result = new List<WrittenOffInventory>();
            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = @"SELECT IdWrittenOff, NameInventory, 
                                              CountWrittenOff, WriteOffDate, OriginalInventoryId 
                                       FROM written_off_inventory";//подключение
                using (MySqlCommand command = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        WrittenOffInventory writeOff = new WrittenOffInventory//получаем данные
                        {
                            Id_WrittenOff = reader.GetInt32("IdWrittenOff"),
                            Name_Inventory = reader.GetString("NameInventory"),
                            Count_WrittenOff = reader.GetInt32("CountWrittenOff"),
                            WriteOffDate = reader.GetDateTime("WriteOffDate"),
                            OriginalInventoryId = reader.GetInt32("OriginalInventoryId")
                        };
                        result.Add(writeOff);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке истории списаний: " + ex.Message);
            }
            return result;
        }
    }
}
