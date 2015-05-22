using UnityEngine;
using System.Collections;

public class CallGameOver : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			Time.timeScale = 0;
            if (Application.loadedLevelName == "PlayingTheGame")
            {
                Debug.Log(Application.loadedLevelName);
                GameOverMenu.calledByScene = "PlayingTheGame";
                PhotonNetwork.Disconnect();
                Application.LoadLevel("GameOverMenu");
            }
            else
            {
                GameOverMenu.calledByScene = "Multiplayer";
                Application.LoadLevel("GameOverMenu");
            }
		}
	}
}
