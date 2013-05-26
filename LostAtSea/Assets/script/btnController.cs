using UnityEngine;
using System.Collections;

public class btnController : MonoBehaviour {
    public GUISkin skin;
    Rect rect = new Rect(0, 0, 100, 100);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnGUI()
    {
        GUI.skin = skin;
        if (GUI.Button(rect, "")) print("box");
    }
}
