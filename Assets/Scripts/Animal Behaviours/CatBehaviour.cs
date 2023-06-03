using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{    
    List<GameObject> waypoints = new List<GameObject>();
    GameObject WP1, WP2;
    int currentWP = 0;

    SpriteRenderer catSpriteRenderer;
    AudioSource audioSource;

    public float speed = 1.0f;

    void Start()
    {
        WP1 = GameObject.Find("WP01");
        WP2 = GameObject.Find("WP03");
        waypoints.Add(WP1);
        waypoints.Add(WP2);
        catSpriteRenderer = GetComponent<SpriteRenderer>();
        catSpriteRenderer.flipX = false;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
        {
            catSpriteRenderer.flipX = true;
            currentWP++;
            audioSource.Play();
        }

        if (currentWP >= waypoints.Count)
        {
            catSpriteRenderer.flipX = false;
            currentWP = 0;
            audioSource.Play();
        }

            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWP].transform.position, 0.01f);
    }
}
