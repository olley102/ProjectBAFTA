using UnityEngine;
using System.Collections;

public class BallKinematics : MonoBehaviour {

	public static BallKinematics Kinematics;
    public float v0;    // initial velocity for start and each bounce
    public Rigidbody rb;
	public float bounceHeight; // For the camera to move up.
	public float TopbounceHeight; // For the camera to move down.
	public bool CanSwap = true;
	public bool BounceBeforeGravity;

	void Start () {
        rb = GetComponent<Rigidbody>();
		bounceHeight = -256f;
		TopbounceHeight = 256f;
		Kinematics = this;
	}
	
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space)) && (CanSwap == true || BounceBeforeGravity == false)) {
			Physics.gravity = new Vector3 (Physics.gravity.x, 0 - Physics.gravity.y, Physics.gravity.z);
			CanSwap = false;
		}
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "PlatformLower") { // if platform on bottom, go up
            rb.velocity = new Vector3(rb.velocity.x, v0, rb.velocity.z);
			bounceHeight = transform.position.y;
			CanSwap = true;

        }
		if (collision.gameObject.tag == "PlatformUpper") { // if platform on top, go down
			rb.velocity = new Vector3(rb.velocity.x, 0-v0, rb.velocity.z);
			TopbounceHeight = transform.position.y;
			CanSwap = true;
		}
    }
}
