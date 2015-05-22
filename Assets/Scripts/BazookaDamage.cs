using UnityEngine;
using System.Collections;

public class BazookaDamage : MonoBehaviour
{

    private int bulletDamage;

    void Start()
    {
        bulletDamage = PlayerPrefs.GetInt("bazookaDamage");
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
