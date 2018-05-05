using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRunner : MonoBehaviour
{
	// Use this for initialization

	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		GameObject playerOne = GameObject.Find("PlayerOne");
		GameObject playerTwo = GameObject.Find("PlayerTwo");

		if (Input.GetKey(KeyCode.W))
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		else if (Input.GetKey(KeyCode.A))
		{
				playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
				playerOne.transform.eulerAngles = new Vector3(0, 0, 90);
		}
			
			else if (Input.GetKey(KeyCode.S))
		{

			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 180);
		}

		else if (Input.GetKey(KeyCode.D))
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 270);
		}
		else
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 90);
		}
			
		else if (Input.GetKey(KeyCode.DownArrow))
		{

			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 180);
		}

		else if (Input.GetKey(KeyCode.RightArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 270);
		}
		else
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}
		
	}
}
