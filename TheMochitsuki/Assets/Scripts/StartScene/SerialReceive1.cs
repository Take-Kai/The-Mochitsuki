using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SerialReceive1 : MonoBehaviour
{
    public SerialHandler1 serialHandler1;

  void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler1.OnDataReceived += OnDataReceived;
    }

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\n" }, System.StringSplitOptions.None);
    try
    {
        if(message[0] == 'U')   //臼のU
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    /* H8マイコン用
        try
        {
            Debug.Log(data[0]);//Unityのコンソールに受信データを表示
            SceneManager.LoadScene("SampleScene");
        }
    */
        
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);//エラーを表示
        }
    }
}
