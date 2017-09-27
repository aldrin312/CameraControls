using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	public float speed;

	Rigidbody2D rBody;
	// Use this for initialization
	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		Vector3 movement = new Vector2(moveHorizontal, 0);
		rBody.velocity = movement * speed;
	}
}
