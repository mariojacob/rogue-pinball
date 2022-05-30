using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelXData", menuName = "ScriptableObjects/Level Data")]
public class LevelData : ScriptableObject, ISerializationCallbackReceiver
{
    [System.NonSerialized]
    public int runtimeScore;
    public int initialScore = 0;
    public string sceneName;

    public void OnAfterDeserialize()
    {
        ResetRuntimeValues();
    }

    public void OnBeforeSerialize()
    {

    }

    public void ResetRuntimeValues()
    {
        runtimeScore = initialScore;
    }
}
