using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Si se presiona UpArrow, se movera hacia arriba.
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate (Vector3.up);

		}


		//Si se presiona DownArrow, se movera hacia abajo.
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate (Vector3.down);

		}

		//Si se presiona LeftArrow, se movera hacia izquierda.
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate (Vector3.left);

		}

		//Si se presiona RightArrow, se movera hacia derecha.
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate (Vector3.right);

		}
		
	}
}
