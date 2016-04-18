using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour {

	public GameObject healthBar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Other){

		if (Other.gameObject.tag == "Spartan") {
			healthBar.GetComponent<CastleHealths>().Decrease ();
			Destroy (Other.gameObject);

		}
	}
}
