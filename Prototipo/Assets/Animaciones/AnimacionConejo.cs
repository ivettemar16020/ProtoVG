using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionConejo : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.CrossFade("quieto", 0.1f);
		
		while (Input.GetKeyDown(KeyCode.B)){
			anim.CrossFade("caminar", 0.1f);
		}
	}
}
