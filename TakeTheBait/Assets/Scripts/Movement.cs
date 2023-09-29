using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void MoveTransform(Vector3 vel){
        transform.position += vel;
    }
}
