using UnityEngine;
using System.Collections;

public class PrintToConsole : MonoBehaviour {

	public Vector2 playerLocation = new Vector2(8.0f, 7.0f);
	public Vector2 playerHome = new Vector2(0.0f, 0.0f);
	Vector2 distanceToHome;

	// Use this for initialization
	void Start() {
		distanceToHome = playerHome - playerLocation;
		WelcomeMessage();
		DisplayLocation();
	}

	// Update is called once per frame
	void Update() {
		CheckPLayerLocation(KeyCode.UpArrow, new Vector2(1.0f, 0));
		CheckPLayerLocation(KeyCode.DownArrow, new Vector2(-1.0f, 0));
		CheckPLayerLocation(KeyCode.LeftArrow, new Vector2(0, -1.0f));
		CheckPLayerLocation(KeyCode.RightArrow, new Vector2(0, 1.0f));
	}

	void CheckPLayerLocation(KeyCode kc, Vector2 movementVector) {
		if(Input.GetKeyDown(kc)) {
			playerLocation = playerLocation + movementVector;
			distanceToHome = playerHome - playerLocation;
			DisplayLocation();
		}
		if(playerLocation == playerHome) {
		print("Congratulations!! You made it home!!");
		}
	}

	void WelcomeMessage() {
		print("Welcome to \"Find Your Way Home!\"");
		print("You have woken up after a crazy night out");
		print("and now need to find your way home.");
	}

	void DisplayLocation() {
		print("Your location: " + playerLocation);
		print("Distance from your home: " + distanceToHome.magnitude);
	}
}
