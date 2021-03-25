using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    private int enemy_choose;
    //public GameObject paper_enemy, scissors_enemy, stone_enemy;
    //public GameObject paper, scissors, stone;
    public GameObject UIManager;
    public int jodge;//[0]lose [1]win [2]drow
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Winner(int choose)
    {
        GM.mode = 3;
        UIManager.GetComponent<UIManager>().JankenChoose(choose);
        //1.rock 2.paper 3.scisser
        //JankenChoose(choose);
        if (choose == 1)
        {
            choose = 3;
        }
        else
        {
            choose = choose - 1;
        }
        //find the lose
        jodge = 1;
        int i = UnityEngine.Random.Range(0, 10);
        if (i >= 1&&i<=5)
        {
            if (choose == 3)
            {
                choose = 1;
            }
            else
            {
                choose = choose + 1;
            }
            jodge = 2;
        }//Tie


        if (i == 0)
        {
            if (choose == 1)
            {
                choose = 3;
            }
            else
            {
                choose = choose - 1;
            }
            jodge = 0;
        }//enemy win
        GM.jodge = jodge;
        GM.HPcontrol(jodge);
        UIManager.GetComponent<UIManager>().JodgeShow(jodge);
        UIManager.GetComponent<UIManager>().EnemyJanken(choose);
        //EnemyJanken(choose);

    }
   

}
