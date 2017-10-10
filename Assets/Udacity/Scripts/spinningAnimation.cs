using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningAnimation : MonoBehaviour {

    public GameObject spinningObject;
    public bool isCircularObject;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var deltaTime = Time.deltaTime;
        if (isCircularObject)
            spinningObject.transform.Rotate(rotationSpeed * 10f * deltaTime, rotationSpeed * 10f * deltaTime, rotationSpeed * 10f * deltaTime);
        else
            spinningObject.transform.Rotate(0f, 0f, rotationSpeed * 10f * deltaTime);
    }
}
