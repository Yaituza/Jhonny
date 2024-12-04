using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
  static public bool found = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "JohnLemon")
        {
            found = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        found = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
