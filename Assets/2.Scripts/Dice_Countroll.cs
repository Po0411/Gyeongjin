using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Countroll : MonoBehaviour
{
    public GameObject dice1;
    public GameObject dice2;
    public float delay_time_num;
    float delay_time;

    public void Onclick()
    {
        if (delay_time <= 0)
        {
            Dice_Shoot();
            delay_time = delay_time_num;
        }

    }
    public void Dice_Shoot()
    {
        Vector3 speed = new Vector3(500, 500, 500);//�ֻ����� �޴� ��

        dice1.transform.position = new Vector3(-30, 10, -32.5f);//�ֻ����� �� �������� ��ġ�̵�
        dice1.transform.rotation = Quaternion.Euler(Random.Range(0.0f,30f), Random.Range(0.0f, 30f), Random.Range(0.0f, 30f));//�ֻ����� �������� ȸ����Ų��.
        dice1.GetComponent<Rigidbody>().AddForce(speed);//�ֻ����� ������ٵ� ���� ��

        dice2.transform.position = new Vector3(-30, 11, -32.5f);
        dice2.transform.rotation = Quaternion.Euler(Random.Range(0.0f, 30f), Random.Range(0.0f, 30f), Random.Range(0.0f, 30f));
        dice2.GetComponent<Rigidbody>().AddForce(speed);
    }
    public void Update()
    {
        delay_time-= Time.deltaTime;
        if (delay_time <= 0)
            Debug.Log("�ֻ��� �Ϸ�");
    }
}
