using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionLeon : MonoBehaviour {

	public Animation anim;
	public float contador;

	void Update (){

		contador += Time.deltaTime;

		if (contador <= 1) {
			
				anim = GetComponent<Animation> ();
				anim.Play ("Success Lion");

		}
	
		if (contador >= 1) {
		if (!anim.isPlaying) {
				anim = GetComponent<Animation> ();
				anim.Play ("Idle Lion");

		}
		}

		if (contador >= 3) {
			contador = 0;
		}
	}
}
