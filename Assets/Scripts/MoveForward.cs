using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    public float velocity = 15f;
    public Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + velocity * Time.deltaTime);
	}
}
