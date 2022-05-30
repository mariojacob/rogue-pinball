using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpReaction : MonoBehaviour
{
    private AudioSource _sound;

    void Start()
    {
        _sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_sound != null && other.gameObject.CompareTag("Ball"))
            _sound.Play();
    }
}
