using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MovementController>().rig.velocity = new Vector3(0f, 20.0f, 0f);

    }
}
