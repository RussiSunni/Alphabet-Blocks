using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cat;
    public GameObject dog;
    void Start()
    {

    }

    public void Cat()
    {
        if (GameObject.Find("CAT(Clone)") == null)
        {
            Instantiate(cat, new Vector3(0, 0, 0), Quaternion.identity);
        }        
    }
    public void Dog()
    {
        if (GameObject.Find("Dog(Clone)") == null)
        {
            Instantiate(dog, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
