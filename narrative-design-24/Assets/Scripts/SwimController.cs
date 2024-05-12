using UnityEngine;
using UnityEngine.InputSystem;

public class SwimController : MonoBehaviour
{
    public float swimSpeed = 5;
    public float verticalSpeed = 0.2f;
    public float _rotationVelocity = 1;
    private Vector3 _rotation;
    public Camera cam;
    private Rigidbody rb;
    private PlayerInput playerInput;
    private  InputController inputController;
    private const float _threshold = 0.01f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputController = new InputController();
        inputController.Swimming.Enable();
    }

    void FixedUpdate() {
        Vector2 inputVector = inputController.Swimming.Move.ReadValue<Vector2>();

        Movement_performed(inputVector);
    }

    void LateUpdate() {
        CameraRotation();
    }

    void CameraRotation() {
        Vector2 inputRotation = inputController.Swimming.Look.ReadValue<Vector2>();
        if (inputController.Swimming.Look.ReadValue<Vector2>().sqrMagnitude >= _threshold)
        {
            _rotation.x += inputRotation.y * _rotationVelocity;
            _rotation.y += inputRotation.x * _rotationVelocity;
            TiltHead();
            gameObject.transform.rotation = Quaternion.Euler(_rotation);
        }
        if (inputController.Swimming.DiveUp.IsPressed()) {
            rb.AddForce(verticalSpeed * swimSpeed * transform.up, ForceMode.Force);
        } else if (inputController.Swimming.DiveDown.IsPressed()) {
            rb.AddForce(-verticalSpeed * swimSpeed * transform.up, ForceMode.Force);
        }
    }

    void TiltHead() {
        // _rotation.z += (Quaternion.Inverse(transform.rotation) * rb.velocity).x * 10;
        // Debug.Log(Quaternion.Inverse(transform.rotation) * rb.velocity);
    }

    void Movement_performed(Vector2 inputMove) {
        if (inputMove.y != 0) {
            rb.AddForce(inputMove.y * swimSpeed * transform.forward, ForceMode.Force);
        }
        if (inputMove.x != 0) {
            rb.AddForce(inputMove.x * swimSpeed * transform.right, ForceMode.Force);
        }
    }
}
