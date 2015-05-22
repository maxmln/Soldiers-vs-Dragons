using UnityEngine;
using System.Collections;

public class MeleeAttacking : MonoBehaviour{
    float last = 0;
    public int damage=1;
    public float interval = 0.5f;
    private string target;

    void Start()
    {
        if (gameObject.tag == "Friendly")
            target = "Enemy";
        else
            target = "Friendly";
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == target)
        {
            GetComponent<Animator>().SetTrigger("IsAttacking");
            if (Time.time - last >= interval)
            {
                coll.gameObject.GetComponent<Health>().doDamage(damage);
                last = Time.time;
            }
        }
    }
}