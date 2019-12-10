using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager INS;
    // Platforms
    public bool spawnPlat;
    // UI 
    public Text points;
    public int totPoints;
    void Start()
    {
        INS = this;
        //UI
        totPoints = 0;
        points.text = "Puntos: "+ totPoints.ToString("000");
    }

    void Update()
    {
        
    }
    public void Points()
    {
        totPoints=totPoints + 1;
        points.text = "Puntos: " + totPoints.ToString("000");
    }
    public void GameOver()
    {

    }

}
