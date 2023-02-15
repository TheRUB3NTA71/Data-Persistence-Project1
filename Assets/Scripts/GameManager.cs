using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    public string teamName;
    public string highName;
    public int point;
    public static GameManager Instance;


   private void Awake(){
        if(Instance != null){
        Destroy(gameObject);
        return;
        }
        Instance=this;
        DontDestroyOnLoad(gameObject);
   }
   
   [System.Serializable]
    class SaveData{

      public string HiScoreName;
      public int HiScorePoint;
     
   }
    public void SaveHiscore(){

         SaveData data = new SaveData();
         data.HiScoreName = teamName;
         data.HiScorePoint = point;
         string json = JsonUtility.ToJson(data);
         File.WriteAllText(Application.persistentDataPath + "/savefile.json",json);
    }

    public void LoadHiscore(){
        string loadPath = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(loadPath)){
            string json = File.ReadAllText(loadPath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highName = data.HiScoreName;
            point = data.HiScorePoint;
        }
    }


}
