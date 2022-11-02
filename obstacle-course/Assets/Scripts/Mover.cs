using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        printInstructionToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    //Prints instructions about the game to the console.
    void printInstructionToConsole(){

        Debug.Log("Press W,A,S,D to move your character.\n Reach the end of the level, without getting hit and you win the game!");
    }

    void movePlayer(){

        //Get Inputs from Unity, to move the player character.
        //Multiply with time.deltaTime to make movement not dependent on frames

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
