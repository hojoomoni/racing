using UnityEngine;

public class RoadScroll : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    private Material roadMaterial;

    void Start()
    {
        roadMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        roadMaterial.mainTextureOffset = new Vector2(0, -offset);
    }
}