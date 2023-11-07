using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    public bool isFacingRight = true;
    public float faceDirection;

    public void Flip()
    {

        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0);
        faceDirection = (isFacingRight) ? 1 : -1;

    }
}
