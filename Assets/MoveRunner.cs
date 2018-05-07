using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRunner : MonoBehaviour
{
	// Use this for initialization

	public Sprite left;
	public Sprite right;
	public Sprite idle;

	GameObject playerOne;
	GameObject playerTwo;

	public int speed;
	public SpriteRenderer spriterender1;
	public SpriteRenderer spriterender2;

	void Start ()
	{
		playerOne = GameObject.Find("PlayerTwo");
		playerTwo = GameObject.Find("PlayerOne");

		spriterender1 = playerOne.GetComponent<SpriteRenderer>();
		spriterender2 = playerTwo.GetComponent<SpriteRenderer>();
		speed = 5;
	}

	// Update is called once per frame
	int _skippedFrames;
	void Update()
	{
		if (_skippedFrames >= 4)
		{
			_skippedFrames = 0;
			if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
			{
				if (spriterender1.sprite.name == left.name)
				{
					spriterender1.sprite = right;
				}
				else
				{
					spriterender1.sprite = left;
				}
			}
			else
			{
				spriterender1.sprite = idle;
			}
			if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow)
				|| Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow))
			{
				if (spriterender2.sprite.name == left.name)
					spriterender2.sprite = right;
				else
					spriterender2.sprite = left;
			}
			else
				spriterender2.sprite = idle;
		}
		else
			_skippedFrames++;
		
		if (Input.GetKey(KeyCode.W))
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		else if (Input.GetKey(KeyCode.A))
		{
				playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
				playerOne.transform.eulerAngles = new Vector3(0, 0, 90);
		}
			
			else if (Input.GetKey(KeyCode.S))
		{

			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 180);
		}

		else if (Input.GetKey(KeyCode.D))
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
			playerOne.transform.eulerAngles = new Vector3(0, 0, 270);
		}
		else
		{
			playerOne.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 90);
		}
			
		else if (Input.GetKey(KeyCode.DownArrow))
		{

			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 180);
		}

		else if (Input.GetKey(KeyCode.RightArrow))
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
			playerTwo.transform.eulerAngles = new Vector3(0, 0, 270);
		}
		else
		{
			playerTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}
		
	}
}
