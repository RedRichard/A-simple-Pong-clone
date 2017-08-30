using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour {

	private bool lanzar = true;
	private bool sigue;
	private Pelota pelota;
	private Vector2 auxDireccion;

	void Start () {
		pelota = GameObject.FindGameObjectWithTag ("Pelota").GetComponent<Pelota>();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && lanzar) {
			aplicarFuerza ();
			lanzar = false;
		}
		if (pelota.getAttach ()) {
			lanzar = true;
		}
	}

	void aplicarFuerza () {
		pelota.setAttach (false);
		auxDireccion = new Vector2 (0f, Random.Range (0f, 4f));
		pelota.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (10f, 0.5f)+auxDireccion * pelota.speed * pelota.getAuxDireccion());
		pelota.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10f,2f)+auxDireccion*pelota.getAuxDireccion();
		sigue = false;
	}

	public bool getSigue(){
		return sigue;
	}

	public void setSigue(bool sigue){
		this.sigue = sigue;
	}
}
