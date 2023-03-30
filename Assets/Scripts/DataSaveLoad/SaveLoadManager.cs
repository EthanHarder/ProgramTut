using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SaveLoadManager : MonoBehaviour
{
    [SerializeField]
    private string fileName;
    [Tooltip("Name of the save file.")]

    private FileManip fileWork;
    private SaveFileInfo saveFileInfo;




    private void NewGame()
    {
        saveFileInfo = new SaveFileInfo(); //create default save file.
    }

    public void LoadGame()
    {
        if (fileWork == null)
            fileWork = new FileManip(Application.persistentDataPath, fileName);
        saveFileInfo = fileWork.Load();

            if (this.saveFileInfo == null)
            {
                Debug.Log("No data was found! Initializing data to defaults.");
                NewGame();
            }

        Overmind._manager.tiM.externalUpdateTime(saveFileInfo.timer);
        PlayerSingleton.pInstance.pTransform.position = saveFileInfo.playerPos;
            Debug.Log("Loaded Time = " + saveFileInfo.timer);
    }

    public void SaveGame()
    {
        saveFileInfo.playerPos = PlayerSingleton.pInstance.pTransform.position;
        saveFileInfo.timer = Overmind._manager.tiM.currentTime;
        fileWork.Save(saveFileInfo);

        Debug.Log("Saved Time = " + saveFileInfo.timer);
    }


    public void DestroySaveData()
    {
        fileWork.Delete();
    }


}
