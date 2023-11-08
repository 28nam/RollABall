using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static FirstScript;

public class FirstScript : MonoBehaviour
{
    int number;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");
        number = 151;
        Debug.Log(number);

        //Person
        Person person = new Person();

        person.Name = "ナム";

        Debug.Log(person.Name); 

        person.Name = "";

        Debug.Log(person.Name);

        person.Name = null;

        Debug.Log(person.Name);

        //Rectangle
        Rectangle rectangle = new Rectangle();

        rectangle.Width = 100;
        rectangle.Height = 200;

        Debug.Log(rectangle.Area);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Updateテスト");
    }
    public class Person
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty || value == null)
                {
                    return;
                }

                _name = value;
            }
        }
    }

    public class Rectangle
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public float Area
        {
            get { return Width * Height; }
        }
    }
}
