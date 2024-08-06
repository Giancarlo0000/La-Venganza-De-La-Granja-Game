using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float currentSpeed;
    public float regularSpeed;
    private bool lookRight = true;
    private Animator anim;
    public float AttackTime;
    private float RegularAttackTime;
    public float LastAttackTime;
    public float Lives = 3;
    public float FastAttackForce;
    private Rigidbody2D rb;

    public GameObject attack;
    public Transform attackPosition;

    public ChangeUI changeLive;
    public GameManager gameManager;
    void Start()
    {
        currentSpeed = regularSpeed;
        anim = GetComponent<Animator>();
        changeLive.UpdateLives(Lives);
        RegularAttackTime = AttackTime;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * currentSpeed, dirY * currentSpeed);

        //ATAQUE

        if (Time.time - LastAttackTime >= AttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject instancia = Instantiate(attack, attackPosition.position, Quaternion.identity);
                instancia.transform.localScale = new Vector3(gameObject.transform.localScale.x, 1f, 1f);
                LastAttackTime = Time.time;
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

        //MOVIMIENTO

        if (dirX < 0 & lookRight)
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= .5f;
            transform.position = newPosition;
            lookRight = false;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (dirX > 0 & (lookRight == false))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += .5f;
            transform.position = newPosition;
            lookRight=true;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        //ANIMACION

        if (dirX == 0 & dirY == 0)
        {
            anim.SetBool("isMoving",false);
        }
        else if ((dirX != 0) | (dirY != 0))
        {
            anim.SetBool("isMoving", true);
        } 
    }

    //RECIBIR ATAQUE
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Lives = Lives - 1;
            changeLive.UpdateLives(Lives);
            if (Lives == 0)
            {
                SceneManager.LoadScene("Derrota");
            }
        }
        if (collision.tag == "EnemyBullet")
        {
            Destroy(collision.gameObject);
            Lives = Lives - 1;
            changeLive.UpdateLives(Lives);
            if (Lives == 0)
            {
                SceneManager.LoadScene("Derrota");
            }
        }
        if (collision.tag == "MilkBullet")
        {
            Destroy(collision.gameObject);
            gameManager.UImilk();
        }
    }
}
