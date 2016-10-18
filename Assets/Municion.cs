using UnityEngine;
using System.Collections;

public class Municion : MonoBehaviour {
    public int municionPizza;
    static public int municionPizza2;
	// Use this for initialization
	void Start ()
    {
        //Asignar el valor inicial de municion por cada nivel a municionPizza2, municionPizza es el dato que va a variar y modificar la cantidad de pizza.
        municionPizza = municionPizza2;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (disparos == true)
        {
            municionPizza--;
        }
	}
}
