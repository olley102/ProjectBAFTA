using UnityEngine;
using System.Collections;

public class PlatformGen : MonoBehaviour {

    public float zInterval = 1f;
    public float zDistance = 100f;
    public GameObject platform1;    // make sure platforms are set to the correct prefabs in Inspector
    public GameObject platform2;
    public float zReached = 0f;

    void Start() {
        for (float a = 2f; a < zDistance+1f; a += 2) {
            Instantiate(platform1, new Vector3(0, 0, a), Quaternion.identity);
        }
        for (float b = 3f; b < zDistance+1f; b += 2) {
            Instantiate(platform2, new Vector3(0, 0, b), Quaternion.identity);
        }
    }

    void FixedUpdate() {

        if (Mathf.Round(transform.position.z) > zReached) {
            zReached = Mathf.Round(transform.position.z);
            if (zReached % 2 == 0) {
                Instantiate(platform1, new Vector3(0, 0, zReached + zDistance), Quaternion.identity);
            }
            else {
                Instantiate(platform2, new Vector3(0, 0, zReached + zDistance), Quaternion.identity);
            }
        }
    }
}
