using UnityEngine;

public class Test : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("���� �ѹ��� ����˴ϴ�.");
    }

 

    void Update()
    {
        Debug.Log("�� �����Ӹ��� ������ ����˴ϴ�.");
    }

    public class Player
    {
        private int playerLevel = 10;

        public int Level()
        {
            return playerLevel;
        }
    }

    public class Monster
    {
        private int monsterLevel;

        public void SetLevel(int _playerLevel)
        {
            monsterLevel = _playerLevel;
        }
    }

    public class Game
    {
        Player A;
        Monster B;

        void MonsterSpawn() // ����
        {
            B.SetLevel(A.Level());
        }
    }
    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }


public string myName = "�˷��ִ� �� �˾���?";
public int myAge;
public string likeNumber = "�����ϴ�.";
public string myRegion = "�����ϴ�.";
public string myTribe = "����Դϴ�.";
public int myBirthday = 0301;
public string myMBTI = "INFJ";

void Start()
{
    myAge = Random.Range(20, 61);
        Tutorial();
    }

void Tutorial()
    {
        Debug.Log("�̸���" + myName + "�̸�,");
        Debug.Log("���̴�" + myAge + "�Դϴ�.");
        Debug.Log("�����ϴ� ���ڴ�" + likeNumber);
        Debug.Log("������" + myRegion);
        Debug.Log("������" + myTribe);
        Debug.Log("������" + myBirthday + "�̸�,");
        Debug.Log("MBTI��" + myMBTI + "�Դϴ�. �Ұ� ��!");
    }
}
