using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float minpo;
    public float maxpo;
    public float inc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move ()
    {
if(Input.GetKeyDown(KeyCode.D))
{
    transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpo, maxpo),transform.position.y, transform.position.z); 
}
else if(Input.GetKeyDown(KeyCode.A))
{
    transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpo, maxpo),transform.position.y, transform.position.z);
}
    }
}
