using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLimit : MonoBehaviour
{
    public float timeLeft = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
