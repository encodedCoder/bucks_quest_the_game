using UnityEngine;
using System.Collections;

public class ControlButtonsScript : MonoBehaviour {

	public new string name = "Untitled";

	// Use this for initialization
	void Start () {
		for (int i = 1; i <= 10; i++) {
			print (i);
			if (i == 5)
				print ("is 5");
		}


		b_animator = buck.GetComponent<Animator> ();
		b_body2D = buck.GetComponent<Rigidbody2D> ();
		b_render2D = buck.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame

	public GameObject buck;
	Animator b_animator;
	Rigidbody2D b_body2D;
	SpriteRenderer b_render2D;

	public float walkSpeed = 5;
//	public float runSpeed  = 10;
//	public float jumpSpeed = 20;

	float b_speedX = 0f;
	float b_speedY = 0f;

	public void OnMoveLeftButtonClick(){
		Debug.Log ("Left Clicked");

		b_speedX = -walkSpeed;
		b_render2D.flipX = false;
		b_animator.SetInteger ("AnimState", 1);

		b_body2D.velocity = new Vector2 (b_speedX, b_speedY);
	}

	public void OnMoveRightButtonClick(){
		Debug.Log ("Right Clicked");

		b_speedX = walkSpeed;
		b_render2D.flipX = false;
		b_animator.SetInteger ("AnimState", 1);

		b_body2D.velocity = new Vector2 (b_speedX, b_speedY);
	}

	public void OnJumpButtonClick(){
		Debug.Log ("Jump Clicked");
	}

	public void OnGrabButtonClick(){
		Debug.Log ("Grab Clicked");
	}
}
