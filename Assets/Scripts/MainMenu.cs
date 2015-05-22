using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Start () {
        PlayerPrefs.GetInt("moneyResource",0);
        PlayerPrefs.GetInt("maxMultiplayerScore", 0);
        if (PlayerPrefs.GetInt("lastLevelAvailable") == 0)
        {
            PlayerPrefs.SetInt("lastLevelAvailable", 1);
        }
        print(PlayerPrefs.GetInt("lastLevelAvailable"));
        PlayerPrefs.GetInt("bazookaBought", 0);
        PlayerPrefs.GetInt("minigunBought", 0);
        PlayerPrefs.SetInt("campfireBought", 1);
        PlayerPrefs.GetInt("shieldBought", 0);
        PlayerPrefs.SetInt("rifleBought", 1);
        PlayerPrefs.GetInt("maxMoney", 0);

        initWeapon("bazooka", 200, 30);
        initWeapon("minigun", 150, 10);
        initWeapon("shield",50,25);

        Debug.Log(PlayerPrefs.GetInt("shieldCost"));

       // PlayerPrefs.DeleteAll();
	}

    private void initWeapon(string weaponName, int weaponCost, int weaponDamage)
    {
        if (PlayerPrefs.GetString(weaponName + "State") != "Upgrade")
        {
            PlayerPrefs.SetString(weaponName + "State", "Buy");
            PlayerPrefs.SetInt(weaponName + "Cost", weaponCost);
            if (weaponName == "shield")
                PlayerPrefs.SetInt(weaponName + "Health", weaponDamage);
            else
                PlayerPrefs.SetInt(weaponName + "Damage", weaponDamage);
        }
    }

    public static void backButton(string pastScene)
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(pastScene);
        }
    }

    public void changeScene(string nextScene)
    {
        Application.LoadLevel(nextScene);
    }

    public void exitApp()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
















        //if(PlayerPrefs.GetString("bazookaState")!="Upgrade"){
        //    PlayerPrefs.SetString("bazookaState", "Buy");
        //    PlayerPrefs.SetInt("bazookaCost",200);
        //    PlayerPrefs.SetInt("bazookaDamage", 30);
        //}

        //if(PlayerPrefs.GetString("shieldState")!="Upgrade"){
        //    PlayerPrefs.SetString("shieldState", "Buy");
        //    PlayerPrefs.SetInt("shieldCost", 50);
        //    PlayerPrefs.SetInt("shieldHealth", 25);
        //    Debug.Log(PlayerPrefs.GetInt("shieldHealth"));
        //}

        //if (PlayerPrefs.GetString("minigunState") != "Upgrade")
        //{
        //    PlayerPrefs.SetString("minigunState", "Buy");
        //    PlayerPrefs.SetInt("minigunCost", 150);
        //    PlayerPrefs.SetInt("minigunDamage", 10);
        //}