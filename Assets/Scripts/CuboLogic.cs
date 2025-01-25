using UnityEngine;

public class CuboLogic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisiona es el personaje
        if (other.CompareTag("Player"))
        {
            // Mostrar mensaje de derrota en la consola
            Debug.Log("¡Perdiste! Colisionaste con un obstáculo.");

            // Reiniciar el juego o detenerlo
            GameManager.instance.GameOver();
        }
    }
}
