using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Bitrave.Azure;
using UnityEngine.SystemInfo;
using System.Collections.Generic;

public class CastleHealths : MonoBehaviour {
    public float maxHealth = 100f;
    public float currHealth = 0f;

    public GameObject healthBar;

	private AzureMobileServices azure;
	private AzureUILeaderboard ui;

	[SerializeField]
	public string AzureEndPoint = "https://tangodefender.azure-mobile.net/"; // Your Connection URL

	[SerializeField]
	public string ApplicationKey = "AicCvrWpIaNmjrcOgEjzYoRnHvwovT92"; // Your API Key
	List<Leaderboard> _leaderboardItemsui = new List<Leaderboard>();

	GameObject score;



    // Use this for initialization
    void Start()
    {
		
        currHealth = maxHealth;
		azure = new AzureMobileServices (AzureEndPoint, ApplicationKey);
		_leaderboardItemsui=ui.GetAllItems ();
		score=GameObject.Find ("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (currHealth == 0)
        {
            SceneManager.LoadScene("MainScene");
			foreach (var item in  _leaderboardItemsui)
			{
				if (item.Username == SystemInfo.deviceName.ToString ()) {
					if (score > item.Score)
						item.Score = score;
				}
				if (item.Username == null) {
					item.Username = SystemInfo.deviceName;
					item.Score = score;
					_leaderboardItemsui.Add(item);
				}
			}
			azure.Update<Leaderboard>(_leaderboardItemsui);
            Destroy(gameObject);


        }
    }


    public void Decrease()
    {
        currHealth -= 10f;
        float nowHealth = currHealth / maxHealth;
        SetHealthBar(nowHealth);
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
