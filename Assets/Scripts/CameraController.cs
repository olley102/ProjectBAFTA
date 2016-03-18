using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    private Transform player;
    private Vector3 relCameraPos;
    private float newY; // The Y that the camera will lerping to
	private float t; // Keeps track of time for lerp 
	public float followSpeed; // Speed of the camera's lerp on Y

    void Awake() {
        player = GameObject.Find("BlueBall").transform;
        relCameraPos = transform.position - player.position;
		newY = player.position.y + relCameraPos.y;
		t = 0;

    }

    void FixedUpdate() {

		if (BallKinematics.Kinematics.bounceHeight + relCameraPos.y > newY) { // If the ball bounces higher than expected, indicating that it has moved up:
			newY = BallKinematics.Kinematics.bounceHeight + relCameraPos.y;
			BallKinematics.Kinematics.bounceHeight = -1024;
			t = 0;
		}

		if ((transform.position.y - player.position.y > relCameraPos.y) && (player.position.y + relCameraPos.y < newY )) { // If it goes above the top of the bounce
			newY = player.position.y + relCameraPos.y;
			t = 0;
		} 

		//if ((transform.position.y - player.position.y < -2.5 + relCameraPos.y) && (player.position.y + relCameraPos.y - 2.5f > newY )) { // If it goes Below the bottom of the bounce
		//	newY = player.position.y + relCameraPos.y - 2.5f;
		//	t = 0;
		//}
		// OLD

		t = t + Time.deltaTime * followSpeed;
		transform.position = new Vector3(player.position.x + relCameraPos.x, Mathf.Lerp(transform.position.y, newY, t), player.position.z + relCameraPos.z);
    }
}
