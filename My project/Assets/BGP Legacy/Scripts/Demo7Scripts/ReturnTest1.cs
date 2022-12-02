using UnityEngine;

namespace AD1020
{

    public class ReturnTest1 : MonoBehaviour
    {
        private int b;

        void Start()
        {
            MathMethod();

            if (IsOnShortList("Thom York"))
                Debug.Log("Welcome in!");
            else
                Debug.Log("Wait in line.");

            if (IsOnShortList("Gordon Freeman"))
                Debug.Log("Wake up, Mr. Freeman.");
            else
                Debug.Log("Wait in line.");

            MyRefFunction(ref b);
            Debug.Log(b);

        }

        //Value return type.
        void MathMethod()
        {
            AddTwoNumbers();

            SquareANumber();
        }
            int AddTwoNumbers(int number1 = 5, int number2 = 10)
            {
                return number1 + number2;
            }

            int SquareANumber(int number = 9)
            {
                return number * number;
            }

        //Playing around with returns.
        bool IsOnShortList(string name)
        {
            return name == "Gordon Freeman" || name == "Elmer Fudd" || name == "Pickle Rick";
        }

        //Ref return.
        void MyRefFunction(ref int a, int b = 5)
        {
            Debug.Log("Sum: " + (a + b));
            a = 10;

            AddValue(a);

            SubstractValue(ref b);

            }
            int AddValue(int a)
            {
                a += a;
                Debug.Log("Using regular value, a = " + a);
                return a;
            }
            int SubstractValue(ref int b)
            {
                b -= b;
                Debug.Log("Using ref variable, b = " + b);
                return b;


        }
    }
}
