using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  public static GameManager Instance;

  [SerializeField] InputActionAsset InputActions;

  void Awake() {
    if (Instance != null && Instance != this) {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  void OnDestroy() {
    if (Instance == this)
      Instance = null;
  }

  void LoadTrack(Track track) {
    SceneManager.LoadScene(track.Scene.SceneName, LoadSceneMode.Single);
  }
}