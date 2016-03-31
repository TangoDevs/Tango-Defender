using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

	GameObject tards;
	Transform target;
	public float speed ;
	Vector3[] path;
	int targetIndex;

    void Start()
    {
		tards = GameObject.Find ("Castle");
		target = tards.transform;
        PathRequestManager.RequestPath(transform.position, target.transform.position, OnPathFound);
    }
    void Update()
    {
       
    }
		
    public void OnPathFound(Vector3[] newPath, bool pathSuccessful) {
		if (pathSuccessful) {
			path = newPath;
			StopCoroutine("FollowPath");
			StartCoroutine("FollowPath");
		}
	}

	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];

		while (true) {
           
            if (transform.position == currentWaypoint) {
				targetIndex ++;
                
                if (targetIndex >= path.Length) {
                   
					yield break;
				}
				currentWaypoint = path[targetIndex];

			}
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * Time.deltaTime);

            yield return null;
			}
		}

	void OnTriggerEnter(Collider col){
		
	}
}

