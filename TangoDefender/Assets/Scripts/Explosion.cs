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


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<PlayerHealth>())
        {
            col.gameObject.GetComponent<PlayerHealth>().Decrease();
        }

        if (explosionParticlesPrefab)
        {
            GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
            Destroy(explosion, explosion.GetComponent<ParticleSystem>().startLifetime);
        }

        StartCoroutine(dise());
    }
    IEnumerator dise()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        yield return null;

    }
}
