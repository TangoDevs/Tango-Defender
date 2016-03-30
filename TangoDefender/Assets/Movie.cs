using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movie : MonoBehaviour {

     // Use this for initialization
     void Start () {
		if(System.IO.File.Exists("Assets/entry.mp4"))
      		 Debug.LogWarning("File exists");
		else
   			 Debug.LogWarning("File Not found");
		playVideo ();
	}

	void playVideo(){

		if (Handheld.PlayFullScreenMovie ("Assets/entry.mp4", Color.green, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFit)) {

			Debug.Log ("hello");
		};
	}

}

