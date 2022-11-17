using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPController : MonoBehaviour
{
    PostProcessVolume volume;
    ChromaticAberration aberration;
    void Start()
    {
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings<ChromaticAberration>(out aberration);
    }

    bool flipFlop;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            flipFlop = !flipFlop;
            if (flipFlop)
            {
                aberration.intensity.Override(1);
            }
            else
            {
                aberration.intensity.Override(0);
            }
        }
    
    }
}
