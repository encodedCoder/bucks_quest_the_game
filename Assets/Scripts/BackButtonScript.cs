using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour {

	public string scene;
	public AudioClip backButtonSound;

	private bool loadLock;


	void Update(){
		if (Input.GetKeyDown ("escape") && !loadLock) {

			if (backButtonSound) {
				AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
			}

			LoadScene ();
		}
	}


	public void OnBackButtonClick(){
		
		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		if(!loadLock)
		LoadScene ();
	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (scene);
	}

}
