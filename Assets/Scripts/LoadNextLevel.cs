using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {

	public string scene;

	private bool loadLock;

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (scene);
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player" && !loadLock) {
			LoadScene ();
		}
	}

	public void OnExitButtonClick(){
		Application.Quit ();
	}
}
