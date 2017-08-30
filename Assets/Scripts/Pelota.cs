using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pelota : MonoBehaviour {

	public GameObject raquetaIzquierda;
	public GameObject raquetaDerecha;
	public float speed;
	private int auxDireccion;
	private GameObject raqueta;
	private GameObject raqueta2;
	private bool attach = true;

	void Start () {
		auxDireccion = 1;
		raqueta = raquetaIzquierda;
		raqueta2 = raquetaDerecha;
		transform.position = raquetaIzquierda.transform.position;
	}
	
	void Update () {
		if (attach) {
			transform.position = new Vector2 (raqueta.transform.position.x + (0.5f * auxDireccion), raqueta.transform.position.y);
		} else {
			raqueta2.GetComponent<Raqueta>().setSigue (true);
			raqueta.GetComponent<Raqueta> ().setSigue (false);
		}
	}

	public void setAttach(bool attach){
		this.attach = attach;
	}

	public bool getAttach(){
		return attach;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (Marcador.marcarPunto (coll.gameObject)) {
			setLadoSaque ();
			attach = true;
		}
	}

	void setLadoSaque(){
		if (raquetaIzquierda.GetComponent<Raqueta>().getSigue()) {
			raqueta = raquetaIzquierda;
			raqueta2 = raquetaDerecha;
			auxDireccion = 1;
		} else {
			raqueta = raquetaDerecha;
			raqueta2 = raquetaIzquierda;
			auxDireccion = -1;
		}
	}

	public int getAuxDireccion(){
		return auxDireccion;
	}
}
