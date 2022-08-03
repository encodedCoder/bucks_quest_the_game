using UnityEngine;
using System.Collections;

public class PullDoorUp : MonoBehaviour {

	public float walkSpeed = 1;

	void OnTriggerStay2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			if (Input.GetKey (KeyCode.RightControl) && Input.GetKey ("up")) {
				this.transform.Translate (0f, walkSpeed, 0f, Space.Self);
			}
		}
	}

}
