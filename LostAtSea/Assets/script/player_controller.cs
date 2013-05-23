using UnityEngine;
using System.Collections;

public class player_controller : MonoBehaviour {
    public Transform BoatAndPlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S)) BoatAndPlayer.transform.Translate(0, 0, -5 * Time.deltaTime);
        if (Input.GetKey(KeyCode.W)) BoatAndPlayer.transform.Translate(0, 0, 7.5f * Time.deltaTime);
        //if (Input.GetKeyDown(KeyCode.A)) BoatAndPlayer.transform.Translate(-15 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A)) BoatAndPlayer.transform.Rotate(0, -30 * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.D)) BoatAndPlayer.transform.Rotate(0, 30 * Time.deltaTime, 0);
	}
}
