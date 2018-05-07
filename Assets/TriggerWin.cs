using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerWin : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "PlayerOne")
			SceneManager.LoadScene("GameOver1");
		else
			SceneManager.LoadScene("GameOver");
	}
}
