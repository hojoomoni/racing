using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class OilManager : MonoBehaviour
{
    public TMP_Text oilText;
    public float oil = 1000f;
    public float oilDecrease = 10f;
    public float oilIncrease = 30f;

    void Start()
    {
        UpdateOil();
    }

    void Update()
    {
        oil -= oilDecrease * Time.deltaTime;
        if (oil < 0) oil = 0;

        UpdateOil();
    }

    void UpdateOil()
    {
        if (oilText != null)
        {
            oilText.text = Mathf.Floor(oil).ToString();  
        }
    }
}