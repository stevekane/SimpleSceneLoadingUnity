using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour {
  [SerializeField] InputActionAsset InputActions;

  InputActionMap UIActionMap;
  InputActionMap PlayerActionMap;

  void Awake() {
    UIActionMap = InputActions.FindActionMap("UI");
    PlayerActionMap = InputActions.FindActionMap("Player");
  }

  public void SetStatus(bool isOpen) {
    gameObject.SetActive(isOpen);
    UIActionMap.SetEnabled(isOpen);
    PlayerActionMap.SetEnabled(!isOpen);
  }

  public bool GetStatus() {
    return gameObject.activeSelf;
  }
}