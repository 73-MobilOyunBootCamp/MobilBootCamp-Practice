using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialChanger : MonoBehaviour
{

    

    

    MeshRenderer meshRenderer;
    public MeshRenderer MeshRenderer { get { return (meshRenderer == null) ? meshRenderer = GetComponent<MeshRenderer>() : meshRenderer; } }


    

    private void Update()
    {
        //if(Input.GetButtonDown("Jump"))
        
    }
}
