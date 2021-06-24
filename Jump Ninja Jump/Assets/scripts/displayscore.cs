using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayscore : MonoBehaviour
{
    [SerializeField]
    GameObject cs;
    [SerializeField]
    GameObject hs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject score = GameObject.FindGameObjectWithTag("score");
        GameObject h_score = GameObject.FindGameObjectWithTag("h_score");
        Text fin = cs.GetComponent<Text>();
        Text s = score.GetComponent<Text>();
        fin.text = s.text;
        fin = hs.GetComponent<Text>();
        s = h_score.GetComponent<Text>();
        fin.text = s.text;
    }

    public void Res()
    {
        PlayerPrefs.SetInt("maxsc", 0);
        Text fin = hs.GetComponent<Text>();
        fin.text = "HIGH SCORE: 0";
    }

}
