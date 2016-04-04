using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    GameObject Scores;
    Text text;
    public static int score = 0;

    // Use this for initialization
    void Start () {
        Scores = GameObject.Find("Score");
        text = Scores.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "" + score;
	}

    public static void AddScore()
    {
        score += 100;

    }
}
