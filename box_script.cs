using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_script : MonoBehaviour
{
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        score = score + 1000; 
        print("Плюс очко" + score + "$");
        Destroy(gameObject);
    
}

}
