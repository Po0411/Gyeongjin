using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Number : MonoBehaviour
{

    public float delay_time_num;
    float delay_time;
    RaycastHit hit;
    public float max_distance = 10f;

    public void Update()
    {
        delay_time -= Time.deltaTime;//시간초  고치기
        Debug.DrawRay(transform.position, transform.forward * max_distance, Color.red, 0.3f);//디버그용 드로우 레이
        Debug.DrawRay(transform.position, transform.forward * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * -max_distance, Color.red, 0.3f);
        if (delay_time >= 0)
        {
            Debug.Log("진입");
            Dice_Num_Chack();
        }
    }
    void Dice_Num_Chack()
    {
        if (Physics.Raycast(transform.position, transform.forward*max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground")) 
            {
                Debug.Log("숫자 4");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 3");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * -max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 5");
            }
        }
        if (Physics.Raycast(transform.position, transform.forward * -max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 1");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 6");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * -max_distance, out hit, max_distance))
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 2");
            }
        }
    }

    public void Start_count()
    {
        delay_time = delay_time_num;
        Debug.Log("시간초 초기화");
    }
}
