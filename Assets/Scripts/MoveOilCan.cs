using UnityEngine;

public class FuelMovement : MonoBehaviour
{
    public float fallSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.back * (fallSpeed * Time.deltaTime));

        if (transform.position.z < -16f)
        {
            Destroy(gameObject);
        }
    }
}
