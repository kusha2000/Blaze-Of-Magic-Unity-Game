using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoM_Sounds : MonoBehaviour
{
    public AudioSource source;

    public AudioClip footstep;

    void footsound()
    {
        source.clip = footstep;
        source.Play();
    }
}
