using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFileInfo
{
    public float timer;
    public Vector3 playerPos;

    public SaveFileInfo()
    {
        //Default Settings.
        
        timer = Overmind._manager.tiM.maxTime;

        playerPos = new Vector3(-3f, 0.3f, 2.5f);
    }

}
