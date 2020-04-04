using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    bool gameended = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void end()
    {
        if (gameended == false) 
        {
            gameended = true;
            Debug.Log("game over");

            Invoke("Restart", 2f);
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("level01");
    }
}
