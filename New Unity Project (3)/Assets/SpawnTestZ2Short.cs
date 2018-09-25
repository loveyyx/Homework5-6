using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTestZ2Short : MonoBehaviour
{

    private float timerOne = 4f;

    private float timeOne = 4.0f;

    private float timerWave = 0f;

    private float timeWave = 10.0f;

    private int countPerWave = 1;

    public GameObject spawnPerfab;

    private Vector3[] PrePosition = { new Vector3(-17.03f, 0.5f, 22.34f), new Vector3(-9.22f, 0.5f, 22.34f)};

    // Update is called once per frame

    void Update()
    {

        timerWave += Time.deltaTime;

        if (timerWave < timeWave && countPerWave != 5)
        {

            timerOne += Time.deltaTime;

            if (timerOne > timeOne)
            {
                int num = Random.Range(0,1);

                Instantiate(spawnPerfab, PrePosition[num],

                    Quaternion.Euler(0f, 180f, 0f));

                timerOne -= timeOne;

            }

        }

        if (timerWave >= timeWave)
        {

            timerWave -= timeWave;

        }

    }

}
