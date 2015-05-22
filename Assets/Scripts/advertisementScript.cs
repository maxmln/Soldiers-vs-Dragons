using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class advertisementScript : MonoBehaviour {
    public Button adsButton;

    void Awake()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.allowPrecache = true;
            Advertisement.Initialize("131624086",false);
            adsButton.interactable = true; 
        }
        else
        {
            Debug.Log("Platform not supported");
           // adsButton.interactable = false;
        }

    }

    public void watchAdd()
    {
        Debug.Log("in func");
        if (Advertisement.isReady())
        {
            Debug.Log(Advertisement.isReady());
            Advertisement.Show(null, new ShowOptions
            {
                pause = true,
                resultCallback = result =>
                {
                    Debug.Log(result.ToString());
                    PlayerPrefs.SetInt("moneyResource", PlayerPrefs.GetInt("moneyResource") + 25);
                }
            });
        }
    }

    //void Update()
    //{
    //    if (!Advertisement.isReady())
    //    {
    //        adsButton.interactable = false;
    //    }
    //    else
    //    {
    //        adsButton.interactable = true;
    //    }
    //}
}
