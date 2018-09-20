using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRange : MonoBehaviour {
    public Light light;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (UFO.Score < 20) light.spotAngle = 4;
        else if(UFO.Score < 100) light.spotAngle = 12;
        else if (UFO.Score < 200) light.spotAngle = 24;
        else  light.spotAngle = 48;
    }
}
