using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControl : MonoBehaviour {

	public void OnCollisionEnter(Collision a){
		
		PlayerController.hasJumped = false;
	}
}
