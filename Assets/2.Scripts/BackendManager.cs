using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using BackEnd;
using TMPro;
using UnityEngine.UI;

public class BackendManager : MonoBehaviour
{
    public TMP_InputField inputField_ID;
    public TMP_InputField inputField_PW;

    void Start()
    {
        var bro = Backend.Initialize(true); // 뒤끝 초기화

        if (bro.IsSuccess())
        {
            Debug.Log("초기화 성공 : " + bro); // 성공일 경우 statusCode 204 Success
        }
        else
        {
            Debug.LogError("초기화 실패 : " + bro); // 실패일 경우 statusCode 400대 에러 발생
        }
    }

    public void Member_button() // 회원가입 함수
    {
        Debug.Log(inputField_ID.text);
        Debug.Log(inputField_PW.text);

        Member();
    }

    public void Login_button() // 로그인 함수
    {
        Debug.Log(inputField_ID.text);
        Debug.Log(inputField_PW.text);

        Login();
    }

    // 동기 함수를 비동기에서 호출하게 해주는 함수(유니티 UI 접근 불가)
    async void Member()
    {
        await Task.Run(() => {
            BackendLogin.Instance.CustomSignUp(inputField_ID.text, inputField_PW.text); // [추가] 뒤끝 회원가입 함수
            Debug.Log("테스트를 종료합니다.");
        });
    }

    async void Login()
    {
        await Task.Run(() => {
            BackendLogin.Instance.CustomLogin(inputField_ID.text, inputField_PW.text); // [추가] 뒤끝 회원가입 함수
            Debug.Log("테스트를 종료합니다.");
        });
    }
}