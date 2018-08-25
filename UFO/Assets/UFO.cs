using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour {
    public static float Score = 0;
    public float movespeed = 2f;
    public float ufox, ufoz;
    public Vector3 ufopos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Score <20)
        {
            this.transform.localScale = new Vector3(0.6f, 0.0125f, 0.6f);
        }
        else if (Score < 100)
        {
            this.transform.localScale = new Vector3(1.8f, 0.0375f, 1.8f);
            movespeed = 4f;
        }
        else if (Score <200)
        {
            this.transform.localScale = new Vector3(3.6f, 0.075f, 3.6f);
            movespeed = 8f;
        }
        else 
        {
            this.transform.localScale = new Vector3(7.2f, 0.15f, 7.2f);
            movespeed = 16f;
        }
        float MoveH = Input.GetAxis("Horizontal");
        float MoveV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveH, 0, MoveV) *Time.deltaTime*movespeed);    //按水平或者垂直的方向键,就怎么移动

        Vector3 worldpro = this.transform.TransformPoint(this.transform.localPosition);
        ufox = this.transform.localPosition.x;
        ufoz = this.transform.localPosition.z;
        ufopos = this.transform.localPosition;
    }

    private void OnGUI()
    {
        GUIStyle time = new GUIStyle();
        time.normal.textColor = new Color(1, 0, 1);
        time.fontSize = 50;
        GUI.Label(new Rect(0, 0, 100, 30), "分数：" + Score,time);
    }

}
