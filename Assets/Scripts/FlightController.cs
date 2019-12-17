using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour {
	public GameObject arrow;
	public bool arrowAlive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if((TargetDetectionMain.hit == true) && arrowAlive == true){ //Deletes all stray arrows when an arrow strikes the target
			print("Yes");
			Object.Destroy(arrow);
			arrowAlive = false;
		}
	}
	
	
}
