using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChoseLevelTest : MonoBehaviour {
    //public GameObject orientationObject;
    //private int inty;
    //private int nextLevel;
    public Button level1Button;
    public Button level2Button;
    private Transform childTransform;
    public Text childText;
    public static bool isLevelChosen = false;
    public Button[] levelButtons;
    private int screenSizeMultiplier = 2;

	void Start () {
        if (Screen.width < 1000)
            screenSizeMultiplier = 1;
        addLevelButtons(22);
        Debug.Log(Screen.width);
        PlayingTheGame.currency = Levels.levelsCurrency;
	}

    void addLevelButtons(int buttonsCount)
    {
        for (int i = 2; i < buttonsCount; i++)
        {
            levelButtons[i] = (Button)Instantiate(levelButtons[i - 1], new Vector3(levelButtons[i - 1].transform.position.x + 194*screenSizeMultiplier, levelButtons[i - 1].transform.position.y, 0), Quaternion.identity);
            levelButtons[i].transform.SetParent(GameObject.Find("LevelsHolder").transform);
            levelButtons[i].name = "Level " + i.ToString();
            childTransform = levelButtons[i].transform.GetChild(0);
            childText = (Text)childTransform.GetComponent("Text");
            levelButtons[i].transform.localScale = levelButtons[1].transform.localScale;
            childText.text = "Level " + i.ToString();
            if (PlayerPrefs.GetInt("lastLevelAvailable") < i)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void backButton()
    {
        Application.LoadLevel("single_or_multi");
    }
}
