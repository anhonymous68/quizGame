using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Dictionary<string, string> data;
    public GameObject[] key = new GameObject[4];
    public GameObject[] value = new GameObject[4];

    void Start()
    {
        data = new Dictionary<string, string>();
        data.Add("Student", "A person who is studying at a school or college");
        data.Add("Teacher", "A person who teaches, especially in a school");
        data.Add("Lawyer", "A person who practices or studies law; an attorney or a counselor");
        data.Add("Doctor", "A qualified practitioner of medicine; a physician");
        int index = 0;
        foreach (KeyValuePair<string, string> i in data)
        {
            key[index].GetComponent<Text>().text = i.Key;
            value[index].GetComponent<Text>().text = i.Value;
            index++;


        }

    }
    
    

}
