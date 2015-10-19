using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NumberManager : MonoBehaviour {

    public int matchesOne, matchesTwo, matchesThree, matchesFive, matchesTen, matchesTwenty, matchesFifty,
        matchesHun, matchesTwoHun, matchesFiveHun;

    public List<int> selectedNumbers = new List<int>();
    public int totalWin;
	// Use this for initialization
	void Start () {
        matchesOne = 0;
        matchesTwo = 0;
        matchesThree = 0;
        matchesFive = 0;
        matchesTen = 0;
        matchesTwenty = 0;
        matchesFifty = 0;
        matchesHun = 0;
        matchesTwoHun = 0;
        matchesFiveHun = 0;

        totalWin = 0;
	}

    public void CheckForWinners()
    {
        foreach(int number in selectedNumbers)
        {
            switch (number)
            {
                case 1:
                    matchesOne++;
                    break;
                case 2:
                    matchesTwo++;
                    break;
                case 3:
                    matchesThree++;
                    break;
                case 5:
                    matchesFive++;
                    break;
                case 10:
                    matchesTen++;
                    break;
                case 20:
                    matchesTwenty++;
                    break;
                case 50:
                    matchesFifty++;
                    break;
                case 100:
                    matchesHun++;
                    break;
                case 200:
                    matchesTwoHun++;
                    break;
                case 500:
                    matchesFiveHun++;
                    break;
            }

        }
    }
	

    public int GetWinTotal()
    {
        if(matchesOne >= 3)
        {
            totalWin += 1;
        }else if (matchesTwo >= 3)
        {
            totalWin += 2;
        }
        else if (matchesThree >= 3)
        {
            totalWin += 3;
        }
        else if (matchesFive >= 3)
        {
            totalWin += 5;
        }
        else if (matchesTen >= 3)
        {
            totalWin += 10;
        }
        else if (matchesTwenty >= 3)
        {
            totalWin += 20;
        }
        else if (matchesFifty >= 3)
        {
            totalWin += 50;
        }
        else if (matchesHun >= 3)
        {
            totalWin += 100;
        }
        else if (matchesTwoHun >= 3)
        {
            totalWin += 200;
        }
        else if (matchesFiveHun >= 3)
        {
            totalWin += 500;
        }
        return totalWin;
    }

}
