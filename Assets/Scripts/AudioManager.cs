using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip clickSound;
    public AudioClip shotSound;
    public AudioClip dieSound;
    public AudioClip winSound;
    public AudioClip loseSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LoseSound() {
        audioSource.PlayOneShot(clickSound);
    }  

    public void WinSound() {
        audioSource.PlayOneShot(winSound);
    }  

    public void ShotSound()
    {
        audioSource.PlayOneShot(shotSound);
    }

    public void DieSound()
    {
        audioSource.PlayOneShot(dieSound);
    }

}

