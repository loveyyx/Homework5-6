using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer1 : MonoBehaviour {

    //计时
    int timeLeft = 200;
    void Start()
    {
        //开启协程
        StartCoroutine(Count());
    }


    //倒计时
    IEnumerator Count()
    {
        while (timeLeft >= 0)
        {
            print("还剩：" + timeLeft + "秒。。。");
            //暂停1秒
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
        GameOver();
        
    }
    private void OnGUI()
    {
        GUIStyle time = new GUIStyle();
        time.normal.textColor = new Color(1,0,0);
        time.fontSize = 50;
        if (timeLeft>0)
        {
            GUI.Label(new Rect(800, 0, 200, 60), "还剩：" + timeLeft + "秒。。。", time);
        }
        else
        {
            GUI.Label(new Rect(800, 0, 200, 60), "Gameover", time);
        }
    }

    //协程结束后处理
    void GameOver()
    {

         Application.Quit();
    }
}
