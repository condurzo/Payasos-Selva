using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionGirafa : MonoBehaviour {

	public Animation anim;
	public float contador;

	void Update (){

		contador += Time.deltaTime;

		if (contador <= 1) {
			
				anim = GetComponent<Animation> ();
				anim.Play ("Idle Giraffe");

		}
	
		if (contador >= 1) {

				anim = GetComponent<Animation> ();
				anim.Play ("Failure Giraffe");

		
		}

		if (contador >= 2.6f) {
			contador = 0;
		}
	}
}
