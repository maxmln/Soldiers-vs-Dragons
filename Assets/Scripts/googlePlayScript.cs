using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.UI;

public class googlePlayScript : MonoBehaviour {

    public Button signinButton;
    public Button signoutButton;
    private bool hasUserLoggedIn = false;
    public static string leaderboard = "CgkIkJibjLwWEAIQBg";

    void Awake()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                signinButton.active = false;
                signoutButton.active = true;
                hasUserLoggedIn = true;
            }
            else
            {
                signinButton.active = true;
                signoutButton.active = false;
            }
        });

        Social.ReportScore(PlayerPrefs.GetInt("maxMoney"), leaderboard, (bool success) =>
        {

        });
    }

    void Update()
    {
        if (hasUserLoggedIn)
        {
            signinButton.active = false;
            signoutButton.active = true;
        }
        else
        {
            signinButton.active = true;
            signoutButton.active = false;
        }
    }

    public void callLogin()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            hasUserLoggedIn = true;
        });
    }

    public void showLeaderboard()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI(leaderboard);
    }

    public void callLogout()
    {
        PlayGamesPlatform.Instance.SignOut();
        hasUserLoggedIn = false;
    }

}
