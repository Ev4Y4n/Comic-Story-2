using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechasCorto : MonoBehaviour
{

    public GameObject[] parpitura;//Lista de objetos para llamar que queramos que sea parpitura
    public GameObject flechaDerecha;//Variable para llamar al Objeto que queramos que sea flechaDerecha
    int index;//Variable int que es un numero
    void Start()
    {
        index = 0;//La variable int index igual a 0
    }

    void Update()
    {
        if (index > 2) //Si index es mayor que 2 se convierte a 2 haciendo que nunca suba de 2
            index = 2;

        if (index < 0) //Si index es menor que 0 se convierte a 0 haciendo que nunca baje de 0
            index = 0;

        if (index == 0) // Si index es igual a 0 en la lista de objetos parpitura elige al numero 0 (el primero de la lista)
        {
            parpitura[0].gameObject.SetActive(true);
        }
    }
 
    public void Next()
    {

        
        index += 1; //Al dar click a la flechaDerecha hace que suba un numero en el index de 0 a 1

        for (int i = 0; i < parpitura.Length; i++)//Variable i es igual a 0, si i es menor a la longitud de la variable parpitura, se suma a la variable i
        {
            parpitura[i].gameObject.SetActive(false);//Descativa la parpitura en la que la variable i este
            parpitura[index].gameObject.SetActive(true); //Ativa la parpitura en la que la variable index este
        }
        Debug.Log(+index);//Enseña en la consola en que pagina estas
        Debug.Log("Ha pasado pagina");
        flechaDerecha.SetActive(false);
        
    }


}
