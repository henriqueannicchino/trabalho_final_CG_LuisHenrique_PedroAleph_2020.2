using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	public GameObject Countdown;
	public AudioSource GetReady;
	public GameObject LapTimer;
	public GameObject CarControls;
	public AudioSource LevelMusic;

	void Start () {
		StartCoroutine (countStart ());
	}


	IEnumerator countStart(){
		yield return new WaitForSeconds (0.5f);
		GetReady.Play ();
		yield return new WaitForSeconds (1);
		Countdown.GetComponent<Text> ().text = "3";
		Countdown.SetActive (true);
		yield return new WaitForSeconds (1);
		Countdown.SetActive (false);
		Countdown.GetComponent<Text> ().text = "2";
		Countdown.SetActive (true);
		yield return new WaitForSeconds (1);
		Countdown.SetActive (false);
		Countdown.GetComponent<Text> ().text = "1";
		Countdown.SetActive (true);
		yield return new WaitForSeconds (2);
		Countdown.SetActive (false);
		
		LevelMusic.Play ();
		LapTimer.SetActive (true);
		CarControls.SetActive (true);

	}

}
