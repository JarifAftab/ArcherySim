using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowController : MonoBehaviour {

	public Camera firstPerson;
	public static bool arrowLoaded = false;
	public SpriteRenderer bow;
	public SpriteRenderer bowExtend;
	public SpriteRenderer arrow;
	public SpriteRenderer arrow_Extend;
	public Slider chargeMetre;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(ArrowController.arrowLoaded == false){
			
			arrow.enabled = false;
		}
		if(ArrowController.arrowLoaded == true){
			
			arrow.enabled = true;
		}
	
		
		if(Input.GetMouseButton(1) && ArrowController.arrowLoaded == true && ArrowController.arrowCount > 0){
			firstPerson.fieldOfView =  45.0f;
			arrowLoaded = true;
			bow.enabled = false;
			bowExtend.enabled = true;
			arrow.enabled = false;
			arrow_Extend.enabled = true;
			chargeMetre.value = 1;
			
		}
		else{
			firstPerson.fieldOfView = 60.0f;
			arrowLoaded = false;
			bow.enabled = true;
			bowExtend.enabled = false;
			//arrow.enabled = true;
			arrow_Extend.enabled = false;
			chargeMetre.value = 0;
		}
		
	}
	
}
