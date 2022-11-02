using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        //Prints score to console and increments the score by 1 everytime the player bumps into something.
        hits++;
        Debug.Log("Outch! You bumped into me " + hits + " times! :c");

    }
}
