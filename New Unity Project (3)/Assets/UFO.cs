using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour {
    public static float Score = 0;//游戏分数
    public float movespeed = 2f;//移动速度
    public float ufox, ufoz;//获取飞碟的平面坐标
    public Vector3 ufopos;//获取飞碟的空间坐标向量
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Score <20)//第一级
        {
            this.transform.localScale = new Vector3(0.6f, 0.0125f, 0.6f);
        }
        else if (Score < 100)//第二级
        {
            this.transform.localScale = new Vector3(1.8f, 0.0375f, 1.8f);
            movespeed = 4f;
        }
        else if (Score <200)//第三级
        {
            this.transform.localScale = new Vector3(3.6f, 0.075f, 3.6f);
            movespeed = 8f;
        }
        else //第四级
        {
            this.transform.localScale = new Vector3(7.2f, 0.15f, 7.2f);
            movespeed = 16f;
        }
        float MoveH = Input.GetAxis("Horizontal");
        float MoveV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveH, 0, MoveV) *Time.deltaTime*movespeed);    //方向键控制移动

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
