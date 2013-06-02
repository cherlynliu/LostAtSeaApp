using UnityEngine;
using System.Collections;

public class boxController : MonoBehaviour {
    public bool isKilled = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isKilled) Destroy(this);
	}
}
