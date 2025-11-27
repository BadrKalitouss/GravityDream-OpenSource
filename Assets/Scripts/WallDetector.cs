using UnityEngine;

public class WallDetector : MonoBehaviour
{
    public bool isTouchingWall = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        isTouchingWall = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isTouchingWall = false;
    }
}