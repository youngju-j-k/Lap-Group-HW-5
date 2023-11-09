using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MixedReality.Toolkit.SpatialManipulation;

public class toolbar_script2 : MonoBehaviour
{
    private string boneState;
    private string skinState;
    private string contrastState;
    private string colonState;
    private string moveState;
    private string toolState;

    public TextMeshProUGUI toolbarText;

    private ObjectManipulator Mover;

    public GameObject bones;
    public GameObject skin;
    public GameObject contrast;
    public GameObject colon;
    public GameObject patientModel;
    public GameObject tool;
    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        if (bones.activeInHierarchy)
        {
            boneState = "active";
        }
        else
        {
            boneState = "Inactive";
        }

        if (skin.activeInHierarchy)
        {
            skinState = "active";
        }
        else
        {
            skinState = "Inactive";
        }
        
        if (contrast.activeInHierarchy)
        {
            contrastState = "active";
        }
        else
        {
            contrastState = "Inactive";
        }
        
        if (colon.activeInHierarchy)
        {
            colonState = "active";
        }
        else
        {
            colonState = "Inactive";
        }

        if (tool.activeInHierarchy)
        {
            toolState = "active";
        }
        else
        {
            toolState = "Inactive";
        }

        Mover = patientModel.GetComponent<ObjectManipulator>();
        if (Mover.enabled)
        {
            moveState = "active";
        }
        else
        {
            moveState = "Inactive";
        }


        SetText();

    }

    void SetText()
    {
        toolbarText.text = "Bone: " + boneState + "\n" + "Skin: " + skinState + "\n" + "Contrast: " + contrastState + "\n" + "Colon: " + colonState + "\n" + "Move Patient Model: " + moveState + "\n" + "Virtual Tool: " + toolState + "\n";


    }
}
