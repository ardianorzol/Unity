using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zderzenie : MonoBehaviour
{
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    

    private void OnCollisionEnter(Collision zderzenie)
    {
        if (zderzenie.gameObject.tag == "przeszkoda")
        {
            Debug.Log("Zderzenie");
            
        }
        
    }
}
