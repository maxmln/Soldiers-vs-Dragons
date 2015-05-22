using UnityEngine;
using System.Collections;

public class ChooseLevelClass : MonoBehaviour {

    public Levels myCurrentLevel;
    private string currentLevelString;

	void Start () {
            currentLevelString = "Level" + PlayingTheGame.currentLevel.ToString();
            myCurrentLevel = GetComponent(currentLevelString) as Levels;
            myCurrentLevel.enabled = true;
	}
}
