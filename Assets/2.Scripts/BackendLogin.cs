using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위해 필요
using BackEnd;

public class BackendLogin
{
    private static BackendLogin _instance = null;

    public static BackendLogin Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BackendLogin();
            }

            return _instance;
        }
    }

    public IEnumerator CustomSignUp(string id, string pw)
    {
        Debug.Log("회원가입을 요청합니다.");

        var bro = Backend.BMember.CustomSignUp(id, pw);

        yield return null; // 백엔드 요청이 완료될 때까지 대기

        if (bro.IsSuccess())
        {
            Debug.Log("회원가입에 성공했습니다. : " + bro);
            SceneManager.LoadScene("Game_UI"); // 회원가입 성공 시 "Game_UI"으로 전환
        }
        else
        {
            Debug.LogError("회원가입에 실패했습니다. : " + bro);
        }
    }

    public IEnumerator CustomLogin(string id, string pw)
    {
        Debug.Log("로그인을 요청합니다.");

        var bro = Backend.BMember.CustomLogin(id, pw);

        yield return null; // 백엔드 요청이 완료될 때까지 대기

        if (bro.IsSuccess())
        {
            Debug.Log("로그인이 성공했습니다. : " + bro);
            SceneManager.LoadScene("Game_UI"); // 로그인 성공 시 "Game_UI"으로 전환
        }
        else
        {
            Debug.LogError("로그인이 실패했습니다. : " + bro);
        }
    }
}
