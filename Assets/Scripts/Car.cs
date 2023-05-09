using UnityEngine;
using UnityEngine.InputSystem;

public class Car : MonoBehaviour {
  [SerializeField] InputActionAsset InputActions;
  [SerializeField] Rigidbody Rigidbody;
  [SerializeField] Camera Camera;
  [SerializeField] float Acceleration = 10;
  [SerializeField] float TurnAcceleration = 10;

  InputAction MoveAction;

  void Awake() {
    MoveAction = InputActions.FindActionMap("Player").FindAction("Move");
  }

  void FixedUpdate() {
    var value = MoveAction.ReadValue<Vector2>();
    var groundPoint = transform.position + -0.5f * transform.up;
    var acceleration = value.y * Acceleration * transform.forward;
    Rigidbody.AddForceAtPosition(acceleration, groundPoint, ForceMode.Acceleration);
  }
}