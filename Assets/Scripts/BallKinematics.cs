using UnityEngine;
using System.Collections;

public class BallKinematics : MonoBehaviour {

    public float v0;    // initial velocity for start and each bounce
    public Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
	    
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Platform") {
            rb.velocity = new Vector3(rb.velocity.x, v0, rb.velocity.z);
        }
    }
}
