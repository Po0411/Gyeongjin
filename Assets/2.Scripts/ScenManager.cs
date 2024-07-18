using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ����?

public class ScenManager : MonoBehaviour
{
    public string Scene; // ����Ƽ â���� �� �̸� �Է�

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾� �±� ������ Ȯ���ϰ� �̵�
        {
            Debug.Log("�÷��̾ ����������" + Scene + "(��)�� �̵� �߽��ϴ�"); // �ܼ�â���� Ȯ��
            SceneManager.LoadScene(Scene); // �Է� ������ �̵�
        }
    }

    public void Scene_Button()
    {
        SceneManager.LoadScene(Scene); // �Է� ������ �̵�
    }
}
