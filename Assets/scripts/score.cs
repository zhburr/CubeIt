using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public movemet mv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mv.enabled == true || player.position.y > 1)
        {
            scoreText.text = player.position.z.ToString("0");
        }
       
        
    }
}
