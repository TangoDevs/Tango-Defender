using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public Rigidbody thunderBolt;
	// Use this for initialization
	GameObject cam;
	float Distance=1;
	void Start(){
		cam = GameObject.FindWithTag ("MainCamera");
	}

	public void Firing(){

		Rigidbody thunder=Instantiate(thunderBolt, transform.position,transform.rotation) as Rigidbody;
		thunder.velocity=transform.TransformDirection(new Vector3(0,0,1));

	}
}
