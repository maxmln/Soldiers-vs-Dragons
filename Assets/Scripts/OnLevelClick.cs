using UnityEngine;
using System.Collections;

public class OnLevelClick : MonoBehaviour {

    private int nextLevel;

    public void chosenLevel()
    {
        ChoseLevelTest.isLevelChosen = true;
        nextLevel = int.Parse(this.gameObject.name.Replace("Level ",""));
        PlayingTheGame.currentLevel = nextLevel;
        Debug.Log(PlayingTheGame.currentLevel);
        Debug.Log(this.gameObject.name);
    }

    public void playTheGame()
    {
        if(ChoseLevelTest.isLevelChosen)
            Application.LoadLevel("PlayingTheGame");
    }
}
