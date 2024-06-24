using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Number : MonoBehaviour
{

    public float delay_time_num;//������ �ִ밪
    float delay_time;//���� üũ ������
    RaycastHit hit;
    public float max_distance ;//ray �ִ� ����
    bool count_start=false; //ī��Ʈ�� �����ߴ��� üũ

    public void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * max_distance, Color.red, 0.3f);//����׿� ��ο� ����
        Debug.DrawRay(transform.position, transform.forward * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * -max_distance, Color.red, 0.3f);
        if(count_start)//������ ī��Ʈ ����
        {
            delay_time -= Time.deltaTime;
        }
        if (delay_time <= 0)//�����̰� 0 ���ϸ�
        {
            Dice_Num_Chack();// ���� üũ ����
        }
    }
    void Dice_Num_Chack()
    {
        if (Physics.Raycast(transform.position, transform.forward*max_distance, out hit, max_distance))//������Ʈ�� �����̸� ���� 4
        {
            if (hit.collider.transform.CompareTag("ground")) 
            {
                Debug.Log("���� 4");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * max_distance, out hit, max_distance))//������Ʈ�� �������̸� ���� 3
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("���� 3");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * -max_distance, out hit, max_distance))//������Ʈ�� �����̸� ���� 5
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("���� 5");
            }
        }
        if (Physics.Raycast(transform.position, transform.forward * -max_distance, out hit, max_distance))//������Ʈ�� �����̸� ���� 1
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("���� 1");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * max_distance, out hit, max_distance))//������Ʈ�� �����̸� ���� 6
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("���� 6");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * -max_distance, out hit, max_distance))//������Ʈ�� �Ʒ����̸� ���� 2
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("���� 2");
            }
        }
    }

    private void Start()
    {
        delay_time = delay_time_num;
    }

    public void Start_count()
    {  
        count_start = true;
        delay_time = delay_time_num;
        Debug.Log("�ð��� �ʱ�ȭ");
    }
}
