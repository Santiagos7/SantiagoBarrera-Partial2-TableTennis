using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Si se presiona W, se movera hacia arriba.
		if (Input.GetKey(KeyCode.W))
		{
			this.transform.Translate (Vector3.up);

		}


		//Si se presiona S, se movera hacia abajo.
		if (Input.GetKey(KeyCode.S))
		{
			this.transform.Translate (Vector3.down);

		}

		//Si se presiona A, se movera hacia izquierda.
		if (Input.GetKey(KeyCode.A))
		{
			this.transform.Translate (Vector3.left);

		}

		//Si se presiona D, se movera hacia derecha.
		if (Input.GetKey(KeyCode.D))
		{
			this.transform.Translate (Vector3.right);

		}
		
	}
}
