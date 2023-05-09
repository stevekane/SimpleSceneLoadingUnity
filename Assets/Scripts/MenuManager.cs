using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour {
  public static MenuManager Instance;

  [SerializeField] InputActionAsset InputActions;
  [SerializeField] Menu Menu;

  InputActionMap MenuActionMap;

  void Awake() {
    if (Instance != null && Instance != this) {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    MenuActionMap = InputActions.FindActionMap("Menu");
    MenuActionMap.Enable();
    MenuActionMap.FindAction("Toggle").performed += ToggleMenu;
    DontDestroyOnLoad(gameObject);
  }

  void OnDestroy() {
    if (Instance == this) {
      Instance = null;
      MenuActionMap.FindAction("Toggle").performed -= ToggleMenu;
    }
  }

  void ToggleMenu(InputAction.CallbackContext ctx) {
    Menu.SetStatus(!Menu.GetStatus());
  }
}