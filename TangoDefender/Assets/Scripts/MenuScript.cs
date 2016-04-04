using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    // Use this for initialization
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        //Debug.Log("play");
	}
	
	// Update is called once per frame
	public void QuitGame ()
    {
        Application.Quit();
    }
}
