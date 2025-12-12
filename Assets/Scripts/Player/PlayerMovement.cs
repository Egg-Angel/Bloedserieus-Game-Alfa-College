using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private const string lastHorizontal = "LastHorizontal";
    private const string lastVertical = "LastVertical";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (PauseController.IsGamePaused)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
        rb.linearVelocity = moveInput * moveSpeed;

        animator.SetFloat(horizontal, moveInput.x);
        animator.SetFloat(vertical, moveInput.y);

        if (moveInput != Vector2.zero)
        {
            animator.SetFloat(lastHorizontal, moveInput.x);
            animator.SetFloat(lastVertical, moveInput.y);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        
        moveInput = context.ReadValue<Vector2>();
    }
}
