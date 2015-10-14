using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CPNumberGenerator : MonoBehaviour {

    public List<Text> houseNumbers = new List<Text>();
    public List<int> houseSelectedNumbers = new List<int>();

	// Use this for initialization
	void Start () {
	    foreach(Text numberTxt in houseNumbers)
        {
            int newRandom = Random.Range(1, 20);
            numberTxt.text = newRandom.ToString();
            houseSelectedNumbers.Add(newRandom);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
