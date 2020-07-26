using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{ public float speed; 
  public Text countText;

  private Rigidbody2D rb2d;
  private int count;
  public Text WinText;

  void Start(){
  	  rb2d = GetComponent<Rigidbody2D> ();
	  count = 0;
	  WinText.text = "";
	  SetCountText ();
  }

void FixedUpdate() {
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");
	Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
	rb2d.AddForce (movement * speed);

}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("PickUp"))
		{	other.gameObject.SetActive(false);
			count = count+5;
			SetCountText();

		}
	}

	void SetCountText() {
	countText.text = "Count: " + count.ToString();
	if (count>=80){
		WinText.text = "YOU WIN";
	}
	
	}

}
