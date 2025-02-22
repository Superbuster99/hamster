using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PressToMove();
    }

    void PressToMove()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
    }
}
