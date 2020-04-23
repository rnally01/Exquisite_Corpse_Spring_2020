using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		//this loads the next scene in the build
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		//quits the game
		Application.Quit();
		Debug.Log ("Goodbye!");
	}
}