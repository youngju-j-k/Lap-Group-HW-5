using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolResetter : MonoBehaviour
{
    Vector3 startPosition;
    public GameObject tool;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(tool.transform.position.x, tool.transform.position.y, tool.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void resetPosition()
    {
        tool.transform.position = startPosition;
    }
}
