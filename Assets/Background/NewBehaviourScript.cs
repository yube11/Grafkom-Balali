using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    public float endx;
    public float startx;
    
    // Update is called once per frame
    private void Update()
    {
			transform.Translate(Vector2.left*speed*Time.deltaTime);
			
			if (transform.position.x <= endx){
				Vector2 pos = new Vector2(startx, transform.position.y);
				transform.position = pos;
				}
    }
}
