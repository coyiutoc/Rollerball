using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

	public class LevelChange : MonoBehaviour 
	{
		public void NextLevelButton(int index)
		{
		SceneManager.LoadScene(index, LoadSceneMode.Single);
		}
		
	}
	
