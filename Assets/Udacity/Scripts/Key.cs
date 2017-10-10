using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    private bool keyClicked = false;

    void Update()
	{
        if (keyClicked)
            gameObject.transform.localScale = (Vector3.zero);
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        //Debug.Log("Key is clicked");
        keyClicked = true;
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }

}
