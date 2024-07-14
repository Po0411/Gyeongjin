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
        var bro = Backend.Initialize(true); // �ڳ� �ʱ�ȭ

        if (bro.IsSuccess())
        {
            Debug.Log("�ʱ�ȭ ���� : " + bro); // ������ ��� statusCode 204 Success
        }
        else
        {
            Debug.LogError("�ʱ�ȭ ���� : " + bro); // ������ ��� statusCode 400�� ���� �߻�
        }
    }

    public void Member_button() // ȸ������ �Լ�
    {
        Debug.Log(inputField_ID.text);
        Debug.Log(inputField_PW.text);

        Member();
    }

    public void Login_button() // �α��� �Լ�
    {
        Debug.Log(inputField_ID.text);
        Debug.Log(inputField_PW.text);

        Login();
    }

    async void Member() // Member_button ���� �Ǹ� ȸ�������� �޴´�.
    {
        await Task.Run(() => {
            BackendLogin.Instance.CustomSignUp(inputField_ID.text, inputField_PW.text); // [�߰�] �ڳ� ȸ������ �Լ�
            Debug.Log("�׽�Ʈ�� �����մϴ�.");
        });
    }

    async void Login() // Login_button ���� �Ǹ� ���̵�� ����� ������ �α����� �˴ϴ�.
    {
        await Task.Run(() => {
            BackendLogin.Instance.CustomLogin(inputField_ID.text, inputField_PW.text); // [�߰�] �ڳ� ȸ������ �Լ�
            Debug.Log("�׽�Ʈ�� �����մϴ�.");
        });
    }
}