using UnityEngine;

public class ParalaxBorder : MonoBehaviour {
    
    public Vector2 XRange = new Vector2(-0.01f,0.01f);
    public Vector2 YRange = new Vector2(-0.01f,0.01f);

    private float Speed = 1f;

    private float curX = 0;
    private float curY = 0;
    
    private SpriteRenderer renderer;
    private void Awake() {
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        curX = x * Time.deltaTime;
        curY = y * Time.deltaTime;
        curX = Mathf.Clamp(curX, XRange.x, XRange.y);
        curY = Mathf.Clamp(curY, YRange.x, YRange.y);

        Debug.Log(curX+" "+curY);
//Debug.Log(new Vector4(curX,curY,0,0));
       renderer.material.SetVector("_Scale", new Vector4(curX,curY,0,0));
    }
}