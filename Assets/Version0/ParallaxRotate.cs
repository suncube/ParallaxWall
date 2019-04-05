using UnityEngine;

[RequireComponent(typeof (RectTransform))]
public class ParallaxRotate : ParallaxMove
{
    [SerializeField]
    private float m_ZStep = 50;

    protected override void Initialize()
    {
        base.Initialize();

        var paralaxItems = gameObject.GetComponentsInChildren<RectTransform>();
        //var zPos = m_ZStep * paralaxItems.Length;
        var zPos = 0f;
        for(var i = 0 ; i < paralaxItems.Length; i++)
        {
            var item = paralaxItems[i];
            item.localPosition = new Vector3(item.localPosition.x,item.localPosition.y,zPos);
            zPos += m_ZStep; 
            // zPos -= m_ZStep; 
        }
    }

    protected override void Processing()
    {
         ProcessingInput();

         var xRotate = Mathf.Clamp(m_Rect.localPosition.x + dir*X, RangeX.x, RangeX.y);
		 var yRotate = Mathf.Clamp(m_Rect.localPosition.y + dir*Y, RangeY.x, RangeY.y);

		m_Rect.localRotation = Quaternion.Slerp(m_Rect.localRotation, Quaternion.Euler(xRotate,yRotate,0),Time.deltaTime * m_Sensitive);
        //Vector3.Slerp(m_Rect.localPosition, new Vector3(xPos, yPos), Time.deltaTime * m_Sensitive);
    }

}
