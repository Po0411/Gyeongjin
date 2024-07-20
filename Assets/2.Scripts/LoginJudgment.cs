using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using BackEnd;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement; // ����?

public class LoginJudgment : MonoBehaviour
{
    public string Scene; // ����Ƽ â���� �� �̸� �Է� >> �κ������ �̵�.

    public void Login_(string id, string pw)
    {
        var bro = Backend.BMember.CustomLogin(id, pw);
        if (bro.IsSuccess()) // �α����� �Ǵ��Ͽ� ���� ������ �κ�� ������ �̵�.
        {
            Debug.Log("�α����� �����߽��ϴ�. : " + bro);
            SceneManager.LoadScene(Scene); // �Է� ������ �̵�
        }
    }
}
