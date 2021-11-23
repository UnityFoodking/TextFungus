using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneNumbers : MonoBehaviour, IError
{
    [SerializeField]
    private InputField _inputfield;
     private int countersNumbers = 0;
   private int lenghtNumber = 9; //длина нашего номера пример: 555-628-59

    public string ErrorText => "Номер не определён";

    public void InputNumbers(int valueNumber){
       if(_inputfield.text.Length <= lenghtNumber){
        _inputfield.text += valueNumber;
         countersNumbers++;
            if(countersNumbers % 3 == 0 )
            {
                _inputfield.text += "-";
                countersNumbers = 0;
            }
        } 
   }

   public void ClearInputNumbers(){
       _inputfield.text = "";
       countersNumbers = 0;
   }

    public void ErrorMessage()
    {
        _inputfield.text = ErrorText;
    }
}
