using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTestZ2 : MonoBehaviour
{

    private float timerOne = 4f;

    private float timeOne =4.0f;

    private float timerWave = 0f;

    private float timeWave = 10.0f;

    private int countPerWave = 1;

    public GameObject spawnPerfab;

    private Vector3[] PrePosition = { new Vector3(-56.17f, 0.5f, 22f), new Vector3(-37.7f, 0.5f, 22f),new Vector3(3.86f, 0.5f, 22f), new Vector3(16.19f, 0.5f, 22f), new Vector3(27.27f, 0.5f, 22f) };

    // Update is called once per frame

    void Update()
    {

        timerWave += Time.deltaTime;

        if (timerWave < timeWave && countPerWave != 5)
        {

            timerOne += Time.deltaTime;

            if (timerOne > timeOne)
            {
                int num = Random.Range(0, 4);

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
