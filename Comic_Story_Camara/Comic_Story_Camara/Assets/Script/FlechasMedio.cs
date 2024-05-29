using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechasMedio : MonoBehaviour
{
    public GameObject[] parpitura;
    public GameObject flechaDerecha;
    int index;
    void Start()
    {
        index = 0;
    }

    void Update()
    {
        if (index > 3) //Si index es mayor que 2 se convierte a 2 haciendo que nunca suba de 3
            index = 3;

        if (index < 0)
            index = 0;

        if (index == 0)
        {
            parpitura[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        
        index += 1;

        for (int i = 0; i < parpitura.Length; i++)
        {
            parpitura[i].gameObject.SetActive(false);
            parpitura[index].gameObject.SetActive(true);
        }
        Debug.Log(index);

        flechaDerecha.SetActive(false);

        

    }

    
}
