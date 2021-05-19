using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject otherCar;

	void OnTriggerEnter(){
		if (ModeTime.isTimeMode == true) {
			//estamos no modo raceTime

		} else {
			LapTimeManager.raceFinished=1;
			this.GetComponent<BoxCollider> ().enabled = false;
			MyCar.SetActive (false);
			otherCar.SetActive (false);
			CompleteTrig.SetActive (false);
			CarController.m_Topspeed = 0.0f;
			MyCar.GetComponent<CarController> ().enabled = false;
			otherCar.GetComponent<CarController> ().enabled = false;
			MyCar.GetComponent<CarUserControl> ().enabled = false;
			otherCar.GetComponent<CarAIControl> ().enabled = false;
			MyCar.SetActive (true);
			otherCar.SetActive (true);
			MyCar.GetComponent<CarAudio> ().StopSound ();
			MyCar.GetComponent<CarAudio> ().enabled = false;
			otherCar.GetComponent<CarAudio> ().StopSound ();
			otherCar.GetComponent<CarAudio> ().enabled = false;
			FinishCam.SetActive (true);
			LevelMusic.SetActive (false);
			ViewModes.SetActive (false);
			FinishMusic.Play ();
			GlobalCash.TotalCash += 100;
			PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
			StartCoroutine(ReturnMenu());
		}
	}
	
	IEnumerator ReturnMenu(){
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene (1);
	}
	
}
