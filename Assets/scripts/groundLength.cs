using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundLength : MonoBehaviour
{
    public movemet mv;

    // Start is called before the first frame update
    void Start()
    {
        
      
    } 

    // Update is called once per frame
    void Update()
    {   
        if(mv.enabled == true)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + 10);
           
        }
        
    }
}
