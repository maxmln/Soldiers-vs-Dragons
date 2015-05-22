using UnityEngine;
using System.Collections;

public class FoodCollect : MonoBehaviour {

    void Update()
    {
        Destroy(gameObject, 3);
    }

    void OnMouseDown() {
        if (Application.loadedLevelName == "PlayingTheGame")
            PlayingTheGame.currency += 50;
        else if (Application.loadedLevelName == "Multiplayer")
            NetworkManager.currency += 50;
        Destroy(gameObject);
    }
}
    //void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.gameObject.tag == "Food")
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("touched another food");
    //    }
    //}