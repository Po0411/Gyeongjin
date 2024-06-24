using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Number : MonoBehaviour
{

    public float delay_time_num;//딜레이 최대값
    float delay_time;//숫자 체크 딜레이
    RaycastHit hit;
    public float max_distance ;//ray 최대 길이
    bool count_start=false; //카운트가 시작했는지 체크

    public void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * max_distance, Color.red, 0.3f);//디버그용 드로우 레이
        Debug.DrawRay(transform.position, transform.forward * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.right * -max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * max_distance, Color.red, 0.3f);
        Debug.DrawRay(transform.position, transform.up * -max_distance, Color.red, 0.3f);
        if(count_start)//딜레이 카운트 시작
        {
            delay_time -= Time.deltaTime;
        }
        if (delay_time <= 0)//딜레이가 0 이하면
        {
            Dice_Num_Chack();// 숫자 체크 시작
        }
    }
    void Dice_Num_Chack()
    {
        if (Physics.Raycast(transform.position, transform.forward*max_distance, out hit, max_distance))//오브젝트의 앞쪽이면 숫자 4
        {
            if (hit.collider.transform.CompareTag("ground")) 
            {
                Debug.Log("숫자 4");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * max_distance, out hit, max_distance))//오브젝트의 오른쪽이면 숫자 3
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 3");
            }
        }
        if (Physics.Raycast(transform.position, transform.right * -max_distance, out hit, max_distance))//오브젝트의 왼쪽이면 숫자 5
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 5");
            }
        }
        if (Physics.Raycast(transform.position, transform.forward * -max_distance, out hit, max_distance))//오브젝트의 뒷쪽이면 숫자 1
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 1");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * max_distance, out hit, max_distance))//오브젝트의 위쪽이면 숫자 6
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 6");
            }
        }
        if (Physics.Raycast(transform.position, transform.up * -max_distance, out hit, max_distance))//오브젝트의 아래쪽이면 숫자 2
        {
            if (hit.collider.transform.CompareTag("ground"))
            {
                Debug.Log("숫자 2");
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
        Debug.Log("시간초 초기화");
    }
}
