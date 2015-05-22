using UnityEngine;
using System.Collections;

public class facebookIntegration : MonoBehaviour {

    void Awake()
    {
        FB.Init(onIninitCallback, onHideUnityCallback);
    }
	
    private void onIninitCallback()
    {
        Debug.Log("init done");
        if (FB.IsLoggedIn)
        {
            Debug.Log("FB Logged In");
        }
        else
        {
            Debug.Log("not logged in");
        }
    }

    private void onHideUnityCallback(bool isGameShown)
    {

    }

    public void shareButtonClicked()
    {
        if (FB.IsLoggedIn)
        {    
            FB.Feed(
                        linkCaption: "I reached Level " + PlayerPrefs.GetInt("lastLevelAvailable") + " and have " + PlayerPrefs.GetInt("moneyResource") + " money",
                        picture: "",
                        linkName: "Soldiers vs Dragons",
                        link: "http://apps.facebook.com/" + FB.AppId + "/?challange_brag=" + (FB.IsLoggedIn ? FB.UserId : "guest")
                        //link: "http://iwanttogetfit.site90.net/"
                       );
        }
        else
        {
            FB.Login("email", authCallback);
        }
    }

    private static void authCallback(FBResult result)
    {
        if (FB.IsLoggedIn)
        {
            FB.Feed(
                 linkCaption: "I reached Level " + PlayerPrefs.GetInt("lastLevelAvailable") + " and have " + PlayerPrefs.GetInt("moneyResource") + " money",
                 picture: "",
                 linkName: "Soldiers vs Dragons",
                 link: "http://apps.facebook.com/" + FB.AppId + "/?challange_brag=" + (FB.IsLoggedIn ? FB.UserId : "guest")
                //link: "http://iwanttogetfit.site90.net/"
            );
        }
        else
        {
            Debug.Log("fb login failed");
        }
    }

}




//Application.OpenURL("http://www.facebook.com/dialog/feed?app_id=806585152757362&display=popup&redirect_uri=http://www.facebook.com&picture=http://i.imgur.com/4wH3hVs.png&caption=Soldiers vs Dragons&name=Who is better ?&description=I've got : "+ PlayerPrefs.GetInt("moneyResource")+" money "+" and I've reached level : "+PlayerPrefs.GetInt("lastLevelAvailable"));
