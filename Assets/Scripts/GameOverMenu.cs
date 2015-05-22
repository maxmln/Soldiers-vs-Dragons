using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverMenu : MonoBehaviour {


    public Text moneyText;
    public static string calledByScene = "";

    void Start()
    {
        PlayingTheGame.currency = Levels.levelsCurrency;
        Debug.Log(calledByScene);
        moneyText.text = "Money : " + PlayerPrefs.GetInt("moneyResource").ToString();
    }
	
    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void tryAgain()
    {
        if (calledByScene == "PlayingTheGame")
        {
            Application.LoadLevel(calledByScene);
            Time.timeScale = 1;
        }
        else
        {
            PhotonNetwork.Disconnect();
            Application.LoadLevel("CreateOrJoin");
        }
    }
}
