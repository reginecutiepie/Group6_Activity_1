using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class gamehandlerscript : MonoBehaviour
{
    public GameObject player1HPUI;
    public GameObject player2HPUI;
    public int playerOneHP = 100;
    public int playerTwoHP = 100;
    public GameObject rawAtk;
    public VideoPlayer vpObject;
    public VideoPlayer vpSkill;
    public VideoClip lowPunch1, highPunch1, lowKick1, highKick1, special1;
    public VideoClip lowPunch2, highPunch2, lowKick2, highKick2, special2;
    public VideoClip mlowPunch1, mhighPunch1, mlowKick1, mhighKick1;
    public VideoClip mlowPunch2, mhighPunch2, mlowKick2, mhighKick2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = playerOneHP + "";
        player2HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = playerTwoHP + "";
    }

    public void dealDamage(int damage, int playerHP, int playerNum){
        if (playerNum == 1)
        {
            playerHP -= damage;
            playerTwoHP = playerHP;
            Debug.Log("Attack succesfull");
        }

        else
        {
            playerHP -= damage;
            playerOneHP = playerHP;
            Debug.Log("Attack succesfull");
        }
    }

    public IEnumerator delayPress(int playerNum, int attackNum, int accuracy){
        int x = Random.Range(0,100);
        if (x <= accuracy)
        {
            if (playerNum == 1)
            {
                switch (attackNum)
                {
                    case 1:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    dealDamage(3, playerTwoHP, 1);
                    break;
                    
                    case 2:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    dealDamage(8, playerTwoHP, 1);
                    break;

                    case 3:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    dealDamage(6, playerTwoHP, 1);
                    break;

                    case 4:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    dealDamage(12, playerTwoHP, 1);
                    break;

                    case 5:
                    yield return new WaitForSeconds(0.35f);                 
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(5);
                    rawAtk.SetActive(false);
                    dealDamage(25, playerTwoHP, 1);
                    break;
                }
            }
            else{
                switch (attackNum)
                {
                    case 1:
                    yield return new WaitForSeconds(0.35f);                
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    dealDamage(3, playerOneHP, 2);
                    break;
                    
                    case 2:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    dealDamage(8, playerOneHP, 2);
                    break;

                    case 3:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    dealDamage(6, playerOneHP, 2);
                    break;

                    case 4:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    dealDamage(12, playerOneHP, 2);
                    break;

                    case 5:
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(5);
                    rawAtk.SetActive(false);
                    dealDamage(25, playerOneHP, 2);
                    break;
                }
            }
        }else
        {
            if (playerNum == 1)
            {
                switch (attackNum)
                {
                    case 1:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mlowPunch1;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    
                    break;
                    
                    case 2:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mhighPunch1;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    break;

                    case 3:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mlowKick1;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    break;

                    case 4:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mhighKick1;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    break;
                }
            }
            else
            {
                switch (attackNum)
                {
                    case 1:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mlowPunch2;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    break;
                    
                    case 2:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mhighPunch2;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    break;

                    case 3:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mlowKick2;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAtk.SetActive(false);
                    break;

                    case 4:
                    vpSkill.gameObject.GetComponent<VideoPlayer>().clip = mhighKick2;
                    vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    rawAtk.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAtk.SetActive(false);
                    break;
                }
            }
        }
    }
    public void lowPunchP1(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = lowPunch1;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,1,75));
        
    }

    public void highPunchP1(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = highPunch1;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,2,55));
    }

    public void lowKickP1(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = lowKick1;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,3,65));
    }
    public void highKickP1(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = highKick1;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,4,45));
    }

    public void specialP1 (){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = special1;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,5,100));
    }

    public void lowPunchP2(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = lowPunch2;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,1,75));
    }

    public void highPunchP2(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = highPunch2;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,2,55));
    }

    public void lowKickP2(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = lowKick2;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,3,65));
    }
    public void highKickP2(){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = highKick2;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,4,45));
    }

    public void specialP2 (){
        vpSkill.gameObject.GetComponent<VideoPlayer>().clip = special2;
        vpSkill.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,5,100));
    }
  
}
