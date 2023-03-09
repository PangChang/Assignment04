using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    public AudioSource audioSource;
    public bool alreadyPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Car")
        {
            if (!alreadyPlayed)
            {
                audioSource.Play();
                alreadyPlayed = true;
            }
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            Debug.Log("Hit Car");
            Score.CurrentScore = 0;
            Invoke("Restart", 5f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
