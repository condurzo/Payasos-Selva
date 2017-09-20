using UnityEngine;
using System.Collections;

public class RotateSampleContinuo : MonoBehaviour
{	

	public GameObject item;

	void Start(){
		iTween.RotateBy(item, iTween.Hash(
			"y", 1.0f, 
			"time", 3f,
			"easetype", "linear",
			"looptype", iTween.LoopType.loop
		));

	}
}

