using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoyen : SpawnPattern<GameObject>
{
    public void SpawnLogic(GameObject[] phantomList, GameObject parent)
    {
        for (int i = 0; i < 4; i++)
        {
            var phantom = GameObject.Instantiate(phantomList[1], parent.transform);
            phantom.transform.position += new Vector3(1 * i, 0, 0);
        }
    }
}
