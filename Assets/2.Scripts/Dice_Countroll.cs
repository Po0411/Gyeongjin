using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Countroll : MonoBehaviour
{
    public GameObject dice1;
    public GameObject dice2;

    public void Onclick()
    {
        Dice_Shoot();
    }
    public void Dice_Shoot()
    {
        Vector3 speed = new Vector3(500, 500, 500);//주사위가 받는 힘

        dice1.transform.position = new Vector3(-30, 10, -32.5f);//주사위가 잘 던져지게 위치이동
        dice1.transform.rotation = Quaternion.Euler(Random.Range(0.0f,30f), Random.Range(0.0f, 30f), Random.Range(0.0f, 30f));//주사위를 랜덤으로 회전시킨다.
        dice1.GetComponent<Rigidbody>().AddForce(speed);//주사위의 리지드바디에 힘을 줌

        dice2.transform.position = new Vector3(-30, 11, -32.5f);
        dice2.transform.rotation = Quaternion.Euler(Random.Range(0.0f, 30f), Random.Range(0.0f, 30f), Random.Range(0.0f, 30f));
        dice2.GetComponent<Rigidbody>().AddForce(speed);
    }
}
