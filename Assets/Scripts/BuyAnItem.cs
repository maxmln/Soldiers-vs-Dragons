using UnityEngine;
using System.Collections;

public class BuyAnItem : MonoBehaviour {

    public void buyAnItem(int cost, string itemName, string playerprefName, string stateToChange)
    {
        if (PlayerPrefs.GetInt("moneyResource") >= cost)
        {
            PlayingTheGame.money -= cost;
            PlayerPrefs.SetInt("moneyResource", PlayingTheGame.money);
            PlayerPrefs.SetInt(playerprefName, 1);
            print("you bought a " + itemName);

            print(PlayerPrefs.GetInt("moneyResource"));
            print(PlayingTheGame.money);
            PlayerPrefs.SetString(stateToChange, "Upgrade");

        }
        else
        {
            print("you don't have enought money for a " + itemName);
            print(PlayerPrefs.GetInt("moneyResource"));
            print(PlayingTheGame.money);
        }
    }

    public void upgradeItem(int cost,string Costt)
    {

    }
}
