using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoBetButtons : MonoBehaviour
{
    [SerializeField]
    int autobetCount;
    [SerializeField]
    Button button;
    [SerializeField]
    GameManager gameManager;

    private void Start()
    {
        button.onClick.AddListener(onButtonClick);
    }

    void onButtonClick()
    {
        Debug.Log(autobetCount);
        gameManager.autoBetTotalCount = autobetCount;
        for (int i = 0; i < gameManager.autoButtons.Count; i++)
        {
            gameManager.autoButtons[i].button.interactable = true;
        }
        button.interactable = false;
    }
}
