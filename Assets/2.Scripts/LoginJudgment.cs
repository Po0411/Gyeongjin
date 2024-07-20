using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using BackEnd;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement; // 알지?

public class LoginJudgment : MonoBehaviour
{
    public string Scene; // 유니티 창에서 씬 이름 입력 >> 로비씬으로 이동.

    public void Login_(string id, string pw)
    {
        var bro = Backend.BMember.CustomLogin(id, pw);
        if (bro.IsSuccess()) // 로그인을 판단하여 성공 했으면 로비로 씬으로 이동.
        {
            Debug.Log("로그인이 성공했습니다. : " + bro);
            SceneManager.LoadScene(Scene); // 입력 씬으로 이동
        }
    }
}
