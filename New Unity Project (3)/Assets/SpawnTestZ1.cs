using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTestZ1 : MonoBehaviour
{

    private float timerOne = 4f;

    private float timeOne = 4.0f;

    private float timerWave = 0f;

    private float timeWave = 10.0f;

    private int countPerWave = 1;

    public GameObject spawnPerfab;

    private Vector3[] PrePosition ={ new Vector3(27.8f, 0.5f, -64.56f), new Vector3(16.69f, 0.5f, -64.56f), new Vector3(4.27f, 0.5f, -64.56f), new Vector3(-37.19f, 0.5f, -64.56f), new Vector3(-55.73f, 0.5f, -64.56f)};

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

                    Quaternion.Euler(0f, 0f, 0f));

                timerOne -= timeOne;

            }

        }

        if (timerWave >= timeWave)
        {

            timerWave -= timeWave;

        }

    }

}