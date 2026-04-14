using UnityEngine;
using UnityEngine.InputSystem;

public class CarBehavior : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    float rotateSpeed = 50f;
    private Rigidbody rb;

    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    [Header("Input Actions")]
    public InputActionReference moveAction;

    private void OnEnable()
    {
        moveAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (moveVertical != 0 && moveHorizontal != 0)
        {
            // if (moveHorizontal > 0)
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
            // else if (moveHorizontal < 0)
            //     transform.Rotate(0, -Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        }
        Vector3 movement = new Vector3(-moveVertical, 0.0f, 0);
        Vector3 worldDirection = transform.TransformDirection(movement);
        transform.position += worldDirection * moveSpeed * Time.deltaTime;
    }
}
