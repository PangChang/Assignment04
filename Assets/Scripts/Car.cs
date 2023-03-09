using UnityEditor;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public static float CarSpeed;


    void Start()
    {

    }

    void FixedUpdate()
    {
        speed = DataManager.CarSpeed;
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
