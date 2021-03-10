using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO.Ports;
using System;
using System.Threading;

public class PlayerChoose_card : MonoBehaviour
{
    public GameObject character,button01;
    public GameManager GM;

    private SerialPort arduinoStream;
    public string port="COM6";
    private Thread readThread; // 宣告執行緒
    public string readMessage;
    bool isNewMessage;

    // Start is called before the first frame update
    void Start()
    {
        if (port != "")
        {
            arduinoStream = new SerialPort(port, 9600); //指定連接埠、鮑率並實例化SerialPort
            arduinoStream.ReadTimeout = 10;
            try
            {
                arduinoStream.Open(); //開啟SerialPort連線
                readThread = new Thread(new ThreadStart(ArduinoRead)); //實例化執行緒與指派呼叫函式
                readThread.Start(); //開啟執行緒
                Debug.Log("SerialPort開啟連接");
            }
            catch
            {
                Debug.Log("SerialPort連接失敗");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isNewMessage)
        {
            if (readMessage==" 1B 28 11 23")
            {
                character.SetActive(true);
                button01.SetActive(true);
                //GM.GetComponent<GameManager>().mode=2;
                //GM.FightMode()

            }
            Debug.Log(readMessage);
        }
        isNewMessage = false;
    }
    private void ArduinoRead()
    {
        while (arduinoStream.IsOpen)
        {
            try
            {
                readMessage = arduinoStream.ReadLine(); // 讀取SerialPort資料並裝入readMessage
                isNewMessage = true;
            }
            catch (System.Exception e)
            {
                Debug.LogWarning(e.Message);
            }
        }
    }
    void OnApplicationQuit()
    {
        if (arduinoStream != null)
        {
            if (arduinoStream.IsOpen)
            {
                arduinoStream.Close();
            }
        }
    }
}
