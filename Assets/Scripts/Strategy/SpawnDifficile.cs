using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDifficile : SpawnPattern<GameObject>
{
    public void SpawnLogic(GameObject[] phantomList, GameObject parent)
    {
        for (int i = 0; i < 5; i++)
        {
            var phantom = GameObject.Instantiate(phantomList[2], parent.transform);
            phantom.transform.position += new Vector3(2 * i, 0, 0);
        }
    }
}
