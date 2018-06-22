using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour {

    private bool blockbool = false;

    private bool blockbool2 = true;

    AudioSource audioSource;

    private float audiotime;

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

        if (blockbool2==true)
        {

            if (blockbool == true)
            {

                  blockbool2 = false;

    blockbool = false;

                    audioSource.Play();


            }

        }

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag=="Block")
        {

            blockbool = true;

        }

    }

}
