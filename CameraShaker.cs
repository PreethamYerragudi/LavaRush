using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    private float Magnitude;
     private float Duration;
    public Transform Player;
    private void LateUpdate()
    {
        Vector3 Position = transform.localPosition;
        if(Duration>0)
        {
            Duration -= Time.deltaTime;
            float x = Random.Range(-1f, 1f)* Magnitude;
            float y = Random.Range(-1f, 1f)* Magnitude;
            transform.position += new Vector3(x, y, 0);
        }
        else
        {
            transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
        }

        
    }
    public void Shake(float Dur, float Mag)
    {
        Duration = Dur;
        Magnitude = Mag;
    }
}
