using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour
{
    private int bulletDamage;

    void Start()
    {
        if (Application.loadedLevelName=="Multiplayer")
        {
            if (gameObject.name == "RifleBullet(Clone)")
                bulletDamage = 10;
            else
                bulletDamage = 30;
        }
        else
        {
            if (gameObject.name == "RifleBullet(Clone)")
                bulletDamage = PlayerPrefs.GetInt("minigunDamage");
            else
                bulletDamage = PlayerPrefs.GetInt("bazookaDamage");
        }
    }

    void Update()
    {
        if (gameObject.transform.position.x >= 10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Enemy")
        {
            co.GetComponent<Health>().doDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}
