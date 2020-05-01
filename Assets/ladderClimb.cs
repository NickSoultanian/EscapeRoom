using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderClimb : MonoBehaviour
{
    public float speed = 6; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerStay(Collider other)
        {
            if (other.tag == "Player" && Input.GetKey (KeyCode.E))
            {
                other.GetComponent<Rigidbody> ().velocity = new Vector3 (0, speed);
            }
            else
            {
                other.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 1);
            }
        }
}
