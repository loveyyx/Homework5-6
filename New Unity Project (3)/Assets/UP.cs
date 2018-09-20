using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP : MonoBehaviour {

    public Rigidbody rb;
    float ufox, ufoz,x,z;
    float force = 1;
    Vector3 ufopos, objpos,direction;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    {
        ufox =GameObject.Find("Cylinder"). GetComponent<UFO>().ufox;
        ufoz = GameObject.Find("Cylinder").GetComponent<UFO>().ufoz;
        x = this.transform.localPosition.x;
        z = this.transform.localPosition.z;  
        double distance = System.Math.Sqrt((ufox - x) * (ufox - x) + (ufoz - z) * (ufoz - z));//物体与飞碟的平面距离
        Debug.Log("" + distance);
        if (UFO.Score < 20)
        {
            if (distance < 0.4)
            {
                ufopos = GameObject.Find("Cylinder").GetComponent<UFO>().ufopos;
                objpos = this.transform.localPosition;
                direction = ufopos - objpos;//计算物体与飞碟之间的方向关系
                direction.Normalize();
                rb.AddForce(direction*force*1.5f);//给物体添加力
            }
        }
        else if (UFO.Score < 100)
        {
            if (distance < 1)
            {
                if (GetComponent<Rigidbody>().mass <= 0.5) force = GetComponent<Rigidbody>().mass * 10;
                else force = 5;
                ufopos = GameObject.Find("Cylinder").GetComponent<UFO>().ufopos;
                objpos = this.transform.localPosition;
                direction = ufopos - objpos;
                direction.Normalize();
                rb.AddForce(direction * force*1.5f);
            }
        }
        else if (UFO.Score < 200)
        {
            if (distance < 2)
            {
                if (GetComponent<Rigidbody>().mass <= 2.5) force = GetComponent<Rigidbody>().mass * 10;
                else force = 25;
                ufopos = GameObject.Find("Cylinder").GetComponent<UFO>().ufopos;
                objpos = this.transform.localPosition;
                direction = ufopos - objpos;
                direction.Normalize();
                rb.AddForce(direction * force*1.5f);
            }
        }
        else 
        {
            if (distance < 5)
            {
                if (GetComponent<Rigidbody>().mass <= 12.5) force = GetComponent<Rigidbody>().mass * 10;
                else force = 125;
                ufopos = GameObject.Find("Cylinder").GetComponent<UFO>().ufopos;
                objpos = this.transform.localPosition;
                direction = ufopos - objpos;
                direction.Normalize();
                rb.AddForce(direction * force*1.5f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)//吞噬后增加分数
    {
        float mass = GetComponent<Rigidbody>().mass;
        UFO.Score += (mass*10);
        Destroy(gameObject);
    }
}
