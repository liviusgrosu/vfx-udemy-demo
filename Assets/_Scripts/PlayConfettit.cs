using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayConfettit : MonoBehaviour
{
    private List<ParticleSystem> particleEffects;

    private void Awake()
    {
        particleEffects = new List<ParticleSystem>();
        GetComponentsInChildren(particleEffects);

        foreach(ParticleSystem particleEffect in particleEffects)
        {
            particleEffect.Stop();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(ParticleSystem particleEffect in particleEffects)
            {
                particleEffect.Play();
            }
        }
    }
}
