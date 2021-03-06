﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTwo : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("PlayerOne");
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}
