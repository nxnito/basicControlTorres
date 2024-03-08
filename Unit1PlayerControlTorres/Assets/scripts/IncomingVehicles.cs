using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingVehicles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move the incoming vehicles forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
