using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_Group : MonoBehaviour
{
    public Card cardinfo;
    public int idx;


    public void RefreshCard(Card cardinfo_) {
        cardinfo=cardinfo_;
        transform.Find("HP").GetComponent<Text>().text=""+cardinfo.HP;
        transform.Find("cost").GetComponent<Text>().text=""+cardinfo.cost;
        transform.Find("Image").GetComponent<Image>().sprite=cardinfo.icon_deck;
    }

    public void OnSelect(){
        // call ui
        GameObject.Find("UIManager").GetComponent<UIManager>().Select_card(idx);
    }

}
