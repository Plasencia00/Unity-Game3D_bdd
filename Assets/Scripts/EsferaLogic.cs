using UnityEngine;

public class EsferaLogic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisiona es el personaje
        if (other.CompareTag("Player"))
        {
            // Sumar puntos al recoger la esfera
            GameManager.instance.AddScore(10);

            // Destruir la esfera
            Destroy(gameObject);
        }
    }
}
