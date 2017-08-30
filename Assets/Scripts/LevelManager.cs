using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void CargarNivel(string nombreNivel){
		SceneManager.LoadScene (nombreNivel, LoadSceneMode.Single);
	}

	public void Salir(){
		Application.Quit ();
	}

	public static void cargarGanador(){
		if (Marcador.getMarcadorIzquierdo () == 10) {
			Marcador.resetMarcadores ();
			SceneManager.LoadScene ("PantallaGanaJugador1", LoadSceneMode.Single);
		}
		if (Marcador.getMarcadorDerecho () == 10) {
			Marcador.resetMarcadores ();
			SceneManager.LoadScene ("PantallaGanaJugador2", LoadSceneMode.Single);
		}
	}
}
