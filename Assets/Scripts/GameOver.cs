using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameObject player;
    public int amountFall;
    public GameObject textAgain;
    GameObject[] cubeSet;
    [SerializeField] private GameObject[] hearts;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cubeSet = GameObject.FindGameObjectsWithTag("Kostki");
        player.GetComponent<MovementController>().checkHeight += Game_Over;
        player.GetComponent<MovementController>().LavaEnter += Game_Over;
        amountFall = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HeightUnderminus2();
        PlayAgain();
    }

    public void HeightUnderminus2()
    {
        if (player.transform.position.y < -5.0f)
        {
            TeleportToBeginning();  
        }
    }

    public void PlayAgain()
    {
        if (amountFall == 5)
        {
            textAgain.SetActive(true);
            Invoke("ReturnTo1Scene", 1.0f);
        }
    }

    private void ReturnTo1Scene()
    {
        SceneManager.LoadScene("Scena1", LoadSceneMode.Single);
    }

    private void TeleportToBeginning()
    {
        player.GetComponent<MovementController>().CheckHeight();
    }

    public void Game_Over()
    {
        player.transform.position = new Vector3(-4.58f, 0.49f, -0.21f);
        amountFall = amountFall + 1;
        hearts[amountFall-1].SetActive(false);
    }

   
}
