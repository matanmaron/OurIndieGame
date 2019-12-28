using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    // Update is called once per frame

    public float speed = 1;

    void FixedUpdate()
    {
        Vector3 diff = (Player.transform.position - Camera.transform.position);
        

        if (Mathf.Abs(diff.x) > float.Epsilon) {
            Camera.transform.position += new Vector3(diff.x*diff.x*Mathf.Sign(diff.x), 0, 0) * Time.deltaTime * speed;
        }
    }
}
