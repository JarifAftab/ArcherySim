using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour {
	
	public Rigidbody player;
	public GameObject box;
	public Camera cam;
	public bool arrowPending = false;
	public GameObject reticle;
	public static int arrowCount = 3;
	public Text arrowCounter;
	public static bool arrowLoaded = true;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		arrowCounter.text = "x"+arrowCount;
		
		if(BowController.arrowLoaded == true && Input.GetMouseButton(0) && arrowPending == false && arrowCount > 0){ //An arrow can only be shot when there is a pending arrow, and arrow loaded and the player his the mouse button
			
			shootArrow();
			
		}
		if(Input.GetKey(KeyCode.R) && !Input.GetMouseButton(1) && !(ArrowController.arrowCount <= 0)){ //Can only reload arrow when not drawing and player still has arrows
			arrowPending = false;
			TargetDetectionMain.hit = false;
			arrowLoaded = true;
		}
		
		
	}
	
	public void shootArrow(){ //creates an arrow object with 3D properties
		GameObject arrow = Instantiate(box);
		arrow.AddComponent<Rigidbody>();
		arrow.AddComponent<CapsuleCollider>();
		arrow.AddComponent<FlightController>();
		arrow.GetComponent<FlightController>().arrow = arrow;
		arrow.tag = "Arrow";
		arrow.GetComponent<Rigidbody>().mass = 0.005f;
		Vector3 spawn = reticle.transform.position + cam.transform.forward * 2;
		arrow.transform.position = spawn;
		arrow.transform.rotation = Quaternion.identity;
		arrow.transform.localScale = new Vector3(0.11f,0.11f,0.11f);
		arrow.transform.LookAt (reticle.transform.forward); //positions the arrow relative to camera
		//arrow.transform.rotation = Quaternion.Lerp (arrow.transform.rotation,cam.transform.rotation,Time.deltaTime * 1);
		arrow.transform.Rotate(0,90,0); //rotates 90 degrees so it is straight
		arrow.GetComponent<Rigidbody>().AddForce( cam.transform.forward * 10.0f);
		arrowPending = true;
		arrowCount--;
		arrowLoaded = false;
		
		//add own script that manages when it hits something and causes it to stop and or delete
		
		
		
		
	}
}
