using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerHome : MonoBehaviour {

	public GameObject Home;
	public GameObject Cargando;
	public GameObject Instruc4;

	public GameObject Homeipad;
	public GameObject Cargandoipad;
	public GameObject Instruc4ipad;

	public void GotToGame () {
		Home.SetActive (false);
		Instruc4.SetActive (false);
		Cargando.SetActive (true);

		Homeipad.SetActive (false);
		Instruc4ipad.SetActive (false);
		Cargandoipad.SetActive (true);
	}

	public void SalirAPP(){
		Application.Quit ();
	}
}
