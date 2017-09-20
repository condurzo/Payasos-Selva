using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionTigre : MonoBehaviour {

	public Animation anim;
	public float contador;

	void Update (){

		contador += Time.deltaTime;

		if (contador <= 0.5f) {
			
				anim = GetComponent<Animation> ();
				anim.Play ("Rolling Cat");

		}
	
		if (contador >= 0.5f) {
				anim = GetComponent<Animation> ();
				anim.Play ("Idle Cat");

		}

		if (contador >= 1.5f) {
			contador = 0;
		}
	}
}
