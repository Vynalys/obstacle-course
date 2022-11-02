using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //If the player hits the object (Collider hits Collider), which contains this script, the color changes and a message is sent to the console.
 private void OnCollisionEnter(Collision other) 
 {
    //Get compnent of the object calls Mesh Renderer, access its material and change its color to magenta.
    GetComponent<MeshRenderer>().material.color = Color.magenta;
 }

}
