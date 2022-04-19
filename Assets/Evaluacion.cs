using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion : MonoBehaviour
{
    public string gusto;
    public double cantidad;
    double precioSinDescuento;
    double precioConDescuento;
	// Use this for initialization
	void Start ()
  {
        //Precio de 1 gramo = $0,5.
        
        precioSinDescuento = cantidad * 500 / 1000;
        
        
        if (gusto != "CHO" && gusto != "FRU" && gusto != "DDL")
        {
            Debug.Log("El gusto ingresado no es válido");
        }
        else
        {
            Debug.Log("El gusto ingresado es " + gusto);
        }

        if (cantidad < 250 || cantidad > 3000)
        {
                Debug.Log("Error. No se puede comprar menos de 250 o más de 3000 gramos.");
        }
        else
     {
        if (gusto == "CHO" || gusto == "DDL")
        {
            Debug.Log("El precio del helado es de $" + precioSinDescuento);
        }
        else if (gusto == "FRU")
        {
            precioConDescuento = precioSinDescuento - precioSinDescuento * 0.1;
            Debug.Log("El precio del helado es de $" + precioConDescuento);
        }
     }

    }
	
	// Update is called once per frame
	void Update ()
  {
		
  }

}