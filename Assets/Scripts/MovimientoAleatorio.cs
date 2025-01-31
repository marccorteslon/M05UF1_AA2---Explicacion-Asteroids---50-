using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb; // Refer�ncia al Rigidbody2D de l'asteroide

    void Start()
    {
        // Afegir una for�a aleat�ria a l'asteroide
        Vector2 for�aAleatoria = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float magnitudFor�a = Random.Range(1f, 5f); // Ajusta els valors segons la velocitat desitjada
        rb.AddForce(for�aAleatoria * magnitudFor�a, ForceMode2D.Impulse);

        // Afegir una rotaci� aleat�ria a l'asteroide
        float rotaci�Aleatoria = Random.Range(-180f, 180f); // Gira entre -180� i 180�
        rb.AddTorque(rotaci�Aleatoria, ForceMode2D.Impulse);
    }
}
