using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody rb;

    private float deSpawnValue;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, -speed);

        deSpawnValue = -10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < deSpawnValue)
        {
            Destroy(this.gameObject);
        }
    }
}
