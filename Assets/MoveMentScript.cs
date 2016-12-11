using UnityEngine;
using System.Collections;

public class MoveMentScript : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDir = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) {

			moveDir = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDir = transform.TransformDirection (moveDir);
			moveDir *= speed;
			if (Input.GetButton ("Jump")) {
				moveDir.y = jumpSpeed;
			}
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

		}
	
	}

