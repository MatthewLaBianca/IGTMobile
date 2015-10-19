using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PizzaTouch : MonoBehaviour {

    public NumberManager numMan;
    public int pizzasRemaining;
    public string LookingFor;
    public List<int> winningNumbers = new List<int>();
    private int randomIndex;
    public GameObject game;
    public GameObject endscreen;
	// Use this for initialization
	void Start () {
        randomIndex = 0;
        LookingFor = "";
        pizzasRemaining = 6;
	}
	
	// Update is called once per frame
	void Update () {
	    if(pizzasRemaining<=0)
        {
            StartCoroutine(EndGame(2.0f));
        }
	}
    IEnumerator EndGame(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        game.SetActive(false);
        endscreen.SetActive(true);
        yield return 0;
    }
    public void SelectPizza(int pizzaNumber)
    {
        randomIndex = Random.Range(0, winningNumbers.Capacity);
        pizzasRemaining--;
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
        //numMan.CheckForWinners();
    }


}
