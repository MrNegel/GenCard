using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_Field : MonoBehaviour
{
    public Card cardinfo;
    public int idx;


    public void RefreshCard(Card cardinfo_) {
        cardinfo=cardinfo_;
        Debug.Log("Card Added! " +cardinfo.HP);
        transform.Find("HP").GetComponent<Text>().text=""+cardinfo.cur_HP;
        transform.Find("Image").GetComponent<Image>().sprite=cardinfo.icon_field;
    }

    public void OnSelect()
    {
         GameObject.Find("UIManager").GetComponent<UIManager>().Place_card(idx);
    }
}
