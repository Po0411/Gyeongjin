using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

        StartCoroutine(Member());
    }

    public void Login_button() // �α��� �Լ�
    {
        Debug.Log(inputField_ID.text);
        Debug.Log(inputField_PW.text);

        StartCoroutine(Login());
    }

    IEnumerator Member() // Member_button ���� �Ǹ� ȸ�������� �޴´�.
    {
        yield return StartCoroutine(BackendLogin.Instance.CustomSignUp(inputField_ID.text, inputField_PW.text));
    }

    IEnumerator Login() // Login_button ���� �Ǹ� ���̵�� ����� ������ �α����� �˴ϴ�.
    {
        yield return StartCoroutine(BackendLogin.Instance.CustomLogin(inputField_ID.text, inputField_PW.text));
    }
}
