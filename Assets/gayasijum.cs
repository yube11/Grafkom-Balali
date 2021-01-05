using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gayasijum : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rigidbody2d;
	public int health = 3;
    public Text healthDisplay;
    
    void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		healthDisplay.text = health.ToString();
		
		if(health <=0){
			SceneManager.LoadScene("anda gagal");
			}
	
			if (Input.GetKeyDown(KeyCode.Space)){
			  
				float jumpVelocity = 50f;
				rigidbody2d.velocity = Vector2.up * jumpVelocity;
		
			}    
		}
    }

