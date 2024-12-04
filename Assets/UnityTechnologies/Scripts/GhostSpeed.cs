using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpeed : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
