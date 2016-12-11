using UnityEngine;
using System.Collections;

public class JumpAnim : MonoBehaviour {

	public bool JumpBool;
	private Animator anim;

	// Use this for initialization
	void Start () {

	anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (JumpBool == true) {

			anim.SetBool ("JumpBool", true);

		} else {
			anim.SetBool ("JumpBool", false);
		}
	
	}
}
