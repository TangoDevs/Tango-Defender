using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				float spawnx=Random.Range (-1, 1);
				if (spawnx < 0) {
					spawnValues.x = -0.4272f;
					spawnValues.z =	-0.5043f;
				} else {
					spawnValues.x = 0.4249f;
					spawnValues.z =	-0.4651f;
				}
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
