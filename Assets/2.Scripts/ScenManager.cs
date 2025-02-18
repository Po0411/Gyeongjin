using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 알지?

public class ScenManager : MonoBehaviour
{
    public string Scene; // 유니티 창에서 씬 이름 입력

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어 태그 값으로 확인하고 이동
        {
            Debug.Log("플레이어가 정상적으로" + Scene + "(으)로 이동 했습니다"); // 콘솔창으로 확인
            SceneManager.LoadScene(Scene); // 입력 씬으로 이동
        }
    }

    public void Scene_Button()
    {
        SceneManager.LoadScene(Scene); // 입력 씬으로 이동
    }
}
