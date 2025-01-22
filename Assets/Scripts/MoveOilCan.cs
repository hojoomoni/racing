using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveOilCan : MonoBehaviour
{
    public OilManager oilManager;
    public float fallSpeed = 9.5f;

    private void Start()
    {
        oilManager = FindObjectOfType<OilManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.back * (fallSpeed * Time.deltaTime));

        if (transform.position.z < -16f)
        {
            Destroy(gameObject);
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            oilManager.oil += oilManager.oilIncrease;
            if (oilManager.oil > 1000f)
            {
                oilManager.oil = 1000f;
            }

            Destroy(gameObject);
        }
    }
}
