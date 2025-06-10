using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button drawButton;
    public TMP_Text resultText;

    void Start()
    {
        drawButton.onClick.AddListener(Draw);

    }
    void Draw()
    {
        
        int rand = Random.Range(1, 101);
        string grade = "???";
        string character = "???";

        string[] urCharacters = { "티치엘", "아나이스", "밀라" };
        string[] srCharacters = { "나야", "란지에", "리체" };
        string[] rCharacters = { "루시안", "시벨린", "녹턴" };
        string[] nCharacters = { "로아미니", "조슈아", "이솔렛" };

        if (rand <= 5)
        {
            grade = "UR";
            character = urCharacters[Random.Range(0, urCharacters.Length)];
        }
        else if (rand <= 20)
        {
            grade = "SR";
            character = srCharacters[Random.Range(0, srCharacters.Length)];
        }

        else if (rand <= 50)
        {
            grade = "R";
            character = rCharacters[Random.Range(0, rCharacters.Length)];
        }
        else
        {
            grade = "N";
            character = nCharacters[Random.Range(0, nCharacters.Length)];
        }

        string result = $"{grade} 등급 - {character} 획득!";
        Debug.Log("뽑기 결과: " + result);

    }
    
        
}