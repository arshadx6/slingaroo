using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class bashscript : MonoBehaviour
{   public GameObject arCamera;
    public GameObject smoke;
    public AudioSource aud;

 
    public int displayScore;

    public Text scoreUI;
    void Start()
 {

     displayScore = 0;
     
 }
    public void shoot(){
        aud.Play();
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward, out hit) ){
            if(hit.transform.name=="ball"){
                displayScore++;
                scoreUI.text = displayScore.ToString(); 
                Destroy(hit.transform.gameObject);
                Instantiate(smoke);
                if(displayScore==10){
                    scoreUI.text="You won!";
                    SceneManager.LoadScene("Won");
                }
            }
        }
    }
}
