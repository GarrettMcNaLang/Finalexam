using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(0, 0, 2) * Time.deltaTime;
    }
    
}