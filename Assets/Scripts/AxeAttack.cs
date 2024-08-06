using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    private Transform PlayerPosition;
    private Transform RealPlayer;
    public float LifeTime;

    private Player playerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPosition = GameObject.FindGameObjectWithTag("AttackPosition").transform;
        RealPlayer = GameObject.FindGameObjectWithTag("Jugador").transform;
        Invoke("DestroyObject", LifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = PlayerPosition.transform.position;
        gameObject.transform.localScale = new Vector3(RealPlayer.transform.localScale.x, 1f, 1f);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

    }
}
