using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text cardName;
    public Text description;

    public Text attack;
    public Text life;
    public Text insanity;

    public Image artWork;


    // Start is called before the first frame update
    void Start()
    {
        cardName.text = card.cardName;
        description.text = card.description;

        life.text = card.life.ToString();
        attack.text = card.attack.ToString();
        insanity.text = card.insanity.ToString();

        artWork.sprite = card.artWork;

    }

}
