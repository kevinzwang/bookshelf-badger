using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    public AudioClip[] BGSongs;
    private int index;
    private static AudioScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        nextSong();
    }

    private void nextSong()
    {
        index = Random.Range(0, BGSongs.Length);
        Debug.Log("Currently Playing Song: " + index);
        musicSource.clip = BGSongs[index];
        musicSource.Play();
    }

    private void Update()
    {
        if (!musicSource.isPlaying)
        {
            nextSong();
        }
    }
}
