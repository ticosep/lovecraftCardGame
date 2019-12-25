using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teste : MonoBehaviour
{
    private string[] cards = new string[2] { "Occultist", "Pope" };
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.initializeCards();
    }

    private void initializeCards()
    {
        float x = 0;
        Vector3 defaultPos = new Vector3(0, 0, 0);
        for (int i = 0; i < cards.Length; i++)
        {
            GameObject prefabRef = Instantiate(cardPrefab, defaultPos, Quaternion.identity);

            x += prefabRef.GetComponent<BoxCollider2D>().bounds.size.x * i;
            Vector3 pos = new Vector3(x, 0, 0);
            prefabRef.transform.position = pos;

            var myScriptReference = prefabRef.GetComponent<CardDisplay>();
            bool loaded = myScriptReference.loadAsset(cards[i]);
        }
    }
}
