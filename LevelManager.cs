using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	 public void LoadLevel(string name) {
		Debug.Log ("New Level load: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel (name);
	}
  	
  	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
