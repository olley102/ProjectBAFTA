using UnityEngine;
using System.Collections;

public class FlipLightOnGravity : MonoBehaviour {

    public float eulerX = 50f;
    public float eulerY = -30f;
    public float eulerZ = 0f;
	public float lerpspeed;

	private float t = 0f;
	private Quaternion newrot;

	// Use this for initialization
	void Start () {
        transform.rotation = Quaternion.Euler(eulerX, eulerY, eulerZ);
	}

	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.Space))) {
            newrot = Quaternion.Euler(eulerX * -1, eulerY * -1, eulerZ);
            eulerX *= -1;
            eulerY *= -1;
			t = 0;
        }
		if (t < 1) {
			t = t + Time.deltaTime * lerpspeed;
		} else {
			t = 1;
		}
		transform.rotation = Quaternion.LerpUnclamped (transform.rotation, newrot, t);
    }
}
