using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xVariable = 0;
    [SerializeField]float yVariable = 1.0f;
    [SerializeField]float zVariable = 0;
    // Update is called once per frame
    void Update()
    {
        //Rotates object.
        transform.Rotate(xVariable,yVariable,zVariable);
    }
}
