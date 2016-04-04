using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public string Message;
    // Use this for initialization
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        //Debug.Log("play");
	}
    public void ShareToTwitter()
    {
        Application.OpenURL("https://twitter.com/intent/tweet?text=" + Message + "&amp;lang=eng");
    }

    // Update is called once per frame
    public void QuitGame ()
    {
        Application.Quit();
    }
}
