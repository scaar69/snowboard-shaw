using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusttrial : MonoBehaviour
{
    [SerializeField] ParticleSystem boardeffect;
    //[SerializeField] AudioClip jumpSFX;
    [SerializeField] AudioClip landSFX;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")

        {
            boardeffect.Play();
            GetComponent<AudioSource>().PlayOneShot(landSFX);

        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")

        {
            //GetComponent<AudioSource>().PlayOneShot(jumpSFX);
            boardeffect.Stop();
        }
    }
}
