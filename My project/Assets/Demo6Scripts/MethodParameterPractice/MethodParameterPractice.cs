using System;
using UnityEngine;

namespace AD1020
{
    public class MethodParameterPractice : MonoBehaviour
{

    private float circleArea;

    private void Start()
    {
            //0. Attach this script to an object in your scene, and run to see the results

            // Write your code here
            GreeterFunction("Jeremy");
            // 1. Call the GreeterFunction with your own name as the parameter


            // 2. Call the CalculateCircleArea with your chosen parameter value, and save the 
            // RETURN value to the circleArea variable
            circleArea = CalculateCircleArea(12f);


            // 3. Call the PrintCircleAreaValue
            PrintCircleAreaValue();


            // 4. Call the CheckForCircleDiameter, and WITHIN the parameter-field,
            // call CalculateCircleDiameter with the parameter of 5f
            CheckForCircleDiameter(CalculateCircleDiameter(5f));


            //5. If you did everything correctly, you should see 3 Debug.Logs from this script
            // Example:
            // "Fair winds and hello, Jere!"
            // "The area of the circle is 78,53982."
            // "Your circle has the correct diameter. You may pass."
        }

    private void GreeterFunction(string name)
    {
        Debug.Log("Fair winds and hello, " + name + "!");
    }

    private void PrintCircleAreaValue()
    {
        Debug.Log("The area of the circle is " + circleArea + ".");
    }

    private float CalculateCircleArea(float radius)
    {
        return Mathf.PI * Mathf.Pow(radius, 2);
    }

    private float CalculateCircleDiameter(float radius)
    {
        return radius * 2;
    }

    private void CheckForCircleDiameter(float diameter)
    {
        if (Convert.ToInt32(diameter) == 10)
        {
            Debug.Log("Your circle has the correct diameter. You may pass.");
        }
        else
        {
            Debug.Log("Your circle has the wrong diameter! You shall not pass!");
        }
    }

}

}
