using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cat;
    public GameObject dog;
    public GameObject catClone;
    public GameObject dogClone;

    AudioSource audioSource;
    public AudioClip catAudioClip;
    public AudioClip dogAudioClip;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Cat()
    {
        if (GameObject.Find("CAT(Clone)") == null)
        {
            audioSource.clip = catAudioClip;
            audioSource.Play();
            catClone = Instantiate(cat, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Destroy(catClone);
        }
    }
    public void Dog()
    {
        if (GameObject.Find("DOG(Clone)") == null)
        {
            audioSource.clip = dogAudioClip;
            audioSource.Play();
            dogClone = Instantiate(dog, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Destroy(dogClone);
        }
    }
}
