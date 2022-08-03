using UnityEngine;
using System.Collections;

public class GrabDoor : MonoBehaviour {

	public float walkSpeed = 1;

	void OnTriggerStay2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			if (Input.GetKey (KeyCode.RightControl) && Input.GetKey ("left")) {
				this.transform.Translate (-walkSpeed, 0f, 0f, Space.Self);
			}
		}
	}

}
