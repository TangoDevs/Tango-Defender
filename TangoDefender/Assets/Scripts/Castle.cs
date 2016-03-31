using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Other){

		if (Other.gameObject.tag == "Spartan") {
			Destroy (Other.gameObject);
		}
	}
}
