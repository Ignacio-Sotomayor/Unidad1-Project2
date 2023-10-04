using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerSpin : MonoBehaviour
{

    //atributes
    private float SpinSpeed = 1000f;

    // Update is called once per frame
    void Update(){
        transform.Rotate( Vector3.forward * SpinSpeed * Time.deltaTime);
    }
}
