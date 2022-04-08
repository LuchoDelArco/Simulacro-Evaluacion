using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

public class Ej02 : MonoBehaviour
{

	public float producto1;
	public float producto2;
	public float producto3;
	float sumaProductos;

	public float montoDisponible;
	float faltaDinero;
	float sobraDinero;
    

    void Start()
    {
		sumaProductos = producto1 + producto2 + producto3;
		if (montoDisponible < sumaProductos)
		{
			faltaDinero = sumaProductos - montoDisponible;
			Debug.Log("La suma de los productos superan al monto disponible. " + "Se necesitan $" + faltaDinero + "más");
		}
		else if (montoDisponible > sumaProductos)
		{
			sobraDinero = montoDisponible - sumaProductos;
			Debug.Log("La suma de los productos no supera al monto disponible. " + "Sobran $" + sobraDinero);
		}
		else
		{
			Debug.Log("La suma de los productos es igual al monto. " + "No hay resto");
		}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
