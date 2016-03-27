using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float velocity;
    private Rigidbody rb;
    public static BallController Script;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Script = this;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (rb.velocity.x >= 5 && moveHorizontal > 0) movement.x = 0f;
        if (rb.velocity.x <= -5 && moveHorizontal < 0) movement.x = 0f;
        if (rb.velocity.z >= 5 && moveVertical > 0) movement.z = 0f;
        if (rb.velocity.z <= -5 && moveVertical < 0) movement.z = 0f;

        rb.AddForce(movement * velocity);
    }
}
