using UnityEngine;
using System.Collections;

public class PlatformGen : MonoBehaviour {

    public float zInterval = 1f;
    public float zDistance = 50f;
    public GameObject platform1;    // make sure platforms are set to the correct prefabs in Inspector
    public GameObject platform2;
    public GameObject pfLighting;
    public float zReached = 0f;

    void Start() {
        for (float a = 2f; a < zDistance+1f; a += 2) {
            Instantiate(platform1, new Vector3(0, 0, a), Quaternion.identity);
            Instantiate(platform1, new Vector3(0, 4, a), Quaternion.Euler(0, 0, 180));
        }
        for (float b = 3f; b < zDistance+1f; b += 2) {
            Instantiate(platform2, new Vector3(0, 0, b), Quaternion.identity);
            Instantiate(platform2, new Vector3(0, 4, b), Quaternion.Euler(0, 0, 180));
        }
        for (float c = 5f; c < zDistance+1f; c += 5) {
            Instantiate(pfLighting, new Vector3(0, 2, c), Quaternion.identity);
        }
    }

    void FixedUpdate() {

        if (Mathf.Round(transform.position.z) > zReached) {
            zReached = Mathf.Round(transform.position.z);
            if (zReached % 2 == 0) {
                Instantiate(platform1, new Vector3(0, 0, zReached + zDistance), Quaternion.identity);
                Instantiate(platform1, new Vector3(0, 4, zReached + zDistance), Quaternion.Euler(0, 0, 180));
            }
            else {
                Instantiate(platform2, new Vector3(0, 0, zReached + zDistance), Quaternion.identity);
                Instantiate(platform2, new Vector3(0, 4, zReached + zDistance), Quaternion.Euler(0, 0, 180));
            }
            if (zReached % 5 == 0) {
                Instantiate(pfLighting, new Vector3(0, 2, zReached + zDistance), Quaternion.identity);
            }
        }
    }
}
