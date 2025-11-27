using UnityEngine;

public class GravityController : MonoBehaviour
{
    public Vector2 gravityUp = new Vector2(0, 9.81f);
    public Vector2 gravityDown = new Vector2(0, -9.81f);
    private bool isNormal = true;

    void Start()
    {
        Physics2D.gravity = gravityDown;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ToggleGravity();
        }
    }

    public void ToggleGravity()
    {
        isNormal = !isNormal;
        Physics2D.gravity = isNormal ? gravityDown : gravityUp;
    }
}