using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;

    public FloatData dataObj;
    
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        imageObj.fillAmount = dataObj.value;
    }
}