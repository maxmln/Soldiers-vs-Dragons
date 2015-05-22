using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateOrJoin : MonoBehaviour {

    public static string stringToEdit;
    public static bool isTryingToJoin = false;
    public static bool isTryingToCreate = false;
    public Text enteredRoomName;
    public Text failedLabel;
    public static string failedLabelText = "";

    void Start()
    {
        failedLabel.text = failedLabelText;
        NetworkManager.currency = 450;
        NetworkManager.currentMultiplayerScore = 0;
    }

    public void joinRoom()
    {
        isTryingToCreate = false;
        stringToEdit = enteredRoomName.text;
        Application.LoadLevel("Multiplayer");
        isTryingToJoin = true;
    }

    public void createRoom()
    {
        isTryingToJoin = false;
        stringToEdit = enteredRoomName.text;
        Application.LoadLevel("Multiplayer");
        isTryingToCreate = true;
    }
    public void backButton()
    {
        Application.LoadLevel("single_or_multi");
    }
}
