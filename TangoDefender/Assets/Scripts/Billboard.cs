using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{
    GameObject cameran;

    void Start()
    {
        cameran = GameObject.FindWithTag("MainCamera");
    }

	// Update is called once per frame
	void Update () {
        transform.LookAt(transform.position + cameran.transform.rotation * Vector3.back,
                                                 cameran.transform.rotation * Vector3.up);
        
	}
}
