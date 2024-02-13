using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInterruction : MonoBehaviour
{
    public Rigidbody Capsule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

        if(triggerRight>0.9f)
        {
            Instantiate(Capsule, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
