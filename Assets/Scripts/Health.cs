using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public int cur = 5;
    private Vector3 moveOutOfField= new Vector3(-1000,0,0);

    void Start()
    {
        if (this.name == "ShieldCarrier(Clone)")
        {
            cur = PlayerPrefs.GetInt("shieldHealth");
            Debug.Log(PlayerPrefs.GetInt("shieldHealth"));
        }
    }

    public void doDamage(int damageAmount) {
        // Subtract damage from current health
        cur -= damageAmount;

        // Destroy if died
        if (cur <= 0)
        {
            if (gameObject.tag == "Friendly")
            {
                gameObject.transform.position = moveOutOfField;
            }
            else
            {
                if (Application.loadedLevelName == "Multiplayer")
                    NetworkManager.currentMultiplayerScore += 10;
                 Destroy(gameObject);
            }
        }
    }
}