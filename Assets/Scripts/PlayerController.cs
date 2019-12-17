using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public Rigidbody player;
	public Camera cam;
	public char last;
	public static bool hasJumped = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && last != 'u'){ //Allows characters to move diagnonally
			Vector3 velx = cam.transform.forward * 3.0f;
			Vector3 velz = cam.transform.right * -3.0f;
			
			player.velocity = velx + velz;
			
		}
		else if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && last != 'u'){ //Allows characters to move diagnonally
			Vector3 velx = cam.transform.forward * 3.0f;
			Vector3 velz = cam.transform.right * 3.0f;
			
			player.velocity = velx + velz;
			
		}
		else if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && last != 'u'){ //Allows characters to move diagnonally
			Vector3 velx = cam.transform.forward * -3.0f;
			Vector3 velz = cam.transform.right * -3.0f;
			
			player.velocity = velx + velz;
			
		}
		
		else if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && last != 'u'){ //Allows characters to move diagnonally
			Vector3 velx = cam.transform.forward * -3.0f;
			Vector3 velz = cam.transform.right * 3.0f;
			
			player.velocity = velx + velz;
			
		}
		
		else if (Input.GetKey(KeyCode.A) && last != 'u'){
			 player.velocity = cam.transform.right * -3.0f;
			 last = 'a';
		}
        else if (Input.GetKey(KeyCode.D) && last != 'u'){
            player.velocity = cam.transform.right * 3.0f;
			last = 'd';
		}
        else if (Input.GetKey(KeyCode.W) && last != 'u'){
             player.velocity = cam.transform.forward * 3.0f; 
			
		
			last = 'w';
			
		}
        else if (Input.GetKey(KeyCode.S) && last != 'u'){
            player.velocity = cam.transform.forward * -3.0f;
			last = 's';
		}
		double jumpGround = 1.001;
		if(Input.GetKey(KeyCode.Space) && (double)player.transform.position.y <= jumpGround ){
			 player.velocity = new Vector3(player.velocity.x,6,player.velocity.z);
			 last = 'u';
			 hasJumped = true;
		}
		else if((double)player.transform.position.y <= jumpGround){
			last = 'w';
		}
		
		
		
	}
}



