using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CPGameController : MonoBehaviour {

    public int balloonsRemaining;
    public GameObject Game;
    public float delayAtEndOfGame;
    public BalloonTouch balloonPopScript;
    public GameObject endScreen;
    public Text matches;
	// Use this for initialization
	void Start () {
        balloonsRemaining = 5;
	}
	
	// Update is called once per frame
	void Update () {
	    if(balloonsRemaining<=0)
        {
            StartCoroutine(EndGame(delayAtEndOfGame));
        }
	}

    IEnumerator EndGame(float secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
        Game.SetActive(false);
        endScreen.SetActive(true);
        matches.text = "Matches: " + balloonPopScript.matches.ToString();
        yield return 0;
    }
    public void Menu(bool toMenu)
    {
        switch(toMenu)
        {
            case true:
                Application.LoadLevel(0);
                break;
            case false:
                Application.LoadLevel(1);
                break;
        }
    }
}
