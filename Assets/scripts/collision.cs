using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public movemet mv;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            mv.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           // FindObjectOfType<EndGame>().end();
        }
    }
}
