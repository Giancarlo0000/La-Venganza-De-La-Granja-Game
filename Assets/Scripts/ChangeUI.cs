using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUI : MonoBehaviour
{

    private float LivesUI;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Vidas: " + LivesUI;
    }

    // Update is called once per frame
    public void UpdateLives(float newLives)
    {
        LivesUI = newLives;
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = "Vidas: " + LivesUI;
    }
}
