using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public string playerName;

    public string bestPlayer = "";
    public int points = 0;

    public int bestScore = 0;
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        LoadPlayer();
    }

    public void SavePlayer()
    {
        Player data = new Player(playerName, points);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", json);

    }
    public void LoadPlayer()
    {
        try
        {
            string json = File.ReadAllText(Application.dataPath + "/data.json");
            Player data = JsonUtility.FromJson<Player>(json);
            bestPlayer = data.name;
            bestScore = data.points;
        }
        catch
        {
            return;
        }

    }

    public void CheckBestPlayer()
    {
        if (points > bestScore)
        {
            bestScore = points;
            bestPlayer = playerName;
        }
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}

[System.Serializable]
class Player
{
    public string name;
    public int points;
    public Player(string name, int points)
    {
        this.name = name;
        this.points = points;
    }
}