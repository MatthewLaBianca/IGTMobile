using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CPEndScreen : MonoBehaviour {

    public BalloonTouch matchesScript;
    private int matches;
    private int winAmnt;
    public Text winTxt;
    public Manager gameManager;

	// Use this for initialization
	void Start () {
        matches = matchesScript.matches;

    }

    // Update is called once per frame
    void Update () {
        SetWinAmount(matches);
        winTxt.text = "$" + winAmnt.ToString();
	}

    void SetWinAmount(int amntMatched)
    {
        switch (amntMatched)
        {
            case 0:
                winAmnt = 0;
                break;
            case 1:
                winAmnt = 0;
                break;
            case 2:
                winAmnt = 1;
                break;
            case 3:
                winAmnt = 10;
                break;
            case 4:
                winAmnt = 100;
                break;
            case 5:
                winAmnt = 500;
                break;
        }
    }

    public int GetWinAmount()
    {
        
        return winAmnt;
    }
}
