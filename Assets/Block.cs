using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour {

    private bool blockbool = false;

    AudioSource audioSource;

    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

 

        if (blockbool == true)
        {

            audioSource.Play();

            blockbool = false;

        }
    

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground"||collision.gameObject.tag=="Block")
        {

            blockbool=true;

        }

    }

}
