using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWin : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{
		GameObject msg = GameObject.Find("GameOver");
		msg.GetComponent<TextMesh>().text = "Game Over\n" + other.name + " Won";
//		Destroy(gameObject);
	}
}
