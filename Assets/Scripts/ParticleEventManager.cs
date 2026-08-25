using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParticleEventManager : MonoBehaviour
{
    public VisualEffect Breath;
    public VisualEffect Dust_R;
    public VisualEffect Dust_L;

    void ParticleEvent(int eventInteger)
    {
        Debug.Log("Particle event: " + eventInteger);
        if (eventInteger == 0)
        {
            Breath.Play();
        }

        if (eventInteger == 1)
        {
            Dust_R.Play();
        }

        if (eventInteger == 2)
        {
            Dust_L.Play();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
