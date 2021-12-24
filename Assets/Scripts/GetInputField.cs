using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetInputField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        input.onEndEdit.AddListener(ChangePlayerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangePlayerName(string val){
        GameManager.Instance.playerName = val;
        //Debug.Log(GameManager.Instance.playerName);
    }
}
