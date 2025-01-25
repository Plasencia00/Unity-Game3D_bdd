using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje1 : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; // Velocidad de movimiento
    public float velocidadRotacion = 200.0f; // Velocidad de rotación
    private Animator anim; // Referencia al componente Animator
    public float x, y; // Variables para el input horizontal y vertical

    // Start es llamado antes del primer frame
    void Start()
    {
        anim = GetComponent<Animator>(); // Obtener el componente Animator del personaje
    }

    // Update es llamado una vez por frame
    void Update()
    {
        // Obtener el input horizontal y vertical
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        // Rotar el personaje en base al input horizontal
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);

        // Mover el personaje hacia adelante o atrás según el input vertical
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        // Actualizar parámetros del Animator para manejar animaciones
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
