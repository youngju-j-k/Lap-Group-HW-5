using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private bool ButtonPressed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonPressed)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void press()
    {
        ButtonPressed = true;
    }
}
