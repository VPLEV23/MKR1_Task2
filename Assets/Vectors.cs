using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    Vector3 pos;
    Vector3 pos2;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(1, -5, 7);
        pos2 = new Vector3(2, 0, -6);
        result = Vector3.Dot(pos,pos2);
        Debug.Log(result)
    }

    // Update is called once per frame
    void Update()
    {

    }
}
