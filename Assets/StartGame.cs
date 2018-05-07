using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	public Button button; 

	private void Start()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(Click);
	}

	public void Click()
	{
		SceneManager.LoadScene("DesignerScene");
	}

}
