using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

	//public void PlayGame (){
	//	SceneManager.LoadScene (2);
	//}

	public void PlayGame (){
		SceneManager.LoadScene (2);
	}

	public void MainMenu (){
		SceneManager.LoadScene (1);
	}

	//abaixo esta os botoes de selecao de circuito

	public void Track01 (){
		SceneManager.LoadScene (3);
	}

	public void Track02 (){
		SceneManager.LoadScene (4);
	}

	public void Track03 (){
		SceneManager.LoadScene (5);
	}

	public void CreditsScene (){
		SceneManager.LoadScene (6);
	}

}
