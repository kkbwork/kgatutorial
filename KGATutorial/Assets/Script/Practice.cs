using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Practice : MonoBehaviour
{

    void Start()


    {
        Debug.Log("연습 중입니다.");

        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "용사";
        bool isFullLevel = false;

        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.Add("엘릭서20");

        items.RemoveAt(0);

        Debug.Log("소지 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.14f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "굉장히 엄청난!";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level < 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        int health = 30;
        int mana = 15;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";

        //4. 키워드

        //5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 포션을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");

        }
    }
}
