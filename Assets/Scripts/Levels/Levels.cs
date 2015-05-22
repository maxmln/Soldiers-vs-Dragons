using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Levels : MonoBehaviour {

    public static int levelsCurrency = 400;

    protected void goToNextLevel()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {

            PlayingTheGame.currentLevel += 1;
            if(PlayingTheGame.currentLevel>PlayerPrefs.GetInt("lastLevelAvailable")){
                PlayerPrefs.SetInt("lastLevelAvailable", PlayerPrefs.GetInt("lastLevelAvailable")+1);
            }
            //PlayingTheGame.lastLevelAvailable = 2;
            PlayingTheGame.money += 100;
            PlayerPrefs.SetInt("moneyResource", PlayingTheGame.money);
            Application.LoadLevel("SuccessfullyPassedLevel");
            PlayingTheGame.currency = levelsCurrency;
        }
    }

    protected void addEnemy(GameObject enemyToAdd, int xPos,int yPos=5)
    {
        if (yPos == 5)
            yPos = Random.Range(0, 5);
        Instantiate(enemyToAdd, new Vector3(xPos, yPos, 0), Quaternion.identity);
    }

}
