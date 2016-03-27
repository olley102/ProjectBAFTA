using UnityEngine;
using System.Collections;

public class BreakOff : MonoBehaviour {

    public Rigidbody rb;
    public GameObject plane;
	
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void OnCollisionEnter (Collision collision) {
        if (collision.gameObject == plane) {
            print("HIT");
            Destroy(gameObject, 0f);
        }
	}
}
