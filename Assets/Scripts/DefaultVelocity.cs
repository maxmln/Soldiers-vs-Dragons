using UnityEngine;
using System.Collections;

public class DefaultVelocity : MonoBehaviour {
    public Vector2 velocity;

	void Update(){
		if(gameObject.transform.position.y>=8 && gameObject.tag != "Enemy"){
			Destroy(gameObject);
		}
	}

    void FixedUpdate () {
        rigidbody2D.velocity = velocity;
    }
}
