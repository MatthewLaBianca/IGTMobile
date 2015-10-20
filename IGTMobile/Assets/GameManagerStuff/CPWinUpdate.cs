using UnityEngine;
using System.Collections;

public class CPWinUpdate : MonoBehaviour {

    public Manager gameManager;
    public CPEndScreen endScreen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateBalance()
    {
        gameManager.ChangeBalanceBy(endScreen.GetWinAmount());
        Debug.Log("Added " + endScreen.GetWinAmount());
    }
}
