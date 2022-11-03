using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodGroupScript : MonoBehaviour
{

    LODGroup group;
    // Start is called before the first frame update
    void Start()
    {
        group = GetComponent<LODGroup>();

        group.fadeMode = LODFadeMode.CrossFade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
