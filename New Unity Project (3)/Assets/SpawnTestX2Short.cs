using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTestX2Short : MonoBehaviour
{

    private float timerOne = 4f;

    private float timeOne = 4.0f;

    private float timerWave = 0f;

    private float timeWave = 10.0f;

    private int countPerWave = 1;

    public GameObject spawnPerfab;

    private Vector3[] PrePosition = { new Vector3(-15.72f, 0.5f, -14.61f), new Vector3(-15.72f, 0.5f, 0.41f), new Vector3(-15.72f, 0.5f, 11.78f)};

    // Update is called once per frame

    void Update()
    {

        timerWave += Time.deltaTime;

        if (timerWave < timeWave && countPerWave != 5)
        {

            timerOne += Time.deltaTime;

            if (timerOne > timeOne)
            {
                int num = Random.Range(0, 2);

                Instantiate(spawnPerfab, PrePosition[num],

                    Quaternion.Euler(0f, 90f, 0f));

                timerOne -= timeOne;

            }

        }

        if (timerWave >= timeWave)
        {

            timerWave -= timeWave;

        }

    }

}
