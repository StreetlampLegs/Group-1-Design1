using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour

{
		
		public void PlayIntro()
		{
			SceneManager.LoadScene(1);
			//Cursor.lockState = CursorLockMode.None;
		}
		public void PlayGame ()
		{
			SceneManager.LoadScene(2);
			//Cursor.lockState = CursorLockMode.None;
    }


		public void QuitGame ()
		{
			Debug.Log("QUIT!");
			Application.Quit();
		}
	
}
