using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRunner : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);
			transform.eulerAngles = Vector3.up;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
			transform.eulerAngles = Vector3.left;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);
			transform.eulerAngles = Vector3.down;
		} 
		else if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
			transform.eulerAngles = Vector3.right;
		}
		else
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}
	}
}
