using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Level6;
    public Button Level7;
    public Button Level8;
    public Button Level9;
    public Button Level10;
    public Button Level11;
    public Button Level12;
    // Start is called before the first frame update
    void Start()
    {
        Level1.onClick.AddListener(CambiarNivel1);
        Level2.onClick.AddListener(CambiarNivel2);
        Level3.onClick.AddListener(CambiarNivel3);
        Level4.onClick.AddListener(CambiarNivel4);
        Level5.onClick.AddListener(CambiarNivel5);
        Level6.onClick.AddListener(CambiarNivel6);
        Level7.onClick.AddListener(CambiarNivel7);
        Level8.onClick.AddListener(CambiarNivel8);
        Level9.onClick.AddListener(CambiarNivel9);
        Level10.onClick.AddListener(CambiarNivel10);
        Level11.onClick.AddListener(CambiarNivel11);
        Level12.onClick.AddListener(CambiarNivel12);
    }
    void CambiarNivel1()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    void CambiarNivel2()
    {
        SceneManager.LoadScene("Nivel 2");
    }
    void CambiarNivel3()
    {
        SceneManager.LoadScene("Nivel 3");
    }
    void CambiarNivel4()
    {
        SceneManager.LoadScene("Nivel 4");
    }
    void CambiarNivel5()
    {
        SceneManager.LoadScene("Nivel 5");
    }
    void CambiarNivel6()
    {
        SceneManager.LoadScene("Nivel 6");
    }
    void CambiarNivel7()
    {
        SceneManager.LoadScene("Nivel 7");
    }
    void CambiarNivel8()
    {
        SceneManager.LoadScene("Nivel 8");
    }
    void CambiarNivel9()
    {
        SceneManager.LoadScene("Nivel 9");
    }
    void CambiarNivel10()
    {
        SceneManager.LoadScene("Nivel 10");
    }
    void CambiarNivel11()
    {
        SceneManager.LoadScene("Nivel 11");
    }
    void CambiarNivel12()
    {
        SceneManager.LoadScene("Nivel 12");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
