using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class theEndLevel : MonoBehaviour {

	public string sceneName;
	public float sceneWaitTime = 8.0f;
	public float timer = 0.0f;
	public AudioClip goBackSound;
	private bool loadLock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (sceneWaitTime < timer) {
			if (Input.GetKeyDown ("space") && !loadLock) {

				if (goBackSound) {
					AudioSource.PlayClipAtPoint (goBackSound, transform.position);
				}

				LoadScene ();
			} 
		}

		if (Input.GetKeyDown (KeyCode.RightShift)) {
			Application.Quit ();
		}
	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (sceneName);
	}

	public void OnExitButtonClick(){
		Application.Quit ();
	}
}
