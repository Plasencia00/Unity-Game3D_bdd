using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para reiniciar la escena
using TMPro; // Necesario para TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton
    private int score = 0;
    private TestConexion testConexion; // Referencia al script TestConexion
    private bool scoreSaved = false; // Controla si el puntaje ya se guardó

    [SerializeField] private TextMeshProUGUI scoreText; // Enlazar en el inspector
    [SerializeField] private TMP_InputField playerNameInput; // InputField para el nombre del jugador

    private string playerName = "Player1"; // Valor por defecto del nombre del jugador

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        testConexion = FindObjectOfType<TestConexion>();
        UpdateScoreUI(); // Inicializar el texto de puntuación

        // Si el InputField está enlazado, asignar un valor inicial
        if (playerNameInput != null)
        {
            playerNameInput.text = playerName;
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI(); // Actualizar la UI
        Debug.Log("Puntuación actual: " + score);
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Puntuación: {score}";
        }
    }

    public void GameOver()
    {
        if (!scoreSaved)
        {
            scoreSaved = true; // Evitar que se guarde más de una vez en el Game Over
            Debug.Log("El jugador ha muerto. Guardando puntuación...");

            if (testConexion != null)
            {
                // Verificar el nombre actualizado antes de guardar
                if (playerNameInput != null && !string.IsNullOrEmpty(playerNameInput.text))
                {
                    playerName = playerNameInput.text.Trim(); // Actualizar el nombre del jugador
                }

                // Guardar el puntaje final en la base de datos
                testConexion.GuardarPuntuacion(playerName, score);
                Debug.Log($"Guardando puntuación final para el jugador: {playerName} con puntaje: {score}");
            }
            else
            {
                Debug.LogError("No se encontró el script TestConexion.");
            }
        }

        // Reiniciar la escena después de guardar
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

