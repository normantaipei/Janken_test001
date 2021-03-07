using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int mode;
    public GameObject PlayerChoose,Jonken,Jodge;
    public GameObject paper_enemy, scissors_enemy, stone_enemy;
    public GameObject paper, scissors, stone;
    public GameObject HP, Enemy_HP;
    bool PlayerChoose_bool, JonKen_bool;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            PlayerChoose.SetActive(true);
            HP.SetActive(false);
            Enemy_HP.SetActive(false);
        }
        else
        {
            PlayerChoose.SetActive(false);
        }
        if (mode == 2)
        {
            Jonken.SetActive(true);
            HP.SetActive(true);
            Enemy_HP.SetActive(true);
        }
        else
        {
            Jonken.SetActive(false);
        }
        if (mode == 3)
        {
            Jodge.SetActive(true);
            HP.SetActive(true);
            Enemy_HP.SetActive(true);
        }
        else
        {
            Jodge.SetActive(false);
            JankenChoose(0);
            EnemyJanken(0);
        }
    }
    public void JodgeShow(int jodge)
    {
        if (jodge == 1)
        {
            Jodge.GetComponent<Text>().text = "Win";
        }else if (jodge == 0)
        {
            Jodge.GetComponent<Text>().text = "Lose";
        }else if(jodge == 2)
        {
            Jodge.GetComponent<Text>().text = "Tie";
        }
    }
    public void JankenChoose(int choose)
    {
        if (choose == 1)
        {
            paper.SetActive(true);
        }
        else if (choose == 2)
        {
            scissors.SetActive(true);
        }
        else if (choose == 3)
        {
            stone.SetActive(true);
        }
        else if (choose == 0)
        {
            paper.SetActive(false);
            scissors.SetActive(false);
            stone.SetActive(false);
        }
    }
    public void EnemyJanken(int choose)
    {
        if (choose == 1)
        {
            paper_enemy.SetActive(true);
        }
        else if (choose == 2)
        {
            scissors_enemy.SetActive(true);
        }
        else if (choose == 3)
        {
            stone_enemy.SetActive(true);
        }
        else if (choose == 0)
        {
            paper_enemy.SetActive(false);
            scissors_enemy.SetActive(false);
            stone_enemy.SetActive(false);
        }
    }
}
