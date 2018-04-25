using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtramposo : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("activate",false);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
			anim.SetBool("activate",true);
			Score.instance.VidasCount();
		}
		if (other.tag != "Player"){
			anim.SetBool("activate", false);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player"){
			anim.SetBool("activate",false);
		}
		if (other.tag != "Player"){
			anim.SetBool("activate", true		);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
