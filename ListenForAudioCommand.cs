using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForAudioCommand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float db;
    // Update is called once per frame
    void Update()
    {
        db = MicInput.MicLoudnessinDecibels;
        if (db > -60)
        {
            transform.Translate(10 * Time.deltaTime, 0, 0);
        }
        if (db > -30)
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
        }
    }
}
