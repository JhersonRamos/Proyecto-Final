using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostPros : MonoBehaviour
{
    public PostProcessVolume vol;
    public Bloom Blomm_;
    public Vignette Vignetee_;
    
    void Awake()
    {
        vol.profile.TryGetSettings(out Blomm_);
        vol.profile.TryGetSettings(out Vignetee_);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            Blomm_.intensity.value = 7f;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Vignetee_.intensity.value = 1f;
        }



    }
}
