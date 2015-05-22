using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    public BuildInfo[] plants;
    private GUIStyle guiStyle = null;
    public static BuildInfo currentPlantToBuild;
    public static int currency = 450;
    public GameObject[] enemies;

    private bool joinedRoom = false;
    public CanvasGroup pauseMenu;
    public static bool grassAdded = false;
    private bool isPauseButtonPressed = false;
    public Text waitingForPlayers;
    private static bool hasGameStarted = false;

    public static int currentMultiplayerScore;

	void Start () {
        hasGameStarted = false;
        Time.timeScale = 1;
        pauseMenu.active = false;
        PhotonNetwork.ConnectUsingSettings("MultiFPS v001");
	}
	
	void Update () {
        if (PhotonNetwork.playerList.Length > 1)
        {
            hasGameStarted = true;
        }
        MainMenu.backButton("CreateOrJoin");
        if (PlayerPrefs.GetInt("maxMultiplayerScore") < currentMultiplayerScore)
            PlayerPrefs.SetInt("maxMultiplayerScore", currentMultiplayerScore);
        if (PhotonNetwork.playerList.Length > 1)
        {
            waitingForPlayers.text = "";
        }
        if (hasGameStarted && PhotonNetwork.playerList.Length < 2)
        {
            Debug.Log("should close");
            Disconnect("CreateOrJoin");
        }
	}

    void Disconnect(string sceneToLoad)
    {
        PhotonNetwork.DestroyAll();
        PhotonNetwork.Disconnect();
        Debug.Log(sceneToLoad);
        Application.LoadLevel(sceneToLoad);
    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
        GUILayout.Label(new GUIContent(currentMultiplayerScore.ToString()));
        if(!isPauseButtonPressed){
           
            if (joinedRoom)
            {
                if (GUI.Button(new Rect(0, Screen.height / 10, Screen.width / 10, Screen.height / 10), "Pause"))
                {
                    pauseButtonPressed();
                }
                buildMenu();
            }
        }
    }

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings("MultiFPS v001");
    }

    void OnJoinedLobby()
    {
        if (CreateOrJoin.stringToEdit == "" && CreateOrJoin.isTryingToJoin)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else if (CreateOrJoin.stringToEdit != "" && CreateOrJoin.isTryingToJoin)
        {
            PhotonNetwork.JoinRoom(CreateOrJoin.stringToEdit);
        }
        else if(CreateOrJoin.isTryingToCreate){
            PhotonNetwork.CreateRoom(CreateOrJoin.stringToEdit,true,true,2);
            PhotonNetwork.maxConnections = 2;
        }
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(CreateOrJoin.stringToEdit);
    }
    void OnPhotonJoinRoomFailed()
    {
        PhotonNetwork.Disconnect();
        Debug.Log("failed");
        Application.LoadLevel("CreateOrJoin");
        CreateOrJoin.failedLabelText = "Room not found. \n Try again.";
    }
    void OnJoinedRoom()
    {
        joinedRoom = true;
        Debug.Log(PhotonNetwork.playerList.Length);
        if (PhotonNetwork.playerList.Length > 1)
        {
            PhotonNetwork.Instantiate("finishLine", new Vector3(-1, 2, 0), Quaternion.identity, 0);
            addGrass();
            InvokeRepeating("spawnRandomEnemy", 10, 5);
            InvokeRepeating("spawnRandomEnemy", 12, 6);
            hasGameStarted = true;
        }
    }

    void spawnRandomEnemy()
    {
        int randomEnemyNumber = Random.Range(0,3);
        int randomEnemyY = Random.Range(0,7);

        PhotonNetwork.Instantiate(enemies[randomEnemyNumber].name, new Vector3(11, randomEnemyY, 0), Quaternion.identity, 0);
    }

    void addGrass()
    {
        int lastX = 0;
        int lastY = 0;
        bool isLightNext = true;
        while (lastY < 8)
        {
            lastX = 0;
            isLightNext = !isLightNext;
            while (lastX < 10)
            {
                if (isLightNext)
                {
                    PhotonNetwork.Instantiate("grass1", new Vector3(lastX, lastY, 0), transform.rotation,0);
                    isLightNext = !isLightNext;
                }
                else
                {
                    PhotonNetwork.Instantiate("grass2", new Vector3(lastX, lastY, 0), transform.rotation,0);
                    isLightNext = !isLightNext;
                }
                lastX += 1;
            }
            lastY += 1;
        }
        grassAdded = true;
    }
    void buildMenu()
    {
        guiStyle = new GUIStyle(GUI.skin.button);
        guiStyle.fontSize = 20;
        GUILayout.BeginArea(new Rect(0, Screen.height / 5, Screen.width / 10, Screen.height));
        GUILayout.BeginVertical("box");

        GUILayout.Width(100);
        GUILayout.Height(300);
        GUILayout.Box(new GUIContent(NetworkManager.currency.ToString()), guiStyle);

        foreach (BuildInfo bi in plants)
        {
            isUnitBought(bi, "Campfire", "campfireBought");
            isUnitBought(bi, "RifleMan", "rifleBought");
            isUnitBought(bi, "MiniGunSoldier", "minigunBought");
            isUnitBought(bi, "ShieldCarrier", "shieldBought");
            isUnitBought(bi, "BazookaSoldier", "bazookaBought");
        }

        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
    void isUnitBought(BuildInfo bi, string name, string playerprefName)
    {
        if (bi.unitName == name  && PlayerPrefs.GetInt(playerprefName ) == 1)
        {
            GUI.enabled = currency >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage), guiStyle, GUILayout.Height(Screen.height / (plants.Length) / 2)))
                currentPlantToBuild = bi;
        }
    }

    public void quitButtonPressed()
    {
        Time.timeScale = 1;
        Disconnect("CreateOrJoin");
    }
    public void continueButtonPressed()
    {
        Time.timeScale = 1;
        pauseMenu.active = false;
        GUI.enabled = true;
        isPauseButtonPressed = false;
    }
    public void pauseButtonPressed()
    {   
        //Time.timeScale = 0;
        pauseMenu.active = true;
        Debug.Log("paused");
        GUI.enabled = false;
        isPauseButtonPressed = true;
    }
    public void shopButtonPressed()
    {
        Time.timeScale = 1;
        Disconnect("ShopMenu");
    }
}
