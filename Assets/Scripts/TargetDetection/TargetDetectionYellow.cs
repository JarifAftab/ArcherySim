using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDetectionYellow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter(Collision a){
		
		if(TargetDetectionMain.hit == false){
			TargetDetectionMain.score+=9;
			TargetDetectionMain.hit = true;
		}
		
	}
}
