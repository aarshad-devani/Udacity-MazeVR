using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    private AudioSource MobjAudioSource = null;
    public AudioClip audioClip = null;
    private bool coinClicked = false;

    void Awake()
    {
        MobjAudioSource = gameObject.GetComponent<AudioSource>();
        MobjAudioSource.clip = audioClip;
        MobjAudioSource.playOnAwake = false;
    }

    void Update()
    {
        if (coinClicked)
            gameObject.transform.localScale = (Vector3.zero);
    }
    public void OnCoinClicked() {
        //Debug.Log("Coin is Clicked");
        coinClicked = true;
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }

}
