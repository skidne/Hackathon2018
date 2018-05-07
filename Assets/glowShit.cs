using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowShit : MonoBehaviour {

	[SerializeField]
	SpriteRenderer glowshit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var color = glowshit.color;
		color.a = (Mathf.Sin(Time.time) + 1)/2f;
		glowshit.color = color;
	}
}
