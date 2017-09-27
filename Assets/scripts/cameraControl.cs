using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {
	private Camera cam;
	Rigidbody2D rBody;
	private bool inBackGround1;
	private bool inBackGround2;
	private bool inBackGround3;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		rBody = this.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void FixedUpdate()
	{
		if (inBackGround1 == true)
		{
			cam.transform.position = new Vector3(this.transform.position.x, 0, -1);
			cam.orthographicSize = 0.5f;

		}
		else if (inBackGround2 == true)
		{
			cam.transform.position = new Vector3(1.65f, 0, -1);
			cam.orthographicSize = 2f;
		}
		else if (inBackGround3 == true)
		{
			cam.transform.position = new Vector3(this.transform.position.x, 0, -1);
			if (rBody.velocity.x > 0)
			{
				cam.orthographicSize -= (cam.orthographicSize * 0.02f);
			}
			else if (rBody.velocity.x  <0)
			{
				cam.orthographicSize += (cam.orthographicSize * 0.02f);
			}

			}


	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "1")
		{
			inBackGround1 = true;
			inBackGround2 = false;
			inBackGround3 = false;

		}
		else if(other.tag == "2")
		{
			inBackGround1 = false;
			inBackGround2 = true;
			inBackGround3 = false;
		}
		else if(other.tag == "3")
		{
			inBackGround1 = false;
			inBackGround2 = false;
			inBackGround3 = true;
		}

	}
}
