using UnityEngine;
using UnityEngine.UI;


public class CrosshairController : MonoBehaviour
{

    public Image crosshair;


    public void SetSpread(float value)
    {
        crosshair.rectTransform.sizeDelta =
            new Vector2(
                20 + value,
                20 + value
            );
    }



    public void HitMarker()
    {
        crosshair.color =
            Color.red;


        Invoke(
            nameof(ResetColor),
            .1f
        );
    }



    void ResetColor()
    {
        crosshair.color =
            Color.white;
    }

}
