using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public bool autoPlay = false;
 	public float minX, maxX;
 
  	private Ball ball;
  	
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
