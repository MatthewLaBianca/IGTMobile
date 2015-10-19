using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PPEndScreen : MonoBehaviour {
    public Text winAmnt;
    public Text endTitle;
    public NumberManager numMan;
    private int winAmountInt;
	// Use this for initialization
	void Start () {
        numMan.CheckForWinners();
        winAmountInt = numMan.GetWinTotal();
	}
	
	// Update is called once per frame
	void Update () {
        if (winAmountInt > 0)
        {
            endTitle.text = "YOU WON!";
            winAmnt.text = "$" + winAmountInt.ToString();
        }else
        {
            endTitle.text = "Sorry, Try Again";
            winAmnt.text = "";
        }
    }
}
