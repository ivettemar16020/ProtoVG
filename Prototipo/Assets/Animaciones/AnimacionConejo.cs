using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionConejo : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator>();
	}
	
	void Update () {
		//anim.CrossFade("quieto", 0.1f);
		
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			anim.CrossFade("caminar", 0.1f);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			anim.SetBool("isWalking", true);
			anim.SetBool("isQuieto", false);
		}
		else{
			anim.SetBool("isWalking", false);
			anim.SetBool("isQuieto", true);
		}

		//if (Input.GetKeyDown(KeyCode.UpArrow)){
		//	anim.CrossFade("caminar", 0.1f);
		//}
	}
}
