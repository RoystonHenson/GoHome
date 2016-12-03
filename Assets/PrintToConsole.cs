using UnityEngine;
using System.Collections;

public class PrintToConsole : MonoBehaviour {

	public Vector2 playerLocation = new Vector2(8.0f, 7.0f);
	public Vector2 playerHome = new Vector2(0.0f, 0.0f);
	Vector2 distanceToHome;

	// Use this for initialization
	void Start() {
		distanceToHome = playerHome - playerLocation;
		print("Welcome to \"Find Your Way Home!\"");
		print("You have woken up after a crazy night out");
		print("and now need to find your way home.");
		print("Your location: " + playerLocation);
		print("Distance to your home: " + distanceToHome.magnitude)
	}

	// Update is called once per frame
	void Update() {
		checkPLayerLocation (KeyCode.UpArrow, new Vector2(1.0f, 0));
		checkPLayerLocation (KeyCode.DownArrow, new Vector2(-1.0f, 0));
		checkPLayerLocation (KeyCode.LeftArrow, new Vector2(0, -1.0f));
		checkPLayerLocation (KeyCode.RightArrow, new Vector2(0, 1.0f));
	}

	void checkPLayerLocation(KeyCode kc, Vector2 movementVector) {
		if(Input.GetKeyDown(kc)) {
			playerLocation = playerLocation + movementVector;
			print("Your location: " + playerLocation);
			distanceToHome = playerHome - playerLocation;
			print("Distance from your home: " + distanceToHome);
		}
		if(playerLocation == playerHome) {
		print("Congratulations!! You made it home!!");
		}
	}
}
