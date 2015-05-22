using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class singleOrMulti : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame

    public void changeScene(string nextScene)
    {
        Application.LoadLevel(nextScene);
    }
}
