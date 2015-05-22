using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;

public class SuccessfullyPassedLevel : MonoBehaviour {

    public Text moneyText;

	void Start () {
        PlayGamesPlatform.Activate();
        moneyText.text = "Money : " + PlayerPrefs.GetInt("moneyResource").ToString();
        PlayerPrefs.SetInt("maxMoney", PlayerPrefs.GetInt("maxMoney") + 100);
        Social.ReportScore(PlayerPrefs.GetInt("maxMoney"), googlePlayScript.leaderboard, (bool success) =>
        {

        });
	}
	
    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void nextLevel(){
            Application.LoadLevel("PlayingTheGame");
            Time.timeScale = 1;
            PlayingTheGame.currency = Levels.levelsCurrency;
    }

}

