using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour {

    private int cost;
    private string playerprefName;
    private string stateToChange;

    public Text bazookaCostText;
    public Text minigunCostText;
    public Text shieldCostText;
    public Text currentMoney;

    public Text bazookaButtonText;
    public Text minigunButtonText;
    public Text shieldButtonText;

    void Start()
    {
        updateText();
    }

    public void buyAnItem(string itemName)
    {
        cost = PlayerPrefs.GetInt(itemName + "Cost");
        playerprefName = itemName + "Bought";
        stateToChange = itemName + "State";

        if (PlayerPrefs.GetInt("moneyResource") >= cost)
        {
            if (PlayerPrefs.GetString(stateToChange) == "Buy")
            {
                PlayerPrefs.SetInt("moneyResource", PlayerPrefs.GetInt("moneyResource") - cost);
                PlayerPrefs.SetInt(playerprefName, 1);
                PlayerPrefs.SetString(stateToChange, "Upgrade");
            }
            else
            {
                PlayerPrefs.SetInt("moneyResource", PlayerPrefs.GetInt("moneyResource") - cost);
                PlayerPrefs.SetInt(itemName + "Cost", PlayerPrefs.GetInt(itemName + "Cost") + 100);
                if (itemName == "shield")
                    PlayerPrefs.SetInt("shieldHealth", PlayerPrefs.GetInt("shieldHealth") + 10);
                else
                    PlayerPrefs.SetInt(itemName + "Damage", PlayerPrefs.GetInt(itemName + "Damage") + 10);
            }

        }
        else
        {
            Debug.Log("not enought money");
        }
        updateText();
    }

    private void updateText()
    {
        bazookaCostText.text = "Cost : " + PlayerPrefs.GetInt("bazookaCost").ToString();
        minigunCostText.text = "Cost : " + PlayerPrefs.GetInt("minigunCost").ToString();
        shieldCostText.text = "Cost : " + PlayerPrefs.GetInt("shieldCost").ToString();
        currentMoney.text = "Money : " + PlayerPrefs.GetInt("moneyResource").ToString();

        bazookaButtonText.text = PlayerPrefs.GetString("bazookaState");
        minigunButtonText.text = PlayerPrefs.GetString("minigunState");
        shieldButtonText.text = PlayerPrefs.GetString("shieldState");
    }

    public void backButton()
    {
        Application.LoadLevel("MainMenu");
    }
    public void changeScene()
    {
        Application.LoadLevel("single_or_multi");
    }
    

}
