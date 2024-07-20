using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ��ȯ�� ���� �ʿ�
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
        Debug.Log("ȸ�������� ��û�մϴ�.");

        var bro = Backend.BMember.CustomSignUp(id, pw);

        yield return null; // �鿣�� ��û�� �Ϸ�� ������ ���

        if (bro.IsSuccess())
        {
            Debug.Log("ȸ�����Կ� �����߽��ϴ�. : " + bro);
            SceneManager.LoadScene("Game_UI"); // ȸ������ ���� �� "Game_UI"���� ��ȯ
        }
        else
        {
            Debug.LogError("ȸ�����Կ� �����߽��ϴ�. : " + bro);
        }
    }

    public IEnumerator CustomLogin(string id, string pw)
    {
        Debug.Log("�α����� ��û�մϴ�.");

        var bro = Backend.BMember.CustomLogin(id, pw);

        yield return null; // �鿣�� ��û�� �Ϸ�� ������ ���

        if (bro.IsSuccess())
        {
            Debug.Log("�α����� �����߽��ϴ�. : " + bro);
            SceneManager.LoadScene("Game_UI"); // �α��� ���� �� "Game_UI"���� ��ȯ
        }
        else
        {
            Debug.LogError("�α����� �����߽��ϴ�. : " + bro);
        }
    }
}
