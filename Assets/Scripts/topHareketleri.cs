using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class topHareketleri : MonoBehaviour
{
    public Rigidbody2D top;
    public float xHizi, yHizi;
    public TextMeshProUGUI player2_yazi, player1_yazi, kazanan_yazi, bitisYazi;
    int player1Score, player2Score;
    private int maxScore=2;
    public AudioSource skor_sesi, kazanmaSesi;

    
    void Update()
    {
        player1_yazi.text=player1Score.ToString();
        player2_yazi.text=player2Score.ToString();

        if(Time.timeScale ==0 && Input.GetKeyDown (KeyCode.Return)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale=1;
            }
        }

    void OnCollisionEnter2D(Collision2D temas){

        if(temas.gameObject.tag=="player1"){
            top.velocity = new Vector2(-xHizi, Random.Range(-3f,3f));
        }

        else if(temas.gameObject.tag=="player2"){
            top.velocity = new Vector2(xHizi, Random.Range(-3f,3f));
        }

        if(temas.gameObject.tag=="ustDuvar"){
            top.velocity = new Vector2(top.velocity.x, -yHizi);
        }

        if(temas.gameObject.tag=="altDuvar"){
            top.velocity = new Vector2(top.velocity.x, yHizi);
        }

        if(temas.gameObject.tag=="solDuvar"){
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            player1Score++;
            skor_sesi.Play();
            transform.position = new Vector2(-5.52f,0f);
        }

        else if(temas.gameObject.tag=="sagDuvar"){
            player2Score++;
            skor_sesi.Play();
            transform.position = new Vector2(5.52f,0f);
        }

        if(player1Score==maxScore){
                kazanan_yazi.text= "Player 1 Win"; 
                bitisYazi.text="Tekrar Oynamak İçin Enter Basınız";
                kazanmaSesi.Play();
                Time.timeScale=0;
        }
        else if(player2Score==maxScore){
            kazanan_yazi.text="Player2 Win";
            bitisYazi.text="Tekrar Oynamak İçin Enter Basınız";
            kazanmaSesi.Play();
            Time.timeScale=0;
        }
    }   
}
