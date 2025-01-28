using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
        public AudioSource backgroundMusic;

        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void PlayMusic()
        {
            if (backgroundMusic != null && !backgroundMusic.isPlaying)
            {
                backgroundMusic.Play();
            }
        }

        public void StopMusic()
        {
            if (backgroundMusic != null && backgroundMusic.isPlaying)
            {
                backgroundMusic.Stop();
            }
        }

}
