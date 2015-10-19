using UnityEngine;
using System.Collections;

public class PPWinUpdate : MonoBehaviour {
    public Manager gameManager;
    public PPEndScreen endScreen;

    private int winAmnt;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void UpdateBalance()
    {
        gameManager.ChangeBalanceBy(endScreen.GetWinAmount());
    }
}
