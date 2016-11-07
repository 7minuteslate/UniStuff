using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public float rotationspeed;
	void start()
	{
		speed = 0f;
		rotationspeed = 0f;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.W)) 
		{
			transform.Translate (0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			transform.Translate (0, 0, -speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotationspeed, Space.World);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * rotationspeed, Space.World);
		}


	}

}