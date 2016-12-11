using UnityEngine;
using System.Collections;

public class MouseTrapAnim : MonoBehaviour {

	public Animator anim;

	public bool ActivateTrap;


	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (ActivateTrap == true) {

		anim.SetBool("ActivateTrap", true);

		}

	
	}
}
