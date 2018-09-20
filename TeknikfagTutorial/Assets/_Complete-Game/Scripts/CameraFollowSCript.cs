using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSCript : MonoBehaviour {
    public GameObject playerObject;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(playerObject != null)
        {
            Vector3 cameraPos = new Vector3(playerObject.transform.position.x + xOffset, playerObject.transform.position.y + yOffset, playerObject.transform.position.z + zOffset);
            transform.position = cameraPos;
        }

	}
}
