using UnityEngine;

public class input : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _jumpHeight = 2f;
    [SerializeField] private float _gravity = -9.8f;
    private float VelocityY;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    { 
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        Vector3 velocity = direction * _movementSpeed;

        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                VelocityY = _jumpHeight;
            }

        }
        else
        {
            VelocityY -= _gravity;
        }

        velocity.y = VelocityY;
        controller.Move(velocity * Time.deltaTime);
        
    }
}
