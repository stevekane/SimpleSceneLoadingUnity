using UnityEngine;

public class TrackListView : MonoBehaviour {
  [SerializeField] Track[] Tracks;
  [SerializeField] RectTransform Content;
  [SerializeField] TrackListElementView TrackListElememtViewPrefab;

  void OnEnable() {
    var existing = Content.GetComponentsInChildren<TrackListElementView>();
    foreach (var elementView in existing)
      Destroy(elementView.gameObject);
    foreach (var track in Tracks) {
      var elementView = Instantiate(TrackListElememtViewPrefab, Content);
      elementView.Track = track;
    }
  }
}