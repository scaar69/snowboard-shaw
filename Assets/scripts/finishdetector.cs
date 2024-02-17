using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishdetector : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finisheffect;
    [SerializeField] AudioClip finishSFX;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player")
        {
            finisheffect.Play();
            GetComponent<AudioSource>().PlayOneShot(finishSFX);
            Invoke("Reloadscene", delay);
        }

    }

    void Reloadscene()
    {
        SceneManager.LoadScene(0);
    }
}
