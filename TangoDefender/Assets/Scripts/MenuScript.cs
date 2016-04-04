using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public string Message;
    private const string FACEBOOK_APP_ID = "1752080435026019";
    private const string FACEBOOK_URL = "http://www.facebook.com/dialog/feed";
    private string linkParameter = "https://github.com/TangoDevs/Tango-Defender", 
        nameParameter = "I'm playing Tango Defender!", 
        descriptionParameter = "Hey! I am playing Tango Defender, you should join me! <insert store link>", 
        pictureParameter = "https://avatars1.githubusercontent.com/u/17089785?v=3&s=400", 
        redirectURIParameter = "http://www.facebook.com/.";


    // Use this for initialization
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");

	}

    public void ShareToTwitter()
    {
        Application.OpenURL("https://twitter.com/intent/tweet?text=" + Message + "&amp;lang=eng");
    }

    public void ShareToFacebook()
    {
        Application.OpenURL(FACEBOOK_URL + "?app_id=" + FACEBOOK_APP_ID +
        "&link=" + WWW.EscapeURL(linkParameter) +
        "&name=" + WWW.EscapeURL(nameParameter) +
        "&caption=" + WWW.EscapeURL(descriptionParameter) +
        "&description=" + WWW.EscapeURL(descriptionParameter) +
        "&picture=" + WWW.EscapeURL(pictureParameter) +
        "&redirect_uri=" + WWW.EscapeURL(redirectURIParameter));
    }

    // Update is called once per frame
    public void QuitGame ()
    {
        Application.Quit();
    }
}
