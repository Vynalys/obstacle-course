using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 3;
    // Start is called before the first frame update
    void Start()
    {
        //Sets renderer and gravity at the beginning of the game of falling blocks to false. So it is ensured, that the blocks dont fall before 3 seconds.
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Takes time passed when ingame and checks if its over 3 seconds. If it is, renderer and gravity of falling blocks get enabled.

        if(Time.time > timeToWait){
           renderer.enabled = true;
           rigidbody.useGravity = true;
        }
    }
}
