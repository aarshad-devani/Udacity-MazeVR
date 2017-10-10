using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool doorOpening = false;
    private bool doorLocked = true;
    private AudioSource _audioSource = null;
    public AudioClip closedDoorAudio;
    public AudioClip doorOpeningAudio;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public float openingSpeed;
    private bool actiontrigger = false;

    void Awake()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
    }
    void Update() {
        if (doorOpening)
        {
            //if (((int)leftDoor.transform.rotation.eulerAngles.y == 0) && !actiontrigger)
            //{
            //    doorOpening = false;
            //    actiontrigger = true;

            //}
            //var deltaTime = Time.deltaTime;
            if (((int)leftDoor.transform.position.y > 15f) && !actiontrigger)
            {
                doorOpening = false;
                actiontrigger = true;
            }
            if (!actiontrigger)
            {
                gameObject.transform.Translate(0f, openingSpeed * Time.deltaTime, 0f);
                //this is not working since collider is still present event though if we are rotating the doors, need to talk to mentor
                //leftDoor.transform.Rotate(0f, 0f, openingSpeed * -10f * deltaTime);
                //rightDoor.transform.Rotate(0f, 0f, openingSpeed * 10f * deltaTime);
            }
        }
    }

    public void OnDoorClicked() {
        if (!doorLocked)
        {
            doorOpening = true;
            _audioSource.clip = doorOpeningAudio;
            _audioSource.Play();
        }
        else
        {
            _audioSource.clip = closedDoorAudio;
            _audioSource.Play();
        }
    }

    public void Unlock()
    {
        doorLocked = false;
    }
}
