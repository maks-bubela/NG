using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Chain_of_Responsibility
{
    class Valuta
    {
        public Valuta next;
        public int denomination;
        public int quantity;
        private string result = "";
        private string error = "The ATM is unable to process this request.";
        public Valuta(int denomination, int quantity)
        {
            this.denomination = denomination;
            this.quantity = quantity;
        }
        public string hundler(int summ)
        {
            string check;
            for (int i = 0; i < quantity && summ - denomination >= 0; i++)
            {
                summ -= denomination;
                if ((summ - denomination < 0 || i + 1 == quantity))
                    result += (i + 1) + " : " + denomination + "\n";
            }
            if (summ != 0)
            {
                if (next != null)
                {
                    check = next.hundler(summ);
                    if (check != error)
                        result += check;
                    else
                        return error;
                }
                else
                    return error;
            }
            return result;
        }
    }
}
