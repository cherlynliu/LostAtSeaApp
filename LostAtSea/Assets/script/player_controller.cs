using UnityEngine;
using System.Collections;

public class player_controller : MonoBehaviour {
    public Transform BoatAndPlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.S)) BoatAndPlayer.transform.Translate(0, 0, -15 * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.A)) BoatAndPlayer.transform.Translate(-15 * Time.deltaTime, 0, 0);
        if (Input.GetKeyUp(KeyCode.D)) BoatAndPlayer.transform.Translate(15 * Time.deltaTime, 0, 0);
        if (Input.GetKeyUp(KeyCode.W)) BoatAndPlayer.transform.Translate(0, 0, 15 * Time.deltaTime);
	}
}
