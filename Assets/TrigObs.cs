using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigObs : MonoBehaviour
{
	public int damage = 1;
	
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag("Jumadin"))
		{
			other.GetComponent<gayasijum>().health -= damage;
			Debug.Log(other.GetComponent<gayasijum>().health);
		}
		
	}

}
