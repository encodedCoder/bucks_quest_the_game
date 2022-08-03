using UnityEngine;
using System.Collections;

public class BuckControls : MonoBehaviour {

	Animator animator;
	Rigidbody2D body2D;
	SpriteRenderer render2D;

	public float walkSpeed = 5;
	public float runSpeed  = 10;
	public float jumpSpeed = 20;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		body2D = GetComponent<Rigidbody2D> ();
		render2D = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float speedX = 0f;
		float speedY = 0f;

//==================================================================================================
		//Buck vanilla walk
//==================================================================================================
		if (Input.GetKey ("right") && !Input.GetKey (KeyCode.RightControl)) {
			speedX = walkSpeed;
			render2D.flipX = false;
			animator.SetInteger ("AnimState", 1);
		} else if (Input.GetKey ("left")&& !Input.GetKey (KeyCode.RightControl)) {
			speedX = -walkSpeed;
			render2D.flipX = true;
			animator.SetInteger ("AnimState", 1);
		}else
			animator.SetInteger ("AnimState", 0);
//==================================================================================================
		//Buck Jump
//==================================================================================================
		if (Input.GetKey ("up")) {
			body2D.gravityScale = 20;
			speedY = jumpSpeed;
			animator.SetInteger ("AnimState", 3);
		}
//==================================================================================================
		//Buck Run(shift key)
//==================================================================================================
		if (Input.GetKey ("right") && Input.GetKey (KeyCode.RightShift)) {
			speedX = runSpeed;
			render2D.flipX = false;
			animator.SetInteger ("AnimState", 2);
		} else if (Input.GetKey ("left")  && Input.GetKey (KeyCode.RightShift)) {
			speedX = -runSpeed;
			render2D.flipX = true;
			animator.SetInteger ("AnimState", 2);
		}
//==================================================================================================
		//Buck CTRL walk
//==================================================================================================

		//==========================*****************************============================
		if (render2D.flipX == false && Input.GetKey (KeyCode.RightControl) && Input.GetKey ("right")) {
			//render2D.flipX = false;
			speedX = walkSpeed;
			animator.SetInteger ("AnimState", 4);
		}
		else if (render2D.flipX == false && Input.GetKey (KeyCode.RightControl) && Input.GetKey ("left")) {
			//render2D.flipX = false;
			speedX = -walkSpeed;
			animator.SetInteger ("AnimState", 5); 
		} 
		else if (render2D.flipX == true && Input.GetKey (KeyCode.RightControl) && Input.GetKey ("right")) {
			//render2D.flipX = true;
			speedX = walkSpeed;
			animator.SetInteger ("AnimState", 5);
		} 
		else if (render2D.flipX == true && Input.GetKey (KeyCode.RightControl) && Input.GetKey ("left")) {
			//render2D.flipX = true;
			speedX = -walkSpeed;
			animator.SetInteger ("AnimState", 4);
		}
		//==========================*****************************============================

//==================================================================================================
		//Assgining the locomotion
//==================================================================================================
		body2D.velocity = new Vector2 (speedX, speedY);
//==================================================================================================
	}
}
