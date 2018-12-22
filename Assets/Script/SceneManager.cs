using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public GameObject ShpereVideoObj;
	public GameObject StartPanel;
	public Button HotSpotPoint;
	[Space]
	public List<string> VideosUrl=new List<string>();


	private bool InVideoOne;
	private VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {

		videoPlayer = ShpereVideoObj.GetComponent<VideoPlayer> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {

			if (videoPlayer.isPlaying) {
				videoPlayer.Pause ();
			}else{
				videoPlayer.Play ();
			}

		}
		if (Input.GetKeyDown(KeyCode.R)) {
			videoPlayer.time = 0;
		}
	}

	public void ToggleVideos() { // Index -- Index of video to Play

		int videoIndex= (InVideoOne) ? 1 : 0;

		videoPlayer.url = VideosUrl [videoIndex];
		videoPlayer.Play ();

		ShpereVideoObj.gameObject.SetActive (true);
		StartPanel.gameObject.SetActive(false);
		HotSpotPoint.gameObject.SetActive (true);

		InVideoOne = !InVideoOne;
	}

}
