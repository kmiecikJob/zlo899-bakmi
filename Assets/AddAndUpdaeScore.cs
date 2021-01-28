using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddAndUpdaeScore : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private SciptableInt scoreHolder;

    private void Start()
    {

        text.text = scoreHolder.value.ToString();
    }

    public void IncreaseScore(int score)
    {
        scoreHolder.value += score;
        text.text = scoreHolder.value.ToString();
    }
}
