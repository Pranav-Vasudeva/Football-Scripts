using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource bounceSound;
	  public AudioSource mtlSound;
    public AudioSource dribble;

    



    void OnCollisionEnter(Collision col) {
	

		if (col.gameObject.tag == "Ground") {

			bounceSound.Play();

      print("bounce");

		}


		

    }

     void OnCollision(Collision col) {


    
    if (col.gameObject.tag == "Pole") {

			mtlSound.Play();

      print("Pole");

		}

    void OnCollision(Collision col) {  


    
    if (col.gameObject.tag == "Player") {

			dribble.Play();

      print("Hit");

  }

 }

     }

}


