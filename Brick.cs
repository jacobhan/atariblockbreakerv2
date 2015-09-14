using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
  
	public AudioClip crack;
	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public GameObject smoke;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
	// Keep track of breakable bricks
		if (isBreakable) {
			breakableCount++;
		}


