using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRaqueta1 : MonoBehaviour {

	public float velocidadMovimiento;
	Vector2 posicion;

	void Start () {
		posicion = new Vector2 (this.transform.position.x, this.transform.position.y);
	}
	
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * Time.deltaTime * velocidadMovimiento);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.down * Time.deltaTime * velocidadMovimiento);
		}
		posicion.y = Mathf.Clamp (this.transform.position.y, 0f, 12f);
		this.transform.position = posicion;
	}
}
