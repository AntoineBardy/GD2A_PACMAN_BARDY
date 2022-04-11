using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiManager : MonoBehaviour
{
    [SerializeField] private GameObject[] phantomPrefab;
    private SpawnPattern<GameObject> spawnLogic;
    [SerializeField] private GameObject phantomCanva;

    public void PickDifficulty(int difficulty)
    {
        if (difficulty == 0)
        {
            spawnLogic = new SpawnFacile();
            SpawnPhantom();
        }

        else if (difficulty == 1)
        {
            spawnLogic = new SpawnMoyen();
            SpawnPhantom();
        }

        else if (difficulty == 2)
        {
            spawnLogic = new SpawnDifficile();
            SpawnPhantom();
        }

        else
        {
            Debug.Log("Unknown Difficulty");
        }
    }

    private void SpawnPhantom()
    {
        spawnLogic.SpawnLogic(phantomPrefab, phantomCanva);
    }

}

