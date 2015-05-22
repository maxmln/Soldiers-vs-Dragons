using UnityEngine;
using System.Collections;

public class BuildInfo_Bazooka :  BuildInfo {
    
      
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    isItemBought = PlayerPrefs.GetInt("isBazookaBought");
	}
}
