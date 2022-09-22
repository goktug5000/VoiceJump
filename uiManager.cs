using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    public Text myVoice;
    // Update is called once per frame
    void Update()
    {
        myVoice.text = player.GetComponent<ListenForAudioCommand>().db.ToString();
    }
}
