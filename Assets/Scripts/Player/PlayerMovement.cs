using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    public static bool IsTalking;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private const string lastHorizontal = "LastHorizontal";
    private const string lastVertical = "LastVertical";
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (PauseController.IsGamePaused)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
        rb.linearVelocity = moveInput * moveSpeed;
        //Debug.Log(moveInput);

        animator.SetFloat(horizontal, moveInput.x);
        animator.SetFloat(vertical, moveInput.y);

        //reminder to self
        //this is part of me trying to get the player animation to go to idle when the player is talking to an npc
        //i havent figured it out yet so ill so it later
        if (IsTalking == true)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAa");
            //THIS ISNT WORKING SEND HELP
        }

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
