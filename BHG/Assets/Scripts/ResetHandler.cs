
using System.Collections.Generic;
using UnityEngine;

public class ResetHandler : MonoBehaviour
{
    private List<ResetScript> resetList = new List<ResetScript>();

    public void resetAll()
    {
        if (resetList.Count > 0)
        foreach (var resetScript in resetList)
        {
            resetScript.ResetToDefault();
        }
    }

    public void AddtoResetList(ResetScript resetScript)
    {
        resetList.Add(resetScript);
    }
}
