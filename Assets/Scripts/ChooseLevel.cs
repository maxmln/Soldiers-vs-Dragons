using UnityEngine;
using System.Collections;

public class ChooseLevel : MonoBehaviour {

    private GUIStyle gs = null;
    public int fontSize;
    public Font font;
    private MainMenu inst;
    public int levelsCount;
    //private int levelNumber = 1;


	// Use this for initialization
	void Start () {
	
	}

    void levelButtons(int buttonLineY,int firstLevelOfLine,int lastLevelofLine)
    {

        gs = new GUIStyle(GUI.skin.button);
        gs.fontSize = fontSize;
        gs.fontStyle = FontStyle.BoldAndItalic;
        gs.font = font;

        string levelName = "Level ";
        GUILayout.BeginArea(new Rect(0, buttonLineY, Screen.width, Screen.height/5));
        GUILayout.BeginHorizontal("box");
        GUILayout.Width(100);
        GUILayout.Height(100);

        for (int i = firstLevelOfLine; i <= lastLevelofLine; i++)
        {
            //print(i);
            //print(PlayerPrefs.GetInt("lastLevelAvailable"));
            if (PlayerPrefs.GetInt("lastLevelAvailable") >= i)
            {
                GUI.enabled = true;
                if (GUILayout.Button(new GUIContent(levelName + i.ToString()), gs))
                {
                    PlayingTheGame.currentLevel = i;
                    Application.LoadLevel("PlayingTheGame");
                }
            }else
            {
                GUI.enabled = false;
                GUILayout.Button(new GUIContent(levelName + i.ToString()), gs);
            }
            //levelNumber++;

        }

        GUILayout.EndVertical();
        GUILayout.EndArea();
    }

    void OnGUI()
    {
        gs = new GUIStyle(GUI.skin.button);
        gs.fontSize = fontSize;
        gs.fontStyle = FontStyle.BoldAndItalic;
        gs.font = font;
        //string levelName = "Level ";

        GUI.Label(new Rect(Screen.width/4, Screen.height / 100, Screen.width / 2, 50), "Choose a level", gs);

        levelButtons(Screen.height / 7, 1, 4);
        levelButtons(Screen.height / 4 + Screen.height / 35, 5, 8);
        levelButtons(Screen.height / 3 + Screen.height / 14, 9, 12);
        levelButtons(Screen.height / 2 + Screen.height / 28, 13, 15);
        levelButtons(Screen.height / 2 + Screen.height / 6, 16, 18);
        levelButtons(Screen.height / 2 + Screen.height / 4+Screen.height/20, 19, 21);

        //levelNumber = 5;
        //levelButtons(Screen.height / 2+Screen.height/5);
    }
	// Update is called once per frame
	void Update () {
        MainMenu.backButton("single_or_multi");
	}

   
}
