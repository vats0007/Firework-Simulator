using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public GameObject Fire;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    [SerializeField]
    private int spriteIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            spriteIndex = 1;
        }
        if(Input.touchCount == 0)
        {
            spriteIndex = 0;
        }
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = touch_Pos + new Vector2(-0.3f,0.5f);
            Instantiate(Fire, transform.position + new Vector3(-0.8f,0.7f,0), Quaternion.identity);
        }



        //DestroyImmediate(Fire,true);
        spriteRenderer.sprite = sprites[spriteIndex];
    }


    
}
