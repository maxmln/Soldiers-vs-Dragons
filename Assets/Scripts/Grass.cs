using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {
	public bool isGrassFilled = false;

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Friendly")
        {
            Debug.Log("plant removed");
            isGrassFilled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Friendly")
        {
            Debug.Log("set to true");
            isGrassFilled = true;
        }
    }

    void OnMouseUpAsButton() {
        if (Application.loadedLevelName == "PlayingTheGame")
        {
             if (PlayingTheGame.currentPlantToBuild != null) {
                if (PlayingTheGame.currency >= PlayingTheGame.currentPlantToBuild.price && !isGrassFilled)
                {
                    Instantiate(PlayingTheGame.currentPlantToBuild.gameObject, transform.position, Quaternion.identity);
                    PlayingTheGame.currency -= PlayingTheGame.currentPlantToBuild.price;
                    PlayingTheGame.currentPlantToBuild = null;
                    isGrassFilled = true;
			    }
             }
        }
        else
        {
            if (NetworkManager.currentPlantToBuild != null && !isGrassFilled)
            {
                    Debug.Log("planted");
                    PhotonNetwork.Instantiate(NetworkManager.currentPlantToBuild.gameObject.name, transform.position, Quaternion.identity, 0);

                    NetworkManager.currency -= NetworkManager.currentPlantToBuild.price;
                    NetworkManager.currentPlantToBuild = null;
                    isGrassFilled = true;
            }
        }   
    }
}