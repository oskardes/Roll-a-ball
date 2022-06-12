using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreTextHendler : MonoBehaviour
{
    private GameObject player;
    public Text score_Text;
    [SerializeField] private GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        score_Text = GameObject.FindGameObjectWithTag("Score").GetComponent<UnityEngine.UI.Text>();
        score_Text.color = Color.red;
        player.GetComponent<MovementController>().pickupEvent += UpdateText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateText()
    {
        score_Text.text = "Wynik: " + player.GetComponent<MovementController>().score + "/" + GameManager.GetComponent<GameManager>().maxScore;
    }
}
