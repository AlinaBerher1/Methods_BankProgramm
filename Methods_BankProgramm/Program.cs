class Task2
{
    /* Задание 2
Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент 
кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен 
выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 
300 и 400 грн. закрыть весь долг. 
Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную 
экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма задолженности, 
сумма переплаты, сообщение об отсутствии долга).  */

    static void CreditState (int amount)
    {
        do
        {
            if (amount == 700)
            {
                Console.WriteLine("There is no debt");
                break;
            }
            else if (amount > 700)
            {
                int result = amount - 700;
                Console.WriteLine("Overpayment amount is " + result);
                break;
            }
            else if (amount < 700)
            {
                int result1 = 700 - amount;
                Console.WriteLine("Debt amount is " + result1);
                break;
            }
        }
        while (amount <= 700);
    }
    static void Main()
    {
        int amount = 0;
        do
        {
            Console.WriteLine("Please enter the payment amount:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 100)
            {
                Console.WriteLine("Minimum payment amount is 100 USD");
            }
            else
            {
                amount = amount + x;
                CreditState(amount);
            }
        }
        while (amount <= 700);
    }
}