using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 10f;
    private Transform jugador;
    private Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Jugador").transform;
        if (jugador != null)
        {
            direccion = (jugador.position - transform.position).normalized;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Translate(direccion * speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, jugador.position) > 20f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Jugador")
        {
            Destroy(gameObject);
        }
    }
}
