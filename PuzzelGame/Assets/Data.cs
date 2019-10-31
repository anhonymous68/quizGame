using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Data
{ 
    public class Data : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private Dictionary<string, string> data;

        Data()
        {
            data = new Dictionary<string, string>();
            data.Add("Student", "A person who is studying at a school or college");
            data.Add("Teacher", "A person who teaches, especially in a school");
            data.Add("Lawyer", "A person who practices or studies law; an attorney or a counselor");
            data.Add("Doctor", "A qualified practitioner of medicine; a physician");
        }

        public Dictionary<string, string> getData()
        {
            return data;
        }
    }
}