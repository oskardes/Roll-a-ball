using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroll : MonoBehaviour
{
    private Material mat;
    
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        mat.mainTextureOffset += new Vector2(0.1f, 0.02f) * Time.deltaTime;
    }
}
