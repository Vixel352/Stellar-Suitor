using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planetquestions : MonoBehaviour
{
    //the number of right answers per planet
    public int venusPoints;
    public int jupiterPoints;
    public int plutoPoints;
    public int alonePoints;

    public int buttonsPushed; // keep track of how many answers we have given

    public Image template; // this is the image that will be replaced

    public Sprite question1; // these are the images that will be filled into the placeholder
    public Sprite question2; // note, these must be set to sprites within unity
    public Sprite question3;
    public Sprite question4;
    public Sprite question5;
    public Sprite question6;
    public Sprite question7;
    public Sprite question8;
    public Sprite question9;
    public Sprite question10;
    public Sprite question11;
    public Sprite question12;
    public Sprite question13;
    public Sprite question14;
    public Sprite question15;


    // Start is called before the first frame update
    void Start()
    {
        buttonsPushed = 1; //we set to one so that the numbers always match, just makes life a little easier
    }

    // Update is called once per frame
    void Update()
    {
        //each time we push a valid button(1,2,3) we switch to the next question
        if (buttonsPushed == 1)
        {
            Question1();
        }
        else if (buttonsPushed == 2)
        {
            Question2();
        }
        else if (buttonsPushed == 3)
        {
            Question3();
        }
        else if (buttonsPushed == 4)
        {
            Question4();
        }
        else if (buttonsPushed == 5)
        {
            Question5();
        }
        else if (buttonsPushed == 6)
        {
            Question6();
        }
        else if (buttonsPushed == 7)
        {
            Question7();
        }
        else if (buttonsPushed == 8)
        {
            Question8();
        }
        else if (buttonsPushed == 9)
        {
            Question9();
        }
        else if (buttonsPushed == 10)
        {
            Question10();
        }
        else if (buttonsPushed == 11)
        {
            Question11();
        }
        else if (buttonsPushed == 12)
        {
            Question12();
        }
        else if (buttonsPushed == 13)
        {
            Question13();
        }
        else if (buttonsPushed == 14)
        {
            Question14();
        }
        else if (buttonsPushed == 15)
        {
            Question15();
        }



        //Put if planetPoints = 5 here?
    }

    private void Question1()
    {
        template.sprite = question1; // change this to show different questions on screen

        int response; //these are temporary answers that refresh for each question
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question2()
    {
        template.sprite = question2;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            buttonsPushed++;
            response = 1;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question3()
    {
        template.sprite = question3;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question4()
    {
        template.sprite = question4;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    //FINAL CALCULATION CODE IS CALLED
    private void Question5()
    {
        template.sprite = question5;

        int response;
        //int tempAnswer = 3; //you can change this number each question so the right answer isn't always 2
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            venusPoints++;
            //if (tempAnswer == response)
            //{
            //jupiterPoints++;
            //}
            //FinalCalculation(); // call this after the very last question
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            jupiterPoints++;
            //if (tempAnswer == response)
            //{
            //jupiterPoints++;
            //}
            //FinalCalculation(); // call this after the very last question
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
            //if (tempAnswer == response)
            //{
            //jupiterPoints++;
            //} 
            //FinalCalculation(); // call this after the very last question
        }
    }

    private void Question6()
    {
        template.sprite = question6;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question7()
    {
        template.sprite = question7;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question8()
    {
        template.sprite = question8;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question9()
    {
        template.sprite = question9;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question10()
    {
        template.sprite = question10;

        int response;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            response = 1;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            response = 2;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            response = 3;
            alonePoints++;
        }
    }

    private void Question11()
    {
        template.sprite = question11;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            alonePoints++;
        }
    }

    private void Question12()
    {
        template.sprite = question12;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            alonePoints++;
        }
    }

    private void Question13()
    {
        template.sprite = question13;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            venusPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            alonePoints++;
        }
    }

    private void Question14()
    {
        template.sprite = question14;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            alonePoints++;
        }
    }

    private void Question15()
    {
        template.sprite = question15;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buttonsPushed++;
            plutoPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buttonsPushed++;
            jupiterPoints++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buttonsPushed++;
            alonePoints++;
        }
    }



}



/*private void FinalCalculation()
{
    int mostPoints = Mathf.Max(venusPoints, jupiterPoints, plutoPoints, alonePoints);
    Debug.Log(mostPoints);
}
}*/