using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip selectcard;
    public AudioClip playcard;
    public AudioClip drawcard;
    
    public static Audio instant;
    AudioSource m_source;
     void Start()
    {
        instant = this;    
    }
    void Awake()
    {
        m_source = GetComponent<AudioSource>();
    }
    public void selectcardd()
    {
        m_source.PlayOneShot(selectcard, m_source.volume);
    }
    public void playcardd()
    {
        m_source.PlayOneShot(playcard, m_source.volume);
    }

    public void drawcardd()
    {   
        m_source.PlayOneShot(drawcard, m_source.volume);
    }


}
