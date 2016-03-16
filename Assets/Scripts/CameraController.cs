using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    private Transform player;
    private Vector3 relCameraPos;
    private Vector3 newPos;

    void Awake() {
        player = GameObject.Find("BlueBall").transform;
        relCameraPos = transform.position - player.position;
    }

    void FixedUpdate() {
        if (player.position.y - transform.position.y > 8 || player.position.y - transform.position.y < -3) {
            newPos = new Vector3(player.position.x + relCameraPos.x, player.position.y + relCameraPos.y, player.position.z + relCameraPos.z);
        }
        else {
            newPos = new Vector3(player.position.x + relCameraPos.x, transform.position.y, player.position.z + relCameraPos.z);
        }
        transform.position = newPos;
    }
}
