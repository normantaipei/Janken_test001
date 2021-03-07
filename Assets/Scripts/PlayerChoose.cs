using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerChoose : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)    //滑鼠移入
    {
        character.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)    //滑鼠移出
    {
        character.SetActive(false);
    }
}
