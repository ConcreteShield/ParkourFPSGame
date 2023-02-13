using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBox : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        GetComponent<AudioSource>().Play();
    }
}
