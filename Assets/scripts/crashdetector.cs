using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    [SerializeField] float delay1 = 1.0f;
    [SerializeField] ParticleSystem crasheffect;
    [SerializeField] AudioClip crashSFX;

    bool hascrashed = false;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Ground" && !hascrashed)
        {
            hascrashed = true;
            FindObjectOfType<playercontrol>().DisableControls();
            crasheffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("Reloadscene", delay1);
        }

    }

    void Reloadscene()
    {
        SceneManager.LoadScene(0);

    }
}
