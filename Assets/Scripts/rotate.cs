using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotate : MonoBehaviour
{

    public float x,y,z = 0f;


    void Update()
    {
        gameObject.transform.Rotate(x, y, z, Space.Self);
      
    }
}
