using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float enemyCount = enemies.Length;

        gameObject.GetComponent<Text>().text = "Enemigos Restantes: " + enemyCount;

        if (enemyCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Nivel Completado!!";
            gameObject.GetComponent<Text>().color = Color.yellow;
            SceneManager.LoadScene("Victoria");
        }
    }
}
