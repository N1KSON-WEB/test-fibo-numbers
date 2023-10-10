namespace davaleba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //momxmarebels shemoyavs fibonachis mimdevroba, ertic tu sheeshleba ititsheba
            
            int changedNumber1 = 0;
            int changedNumber2 = 0; 

            for (int i = 0; i > -1; i++)
            {
               
                int enteredNumber1 = int.Parse(Console.ReadLine());
                
                if (i == 0 && enteredNumber1 != 1)
                {
                    break;
                }
                else if (i > 0 && enteredNumber1 != changedNumber1 + changedNumber2)
                {
                    break;
                }
                int enteredNumber2 = int.Parse(Console.ReadLine());
                if (i == 0 && enteredNumber2 != 1)
                {
                    break;
                }
                else if (i > 0 && enteredNumber2 != changedNumber2 + enteredNumber1)
                {
                    break;  
                }
                changedNumber1 = enteredNumber1;
                changedNumber2 = enteredNumber2;    
                  }

        }
    }
}