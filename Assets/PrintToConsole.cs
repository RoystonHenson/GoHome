using UnityEngine;
using System.Collections;

public class PrintToConsole : MonoBehaviour {

	public Vector2 playerLocation = new Vector2(8.0f, 7.0f);
	public Vector2 playerHome = new Vector2(0.0f, 0.0f);
	Vector2 distanceToHome;

	// Use this for initialization
	void Start () {
		distanceToHome = playerHome - playerLocation;
		print ("Welcome to \"Find Your Way Home!\"");
		print ("You have woken up after a crazy night out");
		print("and now need to find your way home.");
		print("Location: " + playerLocation);
		print("Distance to home: " + distanceToHome.magnitude);

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			playerLocation = playerLocation + new Vector2(1.0f, 0);
			print("Location: " + playerLocation);
			print("You have chosen to move up one");
			distanceToHome = playerHome - playerLocation;
			print("Distance from home: " + distanceToHome);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			playerLocation = playerLocation + new Vector2(-1.0f, 0);
			print("Location: " + playerLocation);
			print("You have chosen to move down one");
			distanceToHome = playerHome - playerLocation;
			print("Distance from home: " + distanceToHome);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			playerLocation = playerLocation + new Vector2(0, -1.0f);
			print("Location: " + playerLocation);
			print("You have chosen to move left one");
			distanceToHome = playerHome - playerLocation;
			print("Distance from home: " + distanceToHome);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			playerLocation = playerLocation + new Vector2(0, 1.0f);
			print("Location: " + playerLocation);
			print("You have chosen to move right one");
			distanceToHome = playerHome - playerLocation;
			print("Distance from home: " + distanceToHome);
		}
		if (playerLocation == playerHome) {
		print("Congratulations!! You made it home!!");
		}
	}
}
