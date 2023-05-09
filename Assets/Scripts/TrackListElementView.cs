using System;
using UnityEngine;
using TMPro;

public class TrackListElementView : MonoBehaviour {
  [SerializeField] TextMeshProUGUI Title;
  [SerializeField] TextMeshProUGUI Description;
  [SerializeField] TextMeshProUGUI GoldTime;
  [SerializeField] TextMeshProUGUI SilverTime;
  [SerializeField] TextMeshProUGUI BronzeTime;

  Track track;

  public void OnSelect() {
    GameManager.Instance.SendMessage("LoadTrack", Track);
  }

  public Track Track {
    get => track;
    set {
      track = value;
      Title.text = track.Name;
      Description.overrideColorTags = false;
      Description.text = track.Description;
      Description.color = track.Color;
      GoldTime.text = TimeSpan.FromSeconds(track.Gold).ToString();
      SilverTime.text = TimeSpan.FromSeconds(track.Silver).ToString();
      BronzeTime.text = TimeSpan.FromSeconds(track.Bronze).ToString();
    }
  }
}