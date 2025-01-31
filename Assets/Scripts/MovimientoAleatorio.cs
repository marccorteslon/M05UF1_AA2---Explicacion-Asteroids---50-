using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb; // Referència al Rigidbody2D de l'asteroide

    void Start()
    {
        // Afegir una força aleatòria a l'asteroide
        Vector2 forçaAleatoria = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float magnitudForça = Random.Range(1f, 5f); // Ajusta els valors segons la velocitat desitjada
        rb.AddForce(forçaAleatoria * magnitudForça, ForceMode2D.Impulse);

        // Afegir una rotació aleatòria a l'asteroide
        float rotacióAleatoria = Random.Range(-180f, 180f); // Gira entre -180° i 180°
        rb.AddTorque(rotacióAleatoria, ForceMode2D.Impulse);
    }
}
