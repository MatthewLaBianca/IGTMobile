using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PizzaTouch : MonoBehaviour {

    public NumberManager numMan;
    public string LookingFor;
    public List<int> winningNumbers = new List<int>();
    private int randomIndex;
	// Use this for initialization
	void Start () {
        randomIndex = 0;
        LookingFor = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SelectPizza(int pizzaNumber)
    {
        randomIndex = Random.Range(0, winningNumbers.Capacity);
        if (numMan.selectedNumbers.Contains(winningNumbers[randomIndex]))
        {
            GameObject.Find("spot" + pizzaNumber.ToString()).GetComponent<Text>().color = Color.green;
        }
        else
        {
            GameObject.Find("spot" + pizzaNumber.ToString()).GetComponent<Text>().color = Color.white;
        }

        GameObject.Find("spot" + pizzaNumber.ToString()).GetComponent<Text>().text = "$" + winningNumbers[randomIndex].ToString();
        GameObject.Find("pizza" + pizzaNumber.ToString()).SetActive(false);
        numMan.selectedNumbers.Add(winningNumbers[randomIndex]);
        numMan.CheckForWinners();
    }


}
