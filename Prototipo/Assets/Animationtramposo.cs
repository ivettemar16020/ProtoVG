using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtramposo : MonoBehaviour {
	private Animator anim;
	public AudioClip sonido;
	//public AudioSource as;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("activate",false);
		GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sonido;
	}

	void OnTriggerEnter(Collider other){
		GetComponent<AudioSource>().Play();
		if (other.tag == "Player"){
			anim.SetBool("activate",true);
			Score.instance.VidasCount();
			//as.PlayOneShot(sonido, 0.7F);
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
