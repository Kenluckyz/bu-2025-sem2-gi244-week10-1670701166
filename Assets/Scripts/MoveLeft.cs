using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public float dash = 2f;

    private float leftBound = -15;

    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!playerController.gameOver)
        {
            float currentSpeed = speed;


            if (Input.GetKey(KeyCode.LeftShift))
            {
                currentSpeed *= dash;
            }

            transform.Translate(Vector3.left * Time.deltaTime * currentSpeed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
