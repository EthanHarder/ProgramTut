using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.Playables;

public class FileManip
{
    private string dataDirect;
    private string dataFileName;
    public FileManip(string dataDirect, string dataFileName)
    {
        this.dataDirect = dataDirect;
        this.dataFileName = dataFileName;
    }

    public SaveFileInfo Load()
    {
        string filePath = Path.Combine(dataDirect, dataFileName);
        SaveFileInfo loadedData = null;

        if (File.Exists(filePath))
        {
            try
            {
                string dataTemp;
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataTemp = reader.ReadToEnd();
                    }
                }

                loadedData = JsonUtility.FromJson<SaveFileInfo>(dataTemp);
            }

            catch (Exception e)
            {
                Debug.LogError("File Load Data Error, Check: " + filePath + "\n" + e);
            }
        }

        return loadedData;
    }

    public void Save(SaveFileInfo data)
    {
        string filePath = Path.Combine(dataDirect, dataFileName);

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            string dataToStore = JsonUtility.ToJson(data, true);

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError("File Save Data Error, Check: " + filePath + "\n" + e);
        }
    }

    public void Delete()
    {
        string filePath = Path.Combine(dataDirect, dataFileName);
        File.Delete(filePath);
        Debug.Log("Delete Attempt");
    }
}
