using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Reflection;
//using System.Object;

public class PlayingTheGame : MonoBehaviour {

    public GameObject grassUnit1;
    public GameObject grassUnit2;
    public Transform finishLine;
    public  BuildInfo[] plants;

    public static BuildInfo currentPlantToBuild;
    public Texture foodTexture;
    public Texture2D foodTexture2D;
    public Level1 level1Inst = null;
    public CanvasGroup pauseMenu;
    private GUIContent foodImgText;
    private bool isPauseButtonPressed = false;

    public static int money = PlayerPrefs.GetInt("moneyResource");
    private GUIStyle guiStyle = null;
    private static int myCurrency;
    public static int currency
    {
        get { return myCurrency; }
        set { myCurrency = value; }
    }    
    private static int myCurrentLevel;
    public static int currentLevel
    {
        get { return myCurrentLevel; }
        set { myCurrentLevel = value; }
    }

	void Start () {
        Time.timeScale = 1;
        addGrass2();
        Instantiate(finishLine, new Vector3(-1 , 2, 0), Quaternion.identity);
        pauseMenu.active = false;
	}
	
	void Update () {

        MainMenu.backButton("ChooseLevel");
	}

    void OnGUI()
    {   
        if (!isPauseButtonPressed)
        {
            if (GUI.Button(new Rect(0, Screen.height / 10, Screen.width / 10, Screen.height / 10), "Pause"))
            {
                pauseButtonPressed();
            }
            buildMenu();
        }
    }

    void addGrass2()
    {
        for (int yPos = 0; yPos < 5; yPos++)
        {
            for (int xPos = 0; xPos < 10; xPos++)
            {
                if (yPos % 2 == 0)
                {
                    Instantiate(grassUnit1, new Vector3(xPos, yPos, 0), transform.rotation);
                }
                else
                {
                    Instantiate(grassUnit2, new Vector3(xPos, yPos, 0), transform.rotation);
                }
            }
        }
    }

    void buildMenu()
    {
        guiStyle = new GUIStyle(GUI.skin.button);
        guiStyle.fontSize = 30;

        GUILayout.BeginArea(new Rect(0, Screen.height / 5, Screen.width / 10 , Screen.height));
        GUILayout.BeginVertical("box");

        foodImgText = new GUIContent(PlayingTheGame.currency.ToString(), foodTexture2D);
        GUILayout.Box(foodImgText, guiStyle);

        foreach (BuildInfo bi in plants)
        {
            isUnitBought(bi, "Campfire", "campfireBought");
            isUnitBought(bi, "RifleMan", "rifleBought");
            isUnitBought(bi, "MiniGunSoldier", "minigunBought");
            isUnitBought(bi, "ShieldCarrier", "shieldBought");
            isUnitBought(bi, "BazookaSoldier", "bazookaBought");
            
       }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }

    void isUnitBought(BuildInfo bi,String name,String playerprefName)
    {
        if (bi.unitName == name && PlayerPrefs.GetInt(playerprefName) == 1)
        {
            GUI.enabled = PlayingTheGame.currency >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage), guiStyle, GUILayout.Height(Screen.height / (plants.Length) / 2)))
                currentPlantToBuild = bi;
        }
    }

    public void continueButtonPressed()
    {
        Time.timeScale = 1;
        pauseMenu.active = false;
        GUI.enabled = true;
        isPauseButtonPressed = false;
    }

    public void changeScene(string nextScene)
    {
        Application.LoadLevel(nextScene);
    }

    public void pauseButtonPressed()
    {
        Time.timeScale = 0;
        pauseMenu.active = true;
        isPauseButtonPressed = true;
    }

    
}
 