using UnityEngine;
using System.Collections;

public class PrintToConsole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float playerLocation = 5.0f;	// Distance in meters
		float playerHome = -1.0f;
		float distance = playerHome - playerLocation;
		print ("Welcome to \"Find Your Way Home!\"");
		print ("You have woken up after a crazy night out");
		print("and now need to find your way home.");
		print("Location: " + playerLocation);
		print("Distance: " + distance);
		if (playerLocation > playerHome) {
			print("Go backwards!");
		}
		if (playerLocation < playerHome) {
			print("Go forwards!");
		}
		if (playerLocation == playerHome) {
		print("Congradulations!! You made it home!!");
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print("Up key pressed");
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			print("Down key pressed");
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			print("Left key pressed");
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			print("Right key pressed");
		}
	}
}
