using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour{
    

    private Vector3 offset = new Vector3(0, 4.2f, 0.08f);
    private Vector3 CameraPosition1 = new Vector3(0, 4.2f, 0.08f);
    private Vector3 CameraPosition2 = new Vector3(0, 2f, -15f);
    private Vector3 CameraPosition3 = new Vector3(0, 0f, 0f);
    
    // Update is called once per frame
    void FixedUpdate(){

        if(Input.GetKeyDown("1")){
            offset = CameraPosition1;
        }
        if(Input.GetKeyDown("2")){
            offset = CameraPosition2;
        }
        if(Input.GetKeyDown("3")){
            offset = CameraPosition3;
        }

        transform.position = offset;
        
    }
}