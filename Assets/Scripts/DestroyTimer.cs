using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour {

    private float timeF = 0.0f;
    private float dist = 0.0f;
    public int time = 0;
    public static DestroyTimer Script;

    void Start () {
        Script = this;
    }
    	
	void Update () {
        dist = BallController.Script.transform.position.z - (float)time;
        if (dist > 10) {
            timeF += 1f;
        }
        print(dist);
        timeF += Time.deltaTime;
        time = Mathf.RoundToInt(4 * timeF) - 5;
	}
}
