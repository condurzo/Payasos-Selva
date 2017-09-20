using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTime : MonoBehaviour {
	public float tiempo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		Debug.Log (tiempo);
	}
}
