using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BalloonTouch : MonoBehaviour {
    public Text matchesTxt;
    public int matches;
    private int maxNum;
    public List<GameObject> splatters = new List<GameObject>();
    public CPNumberGenerator NumGen;
    //public List<int> winningNumbers = new List<int>();
    private int randomIndex;
    private int index;
    public CPGameController controller;
    // Use this for initialization
    void Start () {
        randomIndex = 0;
        maxNum = 20;
        matches = 0;
	}
	
	// Update is called once per frame
	void Update () {
        matchesTxt.text = matches.ToString();

	}

    public void SelectBalloon(int balloonNumber)
    {
        controller.balloonsRemaining--;
        randomIndex = Random.Range(1, maxNum);
        for(int i = 0; i < 5; i++)
        {
            if(NumGen.houseSelectedNumbers[i] == randomIndex)
            {
                index = i;
            }
        }
        switch (NumGen.houseSelectedNumbers.Contains(randomIndex))
        {
            case true:
                GameObject.Find("spot" + balloonNumber.ToString()).GetComponent<Text>().color = Color.green;
                NumGen.houseNumbers[index].color = Color.green;
                matches++;
                break;
            case false:
                GameObject.Find("spot" + balloonNumber.ToString()).GetComponent<Text>().color = Color.white;
                break;
        }
        GameObject.Find("spot" + balloonNumber.ToString()).GetComponent<Text>().text = randomIndex.ToString();
        GameObject.Find("Balloon" + balloonNumber.ToString()).SetActive(false);
        splatters[balloonNumber - 1].SetActive(true);
    }


}
