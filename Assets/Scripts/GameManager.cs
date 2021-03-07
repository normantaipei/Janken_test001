using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int mode;
    public GameObject MainCam,UIManager;
    public int jodge;
    private int hp=1000,enemy_hp=1000;
    public GameObject HP, Enemy_HP;

    void Start()
    {
        mode = 1;
    }

    // Update is called once per frame
    void Update()
    {

        MainCam.GetComponent<CameraMove>().mode = mode;
        UIManager.GetComponent<UIManager>().mode = mode;
        HP.GetComponent<Text>().text = hp.ToString();
        Enemy_HP.GetComponent<Text>().text = enemy_hp.ToString();
    }
    public void FightMode()
    {
        mode = 2;
    }
    public void AttackMode()
    {
        mode = 3;
    }
    public void HPcontrol(int jodge)
    {
        if (jodge == 0)
        {
            hp = hp - 10;
        }else if (jodge == 1)
        {
            enemy_hp = enemy_hp - 10;
        }else if (jodge == 2)
        {
            enemy_hp = enemy_hp - 5;
            hp = hp - 5;
        }
    }
    public void OnApplicationQuit()
    {
        UnityEngine.Application.Quit();
    }
}
