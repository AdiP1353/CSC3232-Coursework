using System;
using UnityEngine;

public class PhysicsMaterialConfiguration : MonoBehaviour
{
    [Header("Physics Materials")]
    [SerializeField] private PhysicsMaterial groundMaterial;
    [SerializeField] private PhysicsMaterial slowMaterial;
    [SerializeField] private PhysicsMaterial playerMaterial;


    private void Start()
    {
        
    }

    public void ApplyPhysicsMaterialConfigurations()
    {
        SetPhysicsMaterialProperties( groundMaterial, 50f, 0.6f, 0f, PhysicsMaterialCombine.Maximum, PhysicsMaterialCombine.Average);
        SetPhysicsMaterialProperties( playerMaterial, 25f, 0.6f, 0f, PhysicsMaterialCombine.Maximum, PhysicsMaterialCombine.Average);
        SetPhysicsMaterialProperties( slowMaterial, 150f, 1.2f, 0f, PhysicsMaterialCombine.Maximum, PhysicsMaterialCombine.Minimum);
    }
    private void SetPhysicsMaterialProperties(PhysicsMaterial material,float dynamicFriction, float staticFriction, float bounciness,
        PhysicsMaterialCombine frictionCombine, PhysicsMaterialCombine bounceCombine)
    {
        material.dynamicFriction = dynamicFriction;
        material.staticFriction = staticFriction;
        material.bounciness = bounciness;
        material.frictionCombine = frictionCombine;
        material.bounceCombine = bounceCombine;
    }
}
