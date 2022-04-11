using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SpawnPattern<T>
{
    void SpawnLogic(T[] PhantomList, T parent);
}
