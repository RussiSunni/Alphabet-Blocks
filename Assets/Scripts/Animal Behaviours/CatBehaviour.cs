using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{    
    List<GameObject> waypoints = new List<GameObject>();
    GameObject WP1, WP2;
    int currentWP = 0;

    SpriteRenderer spriteRenderer;
    AudioSource audioSource;

    public float speed = 1.0f;

    void Start()
    {
        WP1 = GameObject.Find("WP01");
        WP2 = GameObject.Find("WP02");
        waypoints.Add(WP1);
        waypoints.Add(WP2);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = false;

        audioSource = GetComponent<AudioSource>();
    }
   
    void Update()
    {
        if (Vector2.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
        {
            spriteRenderer.flipX = true;
            currentWP++;
            audioSource.Play();
        }

        if (currentWP >= waypoints.Count)
        {
            spriteRenderer.flipX = false;
            currentWP = 0;
            audioSource.Play();
        }

            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWP].transform.position, 0.01f);
    }
}
