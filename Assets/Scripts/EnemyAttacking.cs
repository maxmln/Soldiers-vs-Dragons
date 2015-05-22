using UnityEngine;
using System.Collections;

public class EnemyAttacking : MonoBehaviour {
    // Last Attack Time
    float last = 0;
    public int damage;
    public float interval = 0.5f;

    void OnCollisionStay2D(Collision2D coll) {
        // Collided with a Plant?
        if (coll.gameObject.tag == "Friendly") {
            // Play Attack Animation
            GetComponent<Animator>().SetTrigger("IsAttacking");
            // Deal damage once a second
            if (Time.time - last >= interval) {
                coll.gameObject.GetComponent<Health>().doDamage(damage);
                last = Time.time;
            }
        }
    }
}
