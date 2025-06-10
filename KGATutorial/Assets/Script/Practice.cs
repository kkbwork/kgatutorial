using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Practice : MonoBehaviour
{

    void Start()


    {
        Debug.Log("���� ���Դϴ�.");

        //1.����
        int level = 5;
        float strength = 15.5f;
        string playerName = "���";
        bool isFullLevel = false;

        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ���� ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");
        items.Add("������20");

        items.RemoveAt(0);

        Debug.Log("���� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.14f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������ ��û��!";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        bool isEndTutorial = level < 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

        int health = 30;
        int mana = 15;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

        string condition = isBadCondition ? "����" : "����";

        //4. Ű����

        //5. ���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� ������ ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");

        }
    }
}
