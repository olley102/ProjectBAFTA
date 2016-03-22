using UnityEngine;
using System.Collections;

public class GUICamera : MonoBehaviour {
	public float speed;
	public float rot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, (transform.rotation.eulerAngles.y + Time.deltaTime*speed)%360, (transform.rotation.eulerAngles.z + Time.deltaTime*rot)%360);
	}
}
