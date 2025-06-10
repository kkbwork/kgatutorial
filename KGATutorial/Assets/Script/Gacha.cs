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

        string[] urCharacters = { "Ƽġ��", "�Ƴ��̽�", "�ж�" };
        string[] srCharacters = { "����", "������", "��ü" };
        string[] rCharacters = { "��þ�", "�ú���", "����" };
        string[] nCharacters = { "�ξƹ̴�", "������", "�ַ̼�" };

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

        string result = $"{grade} ��� - {character} ȹ��!";
        Debug.Log("�̱� ���: " + result);

    }
    
        
}