using System;
using UnityEngine;

public class SnowTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem snowParticles;

    private void Start()
    {
        if (snowParticles.isPlaying)
        {
            snowParticles.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            snowParticles.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            snowParticles.Stop();
        }
    }
}
