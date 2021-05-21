using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject follow;
    public Vector2 mincampo, maxcampo;
    public float smooth;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        float posx=Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smooth);
        float posy=Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smooth);
        transform.position = new Vector3(
            Mathf.Clamp(posx, mincampo.x, maxcampo.x),
            Mathf.Clamp(posy, mincampo.y, maxcampo.y)+0.15f,
            transform.position.z
        );
    }
}
