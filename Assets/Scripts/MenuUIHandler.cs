using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string teamName;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void StartNew(){
        SceneManager.LoadScene(1);
    }
    public void NewName(string n)
    {
        GameManager.Instance.teamName = n;
    }
      
    
}
