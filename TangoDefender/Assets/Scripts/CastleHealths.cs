using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CastleHealths : MonoBehaviour {
    public float maxHealth = 100f;
    public float currHealth = 0f;

    public GameObject healthBar;


    // Use this for initialization
    void Start()
    {
        currHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {
        if (currHealth == 0)
        {
            SceneManager.LoadScene("MainScene");
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
