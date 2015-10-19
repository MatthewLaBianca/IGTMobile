using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    public static Manager instance = null;
    private int balance = 130;
    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int GetBalance()
    {
        return balance;
    }
    public void ChangeBalanceBy(int amnt)
    {
        balance += amnt;
    }
    public void ResetBalance()
    {
        balance = 130;
    }
}
