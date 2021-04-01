using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{

    public PlayerMovement playerMovement;

    public void moveLeft(){
        playerMovement.moveLeft = true;
    }
    public void moveRight()
    {
        playerMovement.moveRight = true;
    }
}
