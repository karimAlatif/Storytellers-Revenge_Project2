using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public GameObject ShpereVideoObj;
	public GameObject StartPanel;
	public GameObject PanelTwo;
	[Space]
	public List<string> VideosUrl=new List<string>();

	[Space]

	public Button PlayButton;
	public Sprite PlaySprite;
	public Sprite StopSprite;

	private bool InVideoOne;
	private VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {

		videoPlayer = ShpereVideoObj.GetComponent<VideoPlayer> ();
	}

	// Update is called once per frame
	void Update () {



	}

	public void PlayAndPuaseBut(){


			if (videoPlayer.isPlaying) {
				videoPlayer.Pause ();
			PlayButton.image.sprite = PlaySprite;
			}else{
				videoPlayer.Play ();
			PlayButton.image.sprite = StopSprite;

			}

		
	}

	public void RestartFuc(){

			videoPlayer.time = 0;
	}

	public void ToggleVideos() { // Index -- Index of video to Play

		int videoIndex= (InVideoOne) ? 1 : 0;

		videoPlayer.url = VideosUrl [videoIndex];
		videoPlayer.Play ();

		ShpereVideoObj.gameObject.SetActive (true);
		StartPanel.gameObject.SetActive(false);
		PanelTwo.gameObject.SetActive (true);

		InVideoOne = !InVideoOne;
	}

}
