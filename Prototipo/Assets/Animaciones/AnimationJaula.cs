using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationJaula : MonoBehaviour {
	private Animator anim;
	public AudioClip sonido;
	private bool paused = false;
	private float speed = 0.1f;
	//public AudioSource as;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator>();
		anim.SetBool("activate",false);
		GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sonido;
        
	}

	void OnTriggerEnter(Collider other){
		GetComponent<AudioSource>().Play();
		if (other.tag == "Player"){
			anim.SetBool("activate",true);
			Score.instance.VidasCount();
			GetComponent<Rigidbody>().velocity = Vector3.up * speed;
			//as.PlayOneShot(sonido, 0.7F);
			/*if (paused)
				Time.timeScale = 1;
			else
				Time.timeScale = 0;
			paused = !paused;*/
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
			anim.SetBool("activate", true);
			/*
			if (paused)
				Time.timeScale = 1;
			else
				Time.timeScale = 0;
			paused = !paused;*/
		}
	}
	
	// Update is called once per frame
	void Update () {

		//GameObject.FindGameObjectWithTag("Player").transform.position;
	}
}
