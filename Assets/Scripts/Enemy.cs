using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private Transform jugador;
    public float distanciaSeguimiento = 2f;
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Jugador").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaDeJugador = Vector3.Distance(transform.position, jugador.position);

        if (distanciaDeJugador < distanciaSeguimiento)
        {
            Vector3 direccion = jugador.position - transform.position;
            direccion.Normalize();
            transform.Translate(direccion * speed * Time.deltaTime);
            if (Vector3.Dot(direccion, transform.right) < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }
}
