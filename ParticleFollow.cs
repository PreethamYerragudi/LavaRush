using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public Transform Lava;
    private Vector3 LavaPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LavaPos = new Vector3(Lava.position.x+14,LavaPos.y,transform.position.z);
        transform.position = LavaPos;
    }
}
