using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text scoreText;
    private float score; // pakai float karena nyesuaiin Time.deltatime

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null && !GameManager.isGameOver)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
    public float Score
    {
        get { return score; }
    }
}
