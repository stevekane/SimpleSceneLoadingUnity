using UnityEngine;
using DevLocker.Utils;

[CreateAssetMenu(menuName = "Track")]
public class Track : ScriptableObject {
  public string Name;
  public string Description;
  public SceneReference Scene;
  public Color Color;
  public float Gold;
  public float Silver;
  public float Bronze;
}