using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restaurante1 : MonoBehaviour {
    public Text dialogo;

	// Use this for initialization
	void Start () {
        dialogo.text = "Biemvenido al restaurante";
	}
	
	// Update is called once per frame
	void Update () {

		
	} 

    public void Ingrediente() {

        Ingredientes ing1 = new Ingredientes();
        
    }
}
