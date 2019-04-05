using UnityEngine;

[RequireComponent(typeof (RectTransform))]
public class MoveAcceleration : MonoBehaviour
{
    [SerializeField]
    private bool m_InvertDir = false;
    
    [SerializeField]
    public Vector2 RangeX = new Vector2(-10,10);
    [SerializeField]
    public Vector2 RangeY = new Vector2(-10, 10);

    [SerializeField]
    private float m_Speed = 90f;
    [SerializeField]
	private float m_Sensitive = 5;
    [SerializeField]
    private RectTransform m_Rect;

    private float X;
    private float Y;
    private int dir = 1;

	void Start()
	{
       Initialize();
	}

	void Update()
	{
        Processing();
    }

    private void Initialize() 
    {
        if(!m_Rect)
		  m_Rect = GetComponent<RectTransform>();

	   if (m_InvertDir)
	       dir = -1;
    }

    private void Processing()
    {
#if UNITY_EDITOR
	    X = Input.GetAxis("Horizontal") * m_Speed;
	    Y = Input.GetAxis("Vertical") * m_Speed;
#else
        X = Input.acceleration.x*90;
		Y = Input.acceleration.y*90;
#endif
        var xPos = Mathf.Clamp(m_Rect.localPosition.x + dir*X, RangeX.x, RangeX.y);
		var yPos = Mathf.Clamp(m_Rect.localPosition.y + dir*Y, RangeY.x, RangeY.y);

		//rect.localPosition = new Vector3(xPos,yPos);
		m_Rect.localPosition = Vector3.Slerp(m_Rect.localPosition, new Vector3(xPos, yPos), Time.deltaTime * m_Sensitive);
    }

}

