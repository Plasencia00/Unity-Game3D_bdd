using UnityEngine;
using MySql.Data.MySqlClient;

public class TestConexion : MonoBehaviour
{
    // Cadena de conexión a la base de datos
    private string connectionString = "Server=localhost;Database=gamedb;User=root;Password=;";

    // Método para probar la conexión
    public void TestDBConnection()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Debug.Log("Conexión exitosa con la base de datos.");
            }
            catch (MySqlException ex)
            {
                Debug.LogError("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }

    // Método para guardar la puntuación en la base de datos
    public void GuardarPuntuacion(string playerName, int score)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO scores (PlayerName, Score, Timestamp) VALUES (@PlayerName, @Score, NOW())";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Asignar valores a los parámetros de la consulta
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Score", score);

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Debug.Log("Puntuación guardada correctamente.");
                    }
                    else
                    {
                        Debug.LogError("No se pudo guardar la puntuación.");

                    }
                }
            }
            catch (MySqlException ex)
            {
                Debug.LogError("Error al guardar la puntuación: " + ex.Message);

            }
            Debug.Log($"Intentando guardar puntuación: Player = {playerName}, Score = {score}");

        }
    }
}
