using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPayasos : MonoBehaviour {

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

			if (NombrePayaso == "Payaso01") {
				PayasosSonidos [0].SetActive (true);
			} else {
				PayasosSonidos [0].SetActive (false);
			}
			if (NombrePayaso == "Payaso02") {
				PayasosSonidos [1].SetActive (true);
			} else {
				PayasosSonidos [1].SetActive (false);
			}
			if (NombrePayaso == "Payaso03") {
				PayasosSonidos [2].SetActive (true);
			} else {
				PayasosSonidos [2].SetActive (false);
			}
			if (NombrePayaso == "Payaso04") {
				PayasosSonidos [3].SetActive (true);
			} else {
				PayasosSonidos [3].SetActive (false);
			}
			if (NombrePayaso == "Payaso05") {
				PayasosSonidos [4].SetActive (true);
			} else {
				PayasosSonidos [4].SetActive (false);
			}
			if (NombrePayaso == "Payaso06") {
				PayasosSonidos [5].SetActive (true);
			} else {
				PayasosSonidos [5].SetActive (false);
			}
			if (NombrePayaso == "Payaso07") {
				PayasosSonidos [6].SetActive (true);
			} else {
				PayasosSonidos [6].SetActive (false);
			}
			if (NombrePayaso == "Payaso08") {
				PayasosSonidos [7].SetActive (true);
			} else {
				PayasosSonidos [7].SetActive (false);
			}
			if (NombrePayaso == "Payaso09") {
				PayasosSonidos [8].SetActive (true);
			} else {
				PayasosSonidos [8].SetActive (false);
			}
			if (NombrePayaso == "Payaso10") {
				PayasosSonidos [9].SetActive (true);
			} else {
				PayasosSonidos [9].SetActive (false);
			}
			if (NombrePayaso == "Payaso11") {
				PayasosSonidos [10].SetActive (true);
			} else {
				PayasosSonidos [10].SetActive (false);
			}
			if (NombrePayaso == "Payaso12") {
				PayasosSonidos [11].SetActive (true);
			} else {
				PayasosSonidos [11].SetActive (false);
			}
			if (NombrePayaso == "Payaso13") {
				PayasosSonidos [12].SetActive (true);
			} else {
				PayasosSonidos [12].SetActive (false);
			}
			if (NombrePayaso == "Payaso14") {
				PayasosSonidos [13].SetActive (true);
			} else {
				PayasosSonidos [13].SetActive (false);
			}
			if (NombrePayaso == "Payaso15") {
				PayasosSonidos [14].SetActive (true);
			} else {
				PayasosSonidos [14].SetActive (false);
			}
			if (NombrePayaso == "Payaso16") {
				PayasosSonidos [15].SetActive (true);
			} else {
				PayasosSonidos [15].SetActive (false);
			}
			if (NombrePayaso == "Payaso17") {
				PayasosSonidos [16].SetActive (true);
			} else {
				PayasosSonidos [16].SetActive (false);
			}
			if (NombrePayaso == "Payaso18") {
				PayasosSonidos [17].SetActive (true);
			} else {
				PayasosSonidos [17].SetActive (false);
			}
			if (NombrePayaso == "Payaso19") {
				PayasosSonidos [18].SetActive (true);
			} else {
				PayasosSonidos [18].SetActive (false);
			}
			if (NombrePayaso == "Payaso20") {
				PayasosSonidos [19].SetActive (true);
			} else {
				PayasosSonidos [19].SetActive (false);
			}
			if (NombrePayaso == "Payaso21") {
				PayasosSonidos [20].SetActive (true);
			} else {
				PayasosSonidos [20].SetActive (false);
			}
			if (NombrePayaso == "Payaso22") {
				PayasosSonidos [21].SetActive (true);
			} else {
				PayasosSonidos [21].SetActive (false);
			}
			if (NombrePayaso == "Payaso23") {
				PayasosSonidos [22].SetActive (true);
			} else {
				PayasosSonidos [22].SetActive (false);
			}
			if (NombrePayaso == "Payaso24") {
				PayasosSonidos [23].SetActive (true);
			} else {
				PayasosSonidos [23].SetActive (false);
			}
			if (NombrePayaso == "Payaso25") {
				PayasosSonidos [24].SetActive (true);
			} else {
				PayasosSonidos [24].SetActive (false);
			}
			if (NombrePayaso == "Payaso26") {
				PayasosSonidos [25].SetActive (true);
			} else {
				PayasosSonidos [25].SetActive (false);
			}
			if (NombrePayaso == "Payaso27") {
				PayasosSonidos [26].SetActive (true);
			} else {
				PayasosSonidos [26].SetActive (false);
			}
			if (NombrePayaso == "Payaso28") {
				PayasosSonidos [27].SetActive (true);
			} else {
				PayasosSonidos [27].SetActive (false);
			}
			if (NombrePayaso == "Payaso29") {
				PayasosSonidos [28].SetActive (true);
			} else {
				PayasosSonidos [28].SetActive (false);
			}
			if (NombrePayaso == "Payaso30") {
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
		if (NombrePayaso == "Payaso01") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[0];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[0];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso01";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso02") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[1];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[1];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso02";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso03") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[2];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[2];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso03";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso04") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[3];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[3];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso04";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso05") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[4];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[4];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso05";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso06") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[5];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[5];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso06";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso07") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[6];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[6];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso07";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso08") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[7];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[7];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso08";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso09") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[8];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[8];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso09";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso10") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[9];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[9];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso10";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso11") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[10];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[10];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso11";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso12") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[11];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[11];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso12";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso13") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[12];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[12];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso13";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso14") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[13];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[13];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso14";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso15") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[14];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[14];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso15";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso16") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[15];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[15];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso01";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso17") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[16];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[16];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso02";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso18") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[17];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[17];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso03";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso19") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[18];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[18];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso04";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso20") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[19];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[19];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso05";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso21") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[20];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[20];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso06";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso22") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[21];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[21];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso07";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso23") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[22];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[22];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso08";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso24") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[23];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[23];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso09";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso25") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[24];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[24];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso10";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso26") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[25];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[25];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso11";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso27") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[26];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[26];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso12";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso28") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[27];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[27];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso13";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso29") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[28];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[28];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso14";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
		if (NombrePayaso == "Payaso30") {
			PayasoFichaImage.GetComponent<Image>().sprite = PayasosFotos[29];
			PayasoFichaImage2.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal1.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal1B.GetComponent<Image>().sprite = PayasosFotos[29];
			TakePhoto = true;
			TempPayaso = NombrePayaso;
			TempPayasoFinal = "Payaso15";
			FichaBanner.SetActive (true);
			FichaBanner2.SetActive (true);
		}
	}

	void PayasoFicha2 (){
		if (NombrePayaso == "Payaso01") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[0];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[0];
			TempPayasoFinal2 = "Payaso01";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso02") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[1];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[1];
			TempPayasoFinal2 = "Payaso02";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso03") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[2];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[2];
			TempPayasoFinal2 = "Payaso03";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso04") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[3];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[3];
			TempPayasoFinal2 = "Payaso04";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso05") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[4];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[4];
			TempPayasoFinal2 = "Payaso05";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso06") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[5];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[5];
			TempPayasoFinal2 = "Payaso06";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso07") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[6];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[6];
			TempPayasoFinal2 = "Payaso07";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso08") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[7];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[7];
			TempPayasoFinal2 = "Payaso08";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso09") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[8];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[8];
			TempPayasoFinal2 = "Payaso09";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso10") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[9];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[9];
			TempPayasoFinal2 = "Payaso10";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso11") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[10];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[10];
			TempPayasoFinal2 = "Payaso11";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso12") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[11];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[11];
			TempPayasoFinal2 = "Payaso12";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso13") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[12];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[12];
			TempPayasoFinal2 = "Payaso13";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso14") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[13];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[13];
			TempPayasoFinal2 = "Payaso14";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso15") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[14];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[14];
			TempPayasoFinal2 = "Payaso15";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso16") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[15];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[15];
			TempPayasoFinal2 = "Payaso01";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso17") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[16];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[16];
			TempPayasoFinal2 = "Payaso02";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso18") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[17];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[17];
			TempPayasoFinal2 = "Payaso03";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso19") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[18];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[18];
			TempPayasoFinal2 = "Payaso04";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso20") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[19];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[19];
			TempPayasoFinal2 = "Payaso05";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso21") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[20];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[20];
			TempPayasoFinal2 = "Payaso06";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso22") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[21];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[21];
			TempPayasoFinal2 = "Payaso07";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso23") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[22];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[22];
			TempPayasoFinal2 = "Payaso08";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso24") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[23];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[23];
			TempPayasoFinal2 = "Payaso09";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso25") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[24];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[24];
			TempPayasoFinal2 = "Payaso10";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso26") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[25];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[25];
			TempPayasoFinal2 = "Payaso11";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso27") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[26];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[26];
			TempPayasoFinal2 = "Payaso12";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso28") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[27];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[27];
			TempPayasoFinal2 = "Payaso13";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso29") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[28];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[28];
			TempPayasoFinal2 = "Payaso14";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
		if (NombrePayaso == "Payaso30") {
			ImagenFinal2.GetComponent<Image>().sprite = PayasosFotos[29];
			ImagenFinal2B.GetComponent<Image>().sprite = PayasosFotos[29];
			TempPayasoFinal2 = "Payaso15";
			Comparacion ();
			CancelarSonidosPayasos ();
		}
	}
}
