using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
    public GameObject bulletPrefab;
    private Vector3 bulletPosition;
    public float interval = 0.5f;

    void Start () {
        InvokeRepeating("Shoot", 0, interval);
    }

    bool zombieInFront() {
        Vector2 origin = new Vector2(9.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);
        foreach (RaycastHit2D hit in hits) {
            if (hit.collider != null &&
                hit.collider.gameObject.tag == "Enemy")
                return true;
        }
        return false;
    }

    void Shoot() {
        if (zombieInFront()) {
            GetComponent<Animator>().SetTrigger("IsFiring");
            bulletPosition.x = transform.position.x + 1 ;
            bulletPosition.y = transform.position.y ;
            bulletPosition.z = 0;

            Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        }
    }
}