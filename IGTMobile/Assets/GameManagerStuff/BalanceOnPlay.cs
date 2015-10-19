using UnityEngine;
using System.Collections;

public class BalanceOnPlay : MonoBehaviour {
    //private GameObject gameManager;
    public GameObject managerObj;
    private Manager gameManager;
	// Use this for initialization
	void Start () {
        gameManager = managerObj.GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void SubtractFromBalance(int amnt)
    {
        gameManager.ChangeBalanceBy(amnt);
    }
}
