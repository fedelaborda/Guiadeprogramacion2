using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizar un programa que muestre los numeros de forma descendente entre dos entereos ingresados por el usuario, incluyendolos. 
//Chequear que no sean iguales y que el primero sea mayor que el segundo


public class while1 : MonoBehaviour
{
    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 == Numero2)
        {
            Debug.Log("Los números no pueden ser iguales");
        }
        else if (Numero2 > Numero1)
        {
            Debug.Log("El Numero2 no puede ser mayor a Numero1");
        }
        else
        {
            while (Numero1 >= Numero2)
            {
                Debug.Log(Numero1);
                Numero1--;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
