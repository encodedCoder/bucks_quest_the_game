using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

	public Text instructionText;
	public string nextSceneName;
	public float waitTime = 14.0f;
	public float timer = 0.0f;

//	public float timerValue; 

	private bool loadLock;

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR_WIN
		instructionText.text = "Press Space to continue";
		#elif UNITY_ANDROID
		instructionText.text = "Touch Anywhere to continue";
		#endif
		
	}


	void Update () {
		timer += Time.deltaTime;

		if (waitTime < timer && !loadLock) {
			if (Input.GetKeyDown ("space") || Input.touchCount > 0) {
				loadLock = true;
				LoadScene ();
			}
		}

		if (Input.GetKeyDown ("escape") && !loadLock) {
			loadLock = true;
			LoadScene ();
		}
	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (nextSceneName);
	}
}
