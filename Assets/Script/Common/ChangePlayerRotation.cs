using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerRotation : MonoBehaviour
{
    public Vector3 rotation;
    private PlayerGenerator generator;

    // Start is called before the first frame update
    void Start()
    {
        generator = gameObject.GetComponent<PlayerGenerator>();
        generator.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
