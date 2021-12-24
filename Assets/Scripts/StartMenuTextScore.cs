using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartMenuTextScore : MonoBehaviour
{

    string bestScore = "Best Score: ";

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().text = bestScore + GameManager.Instance.bestPlayer + ": " + GameManager.Instance.bestScore;
    }

    // Update is called once per frame

}
