using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestroyTest : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

        DeatroySlefSecond();

    }

    // Update is called once per frame

    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * 1);

    }

    private void DeatroySlefSecond()
    {

        Destroy(transform.gameObject, 90);

    }

}
