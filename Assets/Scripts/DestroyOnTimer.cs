using UnityEngine;
using System.Collections;

public class DestroyOnTimer : MonoBehaviour {

    private float destroyZ;
    
	void Update () {
        destroyZ = (float) DestroyTimer.Script.time;
        if (destroyZ >= transform.position.z) {
            Destroy(gameObject, 0.0f);
        }
	}
}
