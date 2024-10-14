using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 13f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravityMultiplier = 1.5f;
    [SerializeField] private float idleAnimationSpeed = 1f;
    [SerializeField] private float acceleratedIdleAnimationSpeed = 2f;
    private float normalSpeed = 10f;
    private float runSpeed = 20f;
    private float wallSpeed = 5f;

    private Rigidbody rigidBodyPlayer;
    private bool isGrounded;
    private bool isTouchingWall;
    private Animator playerAnimator;

    private void Start()
    {
        rigidBodyPlayer = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Проверка на столкновение со стеной
        if (isTouchingWall)
        {
            moveSpeed = wallSpeed;  // Если касается стены, скорость всегда 5
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;  // Увеличенная скорость при удерживании шифта
            playerAnimator.speed = acceleratedIdleAnimationSpeed;
        }
        else
        {
            moveSpeed = normalSpeed;  // Обычная скорость
            playerAnimator.speed = idleAnimationSpeed;
        }

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        rigidBodyPlayer.MovePosition(transform.position + move * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidBodyPlayer.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (!isGrounded)
        {
            rigidBodyPlayer.AddForce(Physics.gravity * (gravityMultiplier - 1), ForceMode.Acceleration);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        // Проверка на столкновение со стеной
        if (collision.gameObject.CompareTag("Wall"))
        {
            isTouchingWall = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

        // Если игрок перестает касаться стены
        if (collision.gameObject.CompareTag("Wall"))
        {
            isTouchingWall = false;
        }
    }
}
