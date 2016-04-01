using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public GameObject explosionParticlesPrefab;

	// Use this for initialization
	void Start() {
		float randomX = UnityEngine.Random.Range (0f, 1f);
		float randomY = UnityEngine.Random.Range (0f, 1f);
		float randomZ = UnityEngine.Random.Range (0f, 1f);

		Rigidbody bomb = GetComponent<Rigidbody> ();
		bomb.AddTorque (randomX, randomY, randomZ);  
	}

	// Update is called once per frame
	void Update() {

	}


	public void OnCollisionEnter(Collision collision) {
		
		if (explosionParticlesPrefab)
		{
			GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
			Destroy(explosion, explosion.GetComponent<ParticleSystem>().startLifetime);
		}
		if (collision.gameObject.GetComponentInChildren<PlayerHealth> ()) {
			collision.gameObject.GetComponentInChildren<PlayerHealth>().Decrease();
		}
		Destroy(gameObject);
	}
}
