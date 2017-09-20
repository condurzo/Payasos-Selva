using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMusica : MonoBehaviour {

	public AudioSource audioMusica;
	public static bool Termino;
	public static bool Empezar;

	void Start(){
		audioMusica = GetComponent<AudioSource> ();
	}

	void Update(){
		if (Termino) {
			audioMusica.Stop ();
			Termino = false;
		}

		if (Empezar) {
			if (!audioMusica.isPlaying) {
				audioMusica.Play ();
				Empezar = false;
			}	
		}
	}


}
