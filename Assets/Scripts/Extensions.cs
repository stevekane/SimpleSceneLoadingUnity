using UnityEngine;
using UnityEngine.InputSystem;

public static class Extensions {
  public static void SetEnabled(this InputActionMap actionMap, bool enabled) {
    if (enabled && !actionMap.enabled)
      actionMap.Enable();
    else if (!enabled && actionMap.enabled)
      actionMap.Disable();
  }
}