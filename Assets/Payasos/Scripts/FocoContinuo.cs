using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FocoContinuo : MonoBehaviour {


	void Start () {
		//		CameraDevice.Instance.SetFocusMode(
		//			        CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		//		CameraDevice.Instance.SetFocusMode(
		//			CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
	}

	void Update () {
//		CameraDevice.Instance.SetFocusMode(
//			        CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
//		CameraDevice.Instance.SetFocusMode(
//			CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
	}
//
//	void Start (){
//		    var vuforia = VuforiaARController.Instance;
//		    vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
//		    vuforia.RegisterOnPauseCallback(OnPaused);
//	}
//	  
//	private void OnVuforiaStarted(){
//		    CameraDevice.Instance.SetFocusMode(
//			        CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
//	}
//	  
//	private void OnPaused(bool paused){
//		if (!paused){ // resumed
//		        // Set again autofocus mode when app is resumed
//		        CameraDevice.Instance.SetFocusMode(
//			            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
//		    }
//	}
}
