using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lechePrefab;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject nuevaImagen = Instantiate(lechePrefab, PosicionAleatoriaCanvas(), Quaternion.Euler(0,0, Random.Range(0f, 360f)));
            nuevaImagen.transform.SetParent(canvas.transform, false);
            Destroy(nuevaImagen, 1f);
        }*/
    }

    public void UImilk()
    {
        GameObject nuevaImagen = Instantiate(lechePrefab, PosicionAleatoriaCanvas(), Quaternion.Euler(0, 0, Random.Range(0f, 360f)));
        nuevaImagen.transform.SetParent(canvas.transform, false);
        Destroy(nuevaImagen, 1f);
    }

    Vector3 PosicionAleatoriaCanvas()
    {
        float canvasWidth = canvas.GetComponent<RectTransform>().rect.width;
        float canvasHeight = canvas.GetComponent<RectTransform>().rect.height;

        float x = Random.Range(-canvasWidth/2, canvasWidth/2);
        float y = Random.Range(-canvasHeight/2, canvasHeight/2);

        Vector3 posicionAleatoria = new Vector3(x, y, 0f);

        return posicionAleatoria;
    }
}
