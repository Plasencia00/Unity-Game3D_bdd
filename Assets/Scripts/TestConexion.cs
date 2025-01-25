using UnityEngine;
using MySql.Data.MySqlClient;

public class TestConexion : MonoBehaviour
{
    // Cadena de conexi�n a la base de datos
    private string connectionString = "Server=localhost;Database=gamedb;User=root;Password=;";

    // M�todo para probar la conexi�n
    public void TestDBConnection()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Debug.Log("Conexi�n exitosa con la base de datos.");
            }
            catch (MySqlException ex)
            {
                Debug.LogError("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }

    // M�todo para guardar la puntuaci�n en la base de datos
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
                    // Asignar valores a los par�metros de la consulta
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Score", score);

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Debug.Log("Puntuaci�n guardada correctamente.");
                    }
                    else
                    {
                        Debug.LogError("No se pudo guardar la puntuaci�n.");

                    }
                }
            }
            catch (MySqlException ex)
            {
                Debug.LogError("Error al guardar la puntuaci�n: " + ex.Message);

            }
            Debug.Log($"Intentando guardar puntuaci�n: Player = {playerName}, Score = {score}");

        }
    }
}
