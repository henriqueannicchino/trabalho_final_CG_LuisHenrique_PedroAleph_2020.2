using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfFlagTrig;

	void OnTriggerEnter (){
		LapCompleteTrig.SetActive (true);
		HalfFlagTrig.SetActive (false);
	}
}
