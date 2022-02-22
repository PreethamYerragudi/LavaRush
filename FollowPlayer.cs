using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
    private Vector3 CameraPos;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = Player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
