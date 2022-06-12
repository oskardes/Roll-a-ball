using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    GameObject[] cube;
    public int maxScore;
    private Scene scene;
    GameObject player;
    public GameObject napisWygrana;
    public GameObject wygrana;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindGameObjectsWithTag("Kostki");
        maxScore = cube.Length;
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<MovementController>().event2 += CheckPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
            
        
    }
    private void CheckPoint()
    {
        if (player.GetComponent<MovementController>().score == maxScore)
        {
            scene = SceneManager.GetActiveScene();
            if (scene.name == "Scena1")
            {
                napisWygrana.SetActive(true);
                Invoke("ChangeSceneTo2", 2.0f);
            }
            else if (scene.name == "Scena2")
            {
                wygrana.SetActive(true);
                Invoke("ChangeSceneToEnd", 2.0f);
            }
        }
    }

   private void ChangeSceneTo2()
    {
        SceneManager.LoadScene("Scena2", LoadSceneMode.Single);
    }

    private void ChangeSceneToEnd()
    {
        SceneManager.LoadScene("Koniec", LoadSceneMode.Single);
    }
 
}
