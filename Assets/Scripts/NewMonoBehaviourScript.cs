using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
     public int myAddOne;
     public int myAddTwo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(myAddOne=addNumbers(myAddOne, myAddTwo));
    }
    
    public int addNumbers (int addenOne, int addenTwo) {
    int sum = addenOne + addenTwo;
    return sum;
    }
}
