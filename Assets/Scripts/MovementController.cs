using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MovementController : MonoBehaviour
{
    public Rigidbody rig;
    public float trust = 5.0f;
    public float jumpForce = 7.0f;
    public LayerMask groundLayers;
    public int score;
    private bool isGroud;
    public event Action pickupEvent;
    public event Action event2;
    public event Action checkHeight;
    public event Action LavaEnter;
    // Start is called before the first frame update

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        GetInputAndUpdateMove();
    }



    private void GetInputAndUpdateMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rig.AddForce(Vector3.forward * trust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForce(Vector3.right * trust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(Vector3.back * trust);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForce(Vector3.left * trust);
        }

        if (Input.GetKey(KeyCode.Space) && isGroud == true)
        {
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGroud = false;

        }
    }

     public void CountingPoint()
    {
         pickupEvent?.Invoke();
    }

    public void ComparePoint()
    {
        event2?.Invoke();
    }

    public void CheckHeight()
    {
        checkHeight?.Invoke();
    }

   public void OnLavaEnter() 
    {
        LavaEnter?.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.name == "Trampoline" || collision.gameObject.tag == "Stairs")
        {
            isGroud = true;
        }

        if (collision.gameObject.name == "Labirynth_floor")
        {
            isGroud = false;
        }
        if (collision.gameObject.tag == "Lava")
        {
            OnLavaEnter();
        }
    }
}
