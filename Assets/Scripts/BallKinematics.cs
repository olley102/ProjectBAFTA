using UnityEngine;
using System.Collections;

public class BallKinematics : MonoBehaviour {

	public static BallKinematics Kinematics;
    public float v0;    // initial velocity for start and each bounce
    public Rigidbody rb;
	public float bounceHeight; // For the camera to move up.

	void Start () {
        rb = GetComponent<Rigidbody>();
		bounceHeight = 0;
		Kinematics = this;
	}
	
	void Update () {
	    
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Platform") {
            rb.velocity = new Vector3(rb.velocity.x, v0, rb.velocity.z);
			bounceHeight = transform.position.y;
        }
    }
}
