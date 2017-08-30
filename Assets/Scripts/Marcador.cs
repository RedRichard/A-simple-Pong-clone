using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Marcador : MonoBehaviour {

	private static GameObject marcadorIzquierdo;
	private static GameObject marcadorDerecho;
	private static int marcadorIzq = 0;
	private static int marcadorDer = 0;

	void Start () {
		marcadorIzquierdo = GameObject.FindGameObjectWithTag ("MarcadorIzquierdo");
		marcadorDerecho = GameObject.FindGameObjectWithTag ("MarcadorDerecho");
	}

	public static bool marcarPunto(GameObject coll){
		if (coll.tag == "PuntoJugadorIzquierda") {
			print ("Punto para el jugador de la izquierda");
			marcadorIzq += 1;
			marcadorIzquierdo.GetComponent<Text> ().text = marcadorIzq.ToString ();
			Debug.Log ("Marcando");
			return true;
		}
		if (coll.tag == "PuntoJugadorDerecha") {
			print ("Punto para el jugador de la derecha");
			marcadorDer += 1;
			marcadorDerecho.GetComponent<Text> ().text = marcadorDer.ToString ();
			return true;
		}
		LevelManager.cargarGanador ();
		return false;
	}

	public static int getMarcadorIzquierdo(){
		return marcadorIzq;
	}		

	public static int getMarcadorDerecho(){
		return marcadorDer;
	}

	public static void resetMarcadores(){
		marcadorIzq = 0;
		marcadorDer = 0;
	}
}
