using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.WrittenOffInventory
{
    public class SQLWriteOffManager
    {
        MySqlConnection conn;

        public string WrittenOffInventory(Inventory inventory, int writeOffCount)
        {
            try
            {
                const string request = @"INSERT INTO written_off_inventory 
                                       (NameInventory, CountWrittenOff, WriteOffDate, OriginalInventoryId)
                                       VALUES (@NameInventory, @CountWrittenOff, @WriteOffDate, @OriginalInventoryId)";

                using (MySqlCommand command = new MySqlCommand(request, conn))
                {
                    command.Parameters.AddWithValue("@NameInventory", inventory.Name_Inventory);
                    command.Parameters.AddWithValue("@CountWrittenOff", writeOffCount);
                    command.Parameters.AddWithValue("@WriteOffDate", DateTime.Now);
                    command.Parameters.AddWithValue("@OriginalInventoryId", inventory.Id_Inventory);

                    command.ExecuteNonQuery();
                }

                if (writeOffCount == inventory.Count_Inventory)
                {
                    const string deleteQuery = "DELETE FROM inventory WHERE IdInventory";
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
                                               WHERE IdInventory = @IdInventory";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
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
    }
}
