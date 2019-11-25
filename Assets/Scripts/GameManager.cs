using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreBoard;
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        scoreBoard.text = "Score: " + score.ToString();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
