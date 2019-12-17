using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {
	
	public Rigidbody Player;
	public bool active = true;
	
	public void moveTowardPlayer(){
		
		
		if(Player.transform.position.x > this.transform.position.x){
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.x = 1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		else{
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.x = -1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		
		if(Player.transform.position.z > this.transform.position.z){
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.z = 1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		else{
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.z = -1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		
		if(Player.transform.position.y > this.transform.position.y){
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.y = 1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		else{
			Vector3 speedModifier = this.GetComponent<Rigidbody>().velocity;
			speedModifier.y = -1;
			this.GetComponent<Rigidbody>().velocity = speedModifier;
		}
		
	}
	
	public void OnCollisionEnter(Collision a){
		if(a.gameObject.tag == "Arrow"){	
			active = false;
			Destroy(this.GetComponent<Rigidbody>());
			Destroy(this.GetComponent<CapsuleCollider>());
			Destroy(this.GetComponent<MeshRenderer>());
			Destroy(this.GetComponent<GameObject>());
			
			ZombieLevelController.kills++;
			ZombieLevelController.zombieCount--;
		}
        else if (a.gameObject.tag == "Player"){
            ZombieLevelController.dead = true;
        }
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(active == true){
			moveTowardPlayer();
		}
		else{
			
		}
		
	}
	
	
}
