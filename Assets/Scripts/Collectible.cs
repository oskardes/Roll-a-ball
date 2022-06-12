using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectible : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource soundCollect;
  
    // Start is called before the first frame update
    void Start()
    {
        soundCollect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        RotationElement();
    }
    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<MovementController>().score += 1;
        soundCollect.clip = sound;
        soundCollect.Play();
        Invoke("SetCollectionActive", 1.0f);
        gameObject.GetComponent<MeshRenderer>().enabled = false; ;
        collider.gameObject.GetComponent<MovementController>().CountingPoint();
        collider.gameObject.GetComponent<MovementController>().ComparePoint();
    }
    void SetCollectionActive()
    {
        gameObject.SetActive(false);
    }

    void RotationElement()
    {
        transform.Rotate(15 * Time.deltaTime, 10 * Time.deltaTime, 20 * Time.deltaTime);
    }
}
