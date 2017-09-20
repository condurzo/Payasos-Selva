using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSelva : MonoBehaviour {

	public GameObject[] PayasosGameObject;

	public GameObject[] PayasosSonidos;

	public GameObject FichaBanner;
	public GameObject FichaBanner2;
	public Image PayasoFichaImage;
	public Image PayasoFichaImage2;
	public Sprite [] PayasosFotos;
	public static string NombrePayaso;
	public string TempPayaso;
	public string TempPayasoFinal;
	public string TempPayasoFinal2;
	public bool TakePhoto;
	public bool Termino;
	public Image ImagenFinal1;
	public Image ImagenFinal1B;
	public Image ImagenFinal2;
	public Image ImagenFinal2B;
	public GameObject FondoActivo;
	public GameObject FondoActivo2;
	public GameObject GanasteImage;
	public GameObject GanasteImage2;
	public GameObject PerdisteImage;
	public GameObject PerdisteImage2;
	public GameObject BtnCerrarGame;
	public GameObject Cargando;
	public GameObject Cargando2;

	public AudioSource audios;
	public AudioClip Gano;
	public AudioClip Perdio;


	public bool GameActive;

	void Start(){
		GameActive = true;
		audios = GetComponent<AudioSource> ();
		//Invoke ("ActivarTodos", 1);
	}

//	void ActivarTodos(){
//		PayasosGameObject [0].SetActive (true);
//		PayasosGameObject [1].SetActive (true);
//		PayasosGameObject [2].SetActive (true);
//		PayasosGameObject [3].SetActive (true);
//		PayasosGameObject [4].SetActive (true);
//		PayasosGameObject [5].SetActive (true);
//		PayasosGameObject [6].SetActive (true);
//		PayasosGameObject [7].SetActive (true);
//		PayasosGameObject [8].SetActive (true);
//		PayasosGameObject [9].SetActive (true);
//		PayasosGameObject [10].SetActive (true);
//		PayasosGameObject [11].SetActive (true);
//		PayasosGameObject [12].SetActive (true);
//		PayasosGameObject [13].SetActive (true);
//		PayasosGameObject [14].SetActive (true);
//		PayasosGameObject [15].SetActive (true);
//		PayasosGameObject [16].SetActive (true);
//		PayasosGameObject [17].SetActive (true);
//		PayasosGameObject [18].SetActive (true);
//		PayasosGameObject [19].SetActive (true);
//		PayasosGameObject [20].SetActive (true);
//		PayasosGameObject [21].SetActive (true);
//		PayasosGameObject [22].SetActive (true);
//		PayasosGameObject [23].SetActive (true);
//		PayasosGameObject [24].SetActive (true);
//		PayasosGameObject [25].SetActive (true);
//		PayasosGameObject [26].SetActive (true);
//		PayasosGameObject [28].SetActive (true);
//		PayasosGameObject [29].SetActive (true);
//	}


	void Update(){
		if (GameActive) {

			if (NombrePayaso == "LaSelva01") {
				PayasosSonidos [0].SetActive (true);
			} else {
				PayasosSonidos [0].SetActive (false);
			}
			if (NombrePayaso == "LaSelva02") {
				PayasosSonidos [1].SetActive (true);
			} else {
				PayasosSonidos [1].SetActive (false);
			}
			if (NombrePayaso == "LaSelva03") {
				PayasosSonidos [2].SetActive (true);
			} else {
				PayasosSonidos [2].SetActive (false);
			}
			if (NombrePayaso == "LaSelva04") {
				PayasosSonidos [3].SetActive (true);
			} else {
				PayasosSonidos [3].SetActive (false);
			}
			if (NombrePayaso == "LaSelva05") {
				PayasosSonidos [4].SetActive (true);
			} else {
				PayasosSonidos [4].SetActive (false);
			}
			if (NombrePayaso == "LaSelva06") {
				PayasosSonidos [5].SetActive (true);
			} else {
				PayasosSonidos [5].SetActive (false);
			}
			if (NombrePayaso == "LaSelva07") {
				PayasosSonidos [6].SetActive (true);
			} else {
				PayasosSonidos [6].SetActive (false);
			}
			if (NombrePayaso == "LaSelva08") {
				PayasosSonidos [7].SetActive (true);
			} else {
				PayasosSonidos [7].SetActive (false);
			}
			if (NombrePayaso == "LaSelva09") {
				PayasosSonidos [8].SetActive (true);
			} else {
				PayasosSonidos [8].SetActive (false);
			}
			if (NombrePayaso == "LaSelva10") {
				PayasosSonidos [9].SetActive (true);
			} else {
				PayasosSonidos [9].SetActive (false);
			}
			if (NombrePayaso == "LaSelva11") {
				PayasosSonidos [10].SetActive (true);
			} else {
				PayasosSonidos [10].SetActive (false);
			}
			if (NombrePayaso == "LaSelva12") {
				PayasosSonidos [11].SetActive (true);
			} else {
				PayasosSonidos [11].SetActive (false);
			}
			if (NombrePayaso == "LaSelva13") {
				PayasosSonidos [12].SetActive (true);
			} else {
				PayasosSonidos [12].SetActive (false);
			}
			if (NombrePayaso == "LaSelva14") {
				PayasosSonidos [13].SetActive (true);
			} else {
				PayasosSonidos [13].SetActive (false);
			}
			if (NombrePayaso == "LaSelva15") {
				PayasosSonidos [14].SetActive (true);
			} else {
				PayasosSonidos [14].SetActive (false);
			}
			if (NombrePayaso == "LaSelva16") {
				PayasosSonidos [15].SetActive (true);
			} else {
				PayasosSonidos [15].SetActive (false);
			}
			if (NombrePayaso == "LaSelva17") {
				PayasosSonidos [16].SetActive (true);
			} else {
				PayasosSonidos [16].SetActive (false);
			}
			if (NombrePayaso == "LaSelva18") {
				PayasosSonidos [17].SetActive (true);
			} else {
				PayasosSonidos [17].SetActive (false);
			}
			if (NombrePayaso == "LaSelva19") {
				PayasosSonidos [18].SetActive (true);
			} else {
				PayasosSonidos [18].SetActive (false);
			}
			if (NombrePayaso == "LaSelva20") {
				PayasosSonidos [19].SetActive (true);
			} else {
				PayasosSonidos [19].SetActive (false);
			}
			if (NombrePayaso == "LaSelva21") {
				PayasosSonidos [20].SetActive (true);
			} else {
				PayasosSonidos [20].SetActive (false);
			}
			if (NombrePayaso == "LaSelva22") {
				PayasosSonidos [21].SetActive (true);
			} else {
				PayasosSonidos [21].SetActive (false);
			}
			if (NombrePayaso == "LaSelva23") {
				PayasosSonidos [22].SetActive (true);
			} else {
				PayasosSonidos [22].SetActive (false);
			}
			if (NombrePayaso == "LaSelva24") {
				PayasosSonidos [23].SetActive (true);
			} else {
				PayasosSonidos [23].SetActive (false);
			}
			if (NombrePayaso == "LaSelva25") {
				PayasosSonidos [24].SetActive (true);
			} else {
				PayasosSonidos [24].SetActive (false);
			}
			if (NombrePayaso == "LaSelva26") {
				PayasosSonidos [25].SetActive (true);
			} else {
				PayasosSonidos [25].SetActive (false);
			}
			if (NombrePayaso == "LaSelva27") {
				PayasosSonidos [26].SetActive (true);
			} else {
				PayasosSonidos [26].SetActive (false);
			}
			if (NombrePayaso == "LaSelva28") {
				PayasosSonidos [27].SetActive (true);
			} else {
				PayasosSonidos [27].SetActive (false);
			}
			if (NombrePayaso == "LaSelva29") {
				PayasosSonidos [28].SetActive (true);
			} else {
				PayasosSonidos [28].SetActive (false);
			}
			if (NombrePayaso == "LaSelva30") {
				PayasosSonidos [29].SetActive (true);
			} else {
				PayasosSonidos [29].SetActive (false);
			}

		}
	}

	void CancelarSonidosPayasos(){
		PayasosSonidos [0].SetActive (false);

		PayasosSonidos [1].SetActive (false);

		PayasosSonidos [2].SetActive (false);

		PayasosSonidos [3].SetActive (false);

		PayasosSonidos [4].SetActive (false);

		PayasosSonidos [5].SetActive (false);

		PayasosSonidos [6].SetActive (false);

		PayasosSonidos [7].SetActive (false);

		PayasosSonidos [8].SetActive (false);

		PayasosSonidos [9].SetActive (false);

		PayasosSonidos [10].SetActive (false);

		PayasosSonidos [11].SetActive (false);

		PayasosSonidos [12].SetActive (false);

		PayasosSonidos [13].SetActive (false);

		PayasosSonidos [14].SetActive (false);

		PayasosSonidos [15].SetActive (false);

		PayasosSonidos [16].SetActive (false);

		PayasosSonidos [17].SetActive (false);

		PayasosSonidos [18].SetActive (false);

		PayasosSonidos [19].SetActive (false);

		PayasosSonidos [20].SetActive (false);

		PayasosSonidos [21].SetActive (false);

		PayasosSonidos [22].SetActive (false);

		PayasosSonidos [23].SetActive (false);

		PayasosSonidos [24].SetActive (false);

		PayasosSonidos [25].SetActive (false);

		PayasosSonidos [26].SetActive (false);

		PayasosSonidos [27].SetActive (false);

		PayasosSonidos [28].SetActive (false);

		PayasosSonidos [29].SetActive (false);
	}



	public void CamaraBtn () {
		if (!TakePhoto) {
			PayasoFicha1 ();
			Debug.Log("Entro 1");
		}
		if ((TakePhoto)&&(TempPayaso != NombrePayaso)) {
			PayasoFicha2 ();
			Debug.Log("Entro 2");
		}
	}

	void Comparacion(){

		GameActive = false;

		if (TempPayasoFinal == TempPayasoFinal2) {
			GanasteImage.SetActive (true);
			GanasteImage2.SetActive (true);
			FondoActivo.SetActive (true);
			FondoActivo2.SetActive (true);
			if (!audios.isPlaying) {
				audios.clip = Gano;
				audios.Play ();
				audios.loop = false;
				ManagerMusica.Termino = true;
			}
		} else {
			PerdisteImage.SetActive (true);
			PerdisteImage2.SetActive (true);
			FondoActivo.SetActive (true);
			FondoActivo2.SetActive (true);
			if (!audios.isPlaying) {
				audios.clip = Perdio;
				audios.Play ();
				audios.loop = false;
				ManagerMusica.Termino = true;
			}
		}

	}

	public void VolverMenu(){
		Cargando.SetActive (true);
		Cargando2.SetActive (true);
		GameActive = false;
		CancelarSonidosPayasos ();	
	}

	public void CerrarGame(){
		GameActive = true;
		TakePhoto = false;
		TempPayaso = "";
		NombrePayaso = "";
		TempPayasoFinal = "";
		TempPayasoFinal2 = "";
		FichaBanner.SetActive (false);
		FichaBanner2.SetActive (false);
		PerdisteImage.SetActive (false);
		PerdisteImage2.SetActive (false);
		GanasteImage.SetActive (false);
		GanasteImage2.SetActive (false);
		FondoActivo.SetActive (false);
		FondoActivo2.SetActive (false);
		ManagerMusica.Empezar = true;
		audios.Stop ();
	}

	void PayasoFicha1 (){
		Debug.Log ("ASD");
		if (NombrePayaso == "LaSelva01") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[0];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[0];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva01";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva02") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[1];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[1];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva02";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva03") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[2];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[2];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva03";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva04") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[3];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[3];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva04";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva05") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[4];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[4];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva05";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva06") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[5];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[5];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva06";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva07") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[6];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[6];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva07";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva08") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[7];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[7];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva08";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva09") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[8];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[8];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva09";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva10") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[9];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[9];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva10";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva11") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[10];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[10];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva11";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva12") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[11];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[11];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva12";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva13") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[12];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[12];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva13";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva14") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[13];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[13];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva14";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva15") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[14];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[14];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva15";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva16") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[15];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[15];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva01";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva17") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[16];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[16];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva02";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva18") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[17];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[17];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva03";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva19") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[18];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[18];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva04";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva20") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[19];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[19];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva05";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva21") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[20];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[20];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva06";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva22") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[21];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[21];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva07";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva23") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[22];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[22];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva08";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva24") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[23];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[23];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva09";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva25") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[24];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[24];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva10";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva26") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[25];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[25];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva11";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva27") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[26];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[26];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva12";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva28") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[27];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[27];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva13";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva29") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[28];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[28];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva14";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "LaSelva30") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[29];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[29];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "LaSelva15";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
	}

	void PayasoFicha2 (){
		if (NombrePayaso == "LaSelva01") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[0];
			TempPayasoFinal2 = "LaSelva01";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva02") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[1];
			TempPayasoFinal2 = "LaSelva02";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva03") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[2];
			TempPayasoFinal2 = "LaSelva03";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva04") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[3];
			TempPayasoFinal2 = "LaSelva04";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva05") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[4];
			TempPayasoFinal2 = "LaSelva05";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva06") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[5];
			TempPayasoFinal2 = "LaSelva06";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva07") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[6];
			TempPayasoFinal2 = "LaSelva07";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva08") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[7];
			TempPayasoFinal2 = "LaSelva08";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva09") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[8];
			TempPayasoFinal2 = "LaSelva09";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva10") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[9];
			TempPayasoFinal2 = "LaSelva10";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva11") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[10];
			TempPayasoFinal2 = "LaSelva11";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva12") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[11];
			TempPayasoFinal2 = "LaSelva12";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva13") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[12];
			TempPayasoFinal2 = "LaSelva13";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva14") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[13];
			TempPayasoFinal2 = "LaSelva14";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva15") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[14];
			TempPayasoFinal2 = "LaSelva15";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva16") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[15];
			TempPayasoFinal2 = "LaSelva01";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva17") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[16];
			TempPayasoFinal2 = "LaSelva02";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva18") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[17];
			TempPayasoFinal2 = "LaSelva03";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva19") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[18];
			TempPayasoFinal2 = "LaSelva04";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva20") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[19];
			TempPayasoFinal2 = "LaSelva05";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva21") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[20];
			TempPayasoFinal2 = "LaSelva06";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva22") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[21];
			TempPayasoFinal2 = "LaSelva07";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva23") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[22];
			TempPayasoFinal2 = "LaSelva08";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva24") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[23];
			TempPayasoFinal2 = "LaSelva09";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva25") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[24];
			TempPayasoFinal2 = "LaSelva10";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva26") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[25];
			TempPayasoFinal2 = "LaSelva11";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva27") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[26];
			TempPayasoFinal2 = "LaSelva12";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva28") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[27];
			TempPayasoFinal2 = "LaSelva13";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva29") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[28];
			TempPayasoFinal2 = "LaSelva14";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "LaSelva30") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[29];
			TempPayasoFinal2 = "LaSelva15";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
	}
}
