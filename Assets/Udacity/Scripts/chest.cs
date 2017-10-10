using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour {
    public bool openChestAutoOnDoorOpen;
    public GameObject chestArmatureTopPoof;
    public float openingSpeed;
    private bool chestOpening = false;
    private bool eventTriggered = false;

	// Use this for initialization
	void Start () {

		
	}
	
    void Awake()
    {

    }
	// Update is called once per frame
	void Update () {
        if (chestOpening)
        {
            if (((int)chestArmatureTopPoof.transform.rotation.eulerAngles.y == 0) && !eventTriggered)
            {
                chestOpening = false;
                eventTriggered = true;
            }
            if (!eventTriggered) {
                Debug.Log(chestArmatureTopPoof.transform.rotation.eulerAngles);
                chestArmatureTopPoof.transform.Rotate(openingSpeed * 10f * Time.deltaTime, 0f, 0f);
            }
        }
    }

    public void OpenChest()
    {
        chestOpening = true;
    }
}
