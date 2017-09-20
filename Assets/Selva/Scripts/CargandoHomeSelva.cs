using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargandoHomeSelva : MonoBehaviour {

	void Start () {
		Invoke ("IrHome", 0.1f);
	}

	void IrHome(){
		Application.LoadLevel ("HomeSelva");
	}
}
