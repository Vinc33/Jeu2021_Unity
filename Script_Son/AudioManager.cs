using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    private int musicIndex = 0;

    // Gère et boucle la music en background dans un scène
    
    
    
    void Start()
    {
      audioSource.clip = playlist[0];
      audioSource.Play();  
    }

    
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            PlayNextSong();
        }
    }

    void PlayNextSong()
    {
       musicIndex = (musicIndex + 1) % playlist.Length;
       audioSource.clip = playlist[musicIndex];
       audioSource.Play();
    }
    
}
