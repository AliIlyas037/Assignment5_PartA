using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{

    //sounds used in game
    public AudioSource clickSound;
   

    // Use this for initialization
    void Start()
    {

    }


    //play sound if it's enabled in menu
    public void PlaySound(AudioSource sound)
    {
     
            sound.Play();
      
    }


}
