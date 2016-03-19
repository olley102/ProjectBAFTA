using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    private Transform player;
    private Vector3 relCameraPos;
    private float newY; // The Y that the camera will lerping to
	private float t; // Keeps track of time for lerp 
	public float followSpeed; // Speed of the camera's lerp on Y
	private float firstG; // Initial recorded Gravity

    void Awake() {
        player = GameObject.Find("BlueBall").transform;
        relCameraPos = transform.position - player.position;
		newY = player.position.y + relCameraPos.y;
		t = 0;
		firstG = Physics.gravity.y;
    }

	void Update() {
		// Camera Position
		if (Physics.gravity.y == 0 - firstG) { // If up-side down.

			if (BallKinematics.Kinematics.TopbounceHeight - relCameraPos.y < newY) { // If the ball bounces lower than expected, indicating that it has moved up:
				newY = BallKinematics.Kinematics.TopbounceHeight - relCameraPos.y;
				BallKinematics.Kinematics.TopbounceHeight = 1024;
				t = 0;
			}

			if ((player.position.y - transform.position.y > relCameraPos.y) && (player.position.y - relCameraPos.y > newY)) { // If it goes above the top of the bounce
				newY = player.position.y - relCameraPos.y;
				t = 0;
			} 

		} else { // If right way up

			if (BallKinematics.Kinematics.bounceHeight + relCameraPos.y > newY) { // If the ball bounces higher than expected, indicating that it has moved up:
				newY = BallKinematics.Kinematics.bounceHeight + relCameraPos.y;
				BallKinematics.Kinematics.bounceHeight = -1024;
				t = 0;
			}

			if ((transform.position.y - player.position.y > relCameraPos.y) && (player.position.y + relCameraPos.y < newY)) { // If it goes below the bottom of the bounce
				newY = player.position.y + relCameraPos.y;
				t = 0;
			} 
		}
		t = t + Time.deltaTime * followSpeed;
		transform.position = new Vector3 (player.position.x + relCameraPos.x, Mathf.Lerp (transform.position.y, newY, t), player.position.z + relCameraPos.z);
	}
}

