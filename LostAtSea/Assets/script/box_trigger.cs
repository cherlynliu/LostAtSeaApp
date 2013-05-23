using UnityEngine;
using System.Collections;

public class box_trigger : MonoBehaviour {
    bool OnTriggerEnter(Collider col)
    {
        Destroy(this.gameObject, 0.25f);
        return false;
    }
	// Use this for initialization
	void Start () {
        Debug.Log(this.name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
