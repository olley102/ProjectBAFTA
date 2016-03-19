using UnityEngine;
using System.Collections;

public class FlipLightOnGravity : MonoBehaviour {

    public float eulerX = 50f;
    public float eulerY = -30f;
    public float eulerZ = 0f;

	// Use this for initialization
	void Start () {
        transform.rotation = Quaternion.Euler(eulerX, eulerY, eulerZ);
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.Space))) {
            transform.rotation = Quaternion.Euler(eulerX * -1, eulerY * -1, eulerZ);
            eulerX *= -1;
            eulerY *= -1;
        }
    }
}
