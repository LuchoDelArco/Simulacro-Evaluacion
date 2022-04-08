using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son

public class Ej01 : MonoBehaviour
{
	public int numero1;
	public int numero2;

	// Start is called before the first frame update
	void Start()
	{
		if (numero1 == numero2)
		{
			Debug.Log("Los números son iguales");
		}
		else
		{
			Debug.Log("Los números son diferentes");
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
