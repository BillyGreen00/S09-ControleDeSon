using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionnaireMusique : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;


    public void ChangerVolumeMusique(float nouveauVolume) 
    {
        Debug.Log("Changer volume musique" + nouveauVolume);
        _mixer.SetFloat("VolumeMusique", nouveauVolume);
    }
}
