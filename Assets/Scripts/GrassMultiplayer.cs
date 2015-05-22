using UnityEngine;
using System.Collections;

public class GrassMultiplayer : MonoBehaviour {

    public bool isGrassEmpty = false;

    void Start()
    {
        PhotonNetwork.sendRate = 20;
        PhotonNetwork.sendRateOnSerialize = 10;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Friendly")
        {
            isGrassEmpty = false;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Friendly")
        {
            Debug.Log("set to true");
            isGrassEmpty = true;
        }
    }

    void OnMouseUpAsButton()
    {
        if (NetworkManager.currentPlantToBuild != null)
        {
            if (!isGrassEmpty)
            {
                Debug.Log("planted");
                PhotonNetwork.Instantiate(NetworkManager.currentPlantToBuild.gameObject.name, transform.position, Quaternion.identity,0);
                //Instantiate(NetworkManager.currentPlantToBuild,transform.position,Quaternion.identity);

                NetworkManager.currency -= NetworkManager.currentPlantToBuild.price;
                NetworkManager.currentPlantToBuild = null;
                isGrassEmpty = true;
            }
        }
    }

    void OnPhotonSerializeView(PhotonStream stream,PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(isGrassEmpty);
        }
        if (stream.isReading)
        {
            isGrassEmpty = (bool)stream.ReceiveNext();
        }
    }
}
