using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargandoSelva : MonoBehaviour {


	

	void Start () {
		Invoke ("IrPayasos", 0.1f);
	}

	void IrPayasos(){
		Application.LoadLevel ("Selva");
	}
}
