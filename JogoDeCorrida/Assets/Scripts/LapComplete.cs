using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfFlafTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	public GameObject LapCounter;
	public int LapsDone;

	public float RawTime;
	public int firstLap = 1;

	public GameObject RaceFinish;

	void Update () {
		if (LapsDone == 2) {
			RaceFinish.SetActive (true);
		}
	}
	
	void OnTriggerEnter (){
		LapsDone++;
		
		if (LapTimeManager.RawTime < RawTime || firstLap==1) {
			firstLap=0;
			
			if (LapTimeManager.SecondCount <= 9) {
				SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
			} else {
				SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
			}

			if (LapTimeManager.MinuteCount <= 9) {
				MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
			} else {
				MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
			}

			MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount;
			
			RawTime = LapTimeManager.RawTime;
		
		}

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.RawTime = 0;
		LapCounter.GetComponent<Text> ().text = "" + LapsDone;

		HalfFlafTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);

	}
}
