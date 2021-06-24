using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class incscore : MonoBehaviour
{
    [SerializeField]
    GameObject cs;
    [SerializeField]
    GameObject hs;

    // Start is called before the first frame update
    int val=0;
    GameObject p1, p2;

     void Start()
    {
        Text fin = hs.GetComponent<Text>();
        string s = "HIGH SCORE: ";
        s = s + PlayerPrefs.GetInt("maxsc",0).ToString();
        fin.text = s;
    }

    void inc()
    {
        val=val+1;
        Text fin = cs.GetComponent<Text>();
        string s = "SCORE: ";
        s = s + val.ToString();
        fin.text = s;

        if (val > PlayerPrefs.GetInt("maxsc", 0))
        {
            PlayerPrefs.SetInt("maxsc", val);
            fin = hs.GetComponent<Text>();
            s = "HIGH SCORE: ";
            s = s + val.ToString();
            fin.text = s;
        }


    }
    bool flag = true;
    // Update is called once per frame
    void Update()
    {

        p1 = GameObject.FindGameObjectWithTag("glide");
        p2 = GameObject.FindGameObjectWithTag("jump");
        GameObject[] all = GameObject.FindGameObjectsWithTag("box");
        if (p1 != null)
        {


            int cnt = 0;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].transform.position.x <= p1.transform.position.x && flag)
                {
                    inc();
                    flag = false;
                }
                else if(all[i].transform.position.x > p1.transform.position.x) cnt++;
            }
            if (cnt == all.Length) flag = true;

        }
        else if(p2!=null)
        {
            int cnt = 0;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].transform.position.x <= p2.transform.position.x && flag)
                {
                    inc();
                    flag = false;
                }
                else if(all[i].transform.position.x > p2.transform.position.x) cnt++;
            }
            if (cnt == all.Length) flag = true;
        }




    }
}
