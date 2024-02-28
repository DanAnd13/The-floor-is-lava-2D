using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Position;
    public Vector3 Finish = new Vector3(16.46f, -1.7f, -0.04868884f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 16.46f & transform.position.y <= -1.7f)
        {
            transform.position = Finish;
        }
        else
        {
            transform.position += Position;
        }
    }
}
