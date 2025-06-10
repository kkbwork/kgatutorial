using UnityEngine;

public class Test : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

 

    void Update()
    {
        Debug.Log("매 프레임마다 여러번 실행됩니다.");
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

        void MonsterSpawn() // 몬스터
        {
            B.SetLevel(A.Level());
        }
    }
    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }


public string myName = "알려주는 줄 알았지?";
public int myAge;
public string likeNumber = "없습니다.";
public string myRegion = "없습니다.";
public string myTribe = "비밀입니다.";
public int myBirthday = 0301;
public string myMBTI = "INFJ";

void Start()
{
    myAge = Random.Range(20, 61);
        Tutorial();
    }

void Tutorial()
    {
        Debug.Log("이름은" + myName + "이며,");
        Debug.Log("나이는" + myAge + "입니다.");
        Debug.Log("좋아하는 숫자는" + likeNumber);
        Debug.Log("종교도" + myRegion);
        Debug.Log("종족은" + myTribe);
        Debug.Log("생일은" + myBirthday + "이며,");
        Debug.Log("MBTI는" + myMBTI + "입니다. 소개 끝!");
    }
}
