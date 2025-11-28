using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private PhysicsMaterialConfiguration physicsMaterialConfiguration;

    private void Start()
    {
        physicsMaterialConfiguration.ApplyPhysicsMaterialConfigurations();
    }
}
