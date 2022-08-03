using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour {

	private bool loadLock;

	public AudioClip backButtonSound;
	public string nextSceneName;
	public GameObject panel_01, panel_02, panel_03, panel_04, backButton;

	// Use this for initialization
	void Start () {
		panel_01.SetActive (true);
		panel_02.SetActive (false);
		panel_03.SetActive (false);
		panel_04.SetActive (false);
		backButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (panel_02.activeInHierarchy && !panel_01.activeInHierarchy && !panel_03.activeInHierarchy
			&& !panel_04.activeInHierarchy && Input.GetKeyDown ("escape")) {

			if (backButtonSound) {
				AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
			}

			panel_01.SetActive (true);
			panel_02.SetActive (false);
			panel_03.SetActive (false);
			panel_04.SetActive (false);
			backButton.SetActive (false);
		}else if (panel_03.activeInHierarchy && !panel_01.activeInHierarchy && !panel_02.activeInHierarchy
			&& !panel_04.activeInHierarchy && Input.GetKeyDown ("escape")){

			if (backButtonSound) {
				AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
			}

			panel_01.SetActive (true);
			panel_02.SetActive (false);
			panel_03.SetActive (false);
			panel_04.SetActive (false);
			backButton.SetActive (false);
		}else if (panel_04.activeInHierarchy && !panel_01.activeInHierarchy && !panel_03.activeInHierarchy
			&& !panel_02.activeInHierarchy && Input.GetKeyDown ("escape")){

			if (backButtonSound) {
				AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
			}

			panel_01.SetActive (true);
			panel_02.SetActive (false);
			panel_03.SetActive (false);
			panel_04.SetActive (false);
			backButton.SetActive (false);
		}
	}

	public void OnStartGameClick(){

		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		if (!loadLock) {
			loadLock = true;
			LoadScene ();
		}
	}

	public void OnInstructionsClick(){

		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		panel_01.SetActive (false);
		panel_02.SetActive (true);
		panel_03.SetActive (false);
		panel_04.SetActive (false);
		backButton.SetActive (true);
	}

	public void OnCreditsClick(){

		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		panel_01.SetActive (false);
		panel_02.SetActive (false);
		panel_03.SetActive (true);
		panel_04.SetActive (false);
		backButton.SetActive (true);
	}

	public void OnAboutClick(){

		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		panel_01.SetActive (false);
		panel_02.SetActive (false);
		panel_03.SetActive (false);
		panel_04.SetActive (true);
		backButton.SetActive (true);
	}

	public void OnBackButton(){

		if (backButtonSound) {
			AudioSource.PlayClipAtPoint (backButtonSound, transform.position);
		}

		panel_01.SetActive (true);
		panel_02.SetActive (false);
		panel_03.SetActive (false);
		panel_04.SetActive (false);
		backButton.SetActive (false);
	}

	public void OnExitButtonClick(){
		Application.Quit ();
	}


	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (nextSceneName);
	}
}
