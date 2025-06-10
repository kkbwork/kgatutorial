using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    public void Start()
    {
        Phase2();
    }
    string star;
    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }
    public void Phase2()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j < i; j++)
            {
                star += "　";  // 전각 공백 (정렬용)
            }

            for (int k = 5; k >= i; k--)
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }
}
