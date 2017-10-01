using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Name: Ali
 *Description: C# program that lets you calculate prime numbers. Two separate algorithms are used,
 *             one for printing all divisors and the other for finding primes as quickly as possible.
*/
namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber;
        public Thread T1;
        public Thread T2;
        public Thread T3;
        public Thread T4;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            TextOutput.Text = ("Please enter your first number.\n");

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            enteringNumbers();
        }


        public bool resultFound;
        public bool divisorFound;
        public bool totalPrimesFound;
        public bool firstNumberEntered;
        public bool secondNumberEntered;

        public List<string> primesList = new List<string>();        
        public List<int> finalPrimes = new List<int>();   
        public List<string> primesThread1 = new List<string>();
        public List<string> primesThread2 = new List<string>();
        public List<string> primesThread3 = new List<string>();
        public List<string> primesThread4 = new List<string>();

        public const int totalThreads = 4;

        public int[] firstThreadLoad;
        public int[] secondThreadLoad;
        public int[] thirdThreadLoad;
        public int[] fourthThreadLoad;


        public void findPrimes1(int[] firstThreadLoad)
        {
            int Number = 1;
            int iterate = 1;
            for (Number = firstThreadLoad[0]; Number < firstThreadLoad[1]; Number++)
            {
                bool resultFound = false;
                bool divisorFound = false;
                int fastNumber = Convert.ToInt32(Math.Ceiling(Number / 2.0));
                int lastDigit = Number % 10;
                for (iterate = 1; iterate < fastNumber + 1; iterate++)
                {
                    while ((iterate <= fastNumber && resultFound is false) || fastNumber == 1)
                    {

                        if ((divisorFound is true && iterate >= fastNumber) || lastDigit % 2 == 0 || lastDigit % 5 == 0 || lastDigit % 10 == 0)
                        {
                            resultFound = true;
                            //string primeArray = string.Join(",", primesList.ToArray());
                            //TextOutput.AppendText(Number + " is not prime\n");
                            //primesList.Clear();
                            break;
                        }
                        else if (Number % iterate == 0 && iterate != Number && iterate != 1)
                        {
                            divisorFound = true;
                            primesList.Add(Convert.ToString(iterate));
                            iterate += 1;
                        }

                        else if (divisorFound is false && iterate >= fastNumber || Number == 2)
                        {
                            resultFound = true;
                            totalPrimesFound = true;
                            primesThread1.Add(Number + " is prime.");
                            break;
                        }
                        else
                        {
                            iterate += 1;
                        }
                    }
                }
            }
        }
        
        public void findPrimes2(int[] secondThreadLoad)
        {
            int Number = 1;
            int iterate = 1;
            for (Number = secondThreadLoad[0]; Number < secondThreadLoad[1]; Number++)
            {
                bool resultFound = false;
                bool divisorFound = false;
                int fastNumber = Convert.ToInt32(Math.Ceiling(Number / 2.0));
                int lastDigit = Number % 10;
                for (iterate = 1; iterate < fastNumber + 1; iterate++)
                {
                    while ((iterate <= fastNumber && resultFound is false) || fastNumber == 1)
                    {

                        if ((divisorFound is true && iterate >= fastNumber) || lastDigit % 2 == 0 || lastDigit % 5 == 0 || lastDigit % 10 == 0)
                        {
                            resultFound = true;
                            //string primeArray = string.Join(",", primesList.ToArray());
                            //TextOutput.AppendText(Number + " is not prime\n");
                            //primesList.Clear();
                            break;
                        }
                        else if (Number % iterate == 0 && iterate != Number && iterate != 1)
                        {
                            divisorFound = true;
                            primesList.Add(Convert.ToString(iterate));
                            iterate += 1;
                        }

                        else if (divisorFound is false && iterate >= fastNumber || Number == 2)
                        {
                            resultFound = true;
                            totalPrimesFound = true;
                            primesThread2.Add(Number + " is prime.");
                            break;
                        }
                        else
                        {
                            iterate += 1;
                        }
                    }
                }
            }
        }
        public void findPrimes3(int[] thirdThreadLoad)
        {
            int Number = 1;
            int iterate = 1;
            for (Number = thirdThreadLoad[0]; Number < thirdThreadLoad[1]; Number++)
            {
                bool resultFound = false;
                bool divisorFound = false;
                int fastNumber = Convert.ToInt32(Math.Ceiling(Number / 2.0));
                int lastDigit = Number % 10;
                for (iterate = 1; iterate < fastNumber + 1; iterate++)
                {
                    while ((iterate <= fastNumber && resultFound is false) || fastNumber == 1)
                    {

                        if ((divisorFound is true && iterate >= fastNumber) || lastDigit % 2 == 0 || lastDigit % 5 == 0 || lastDigit % 10 == 0)
                        {
                            resultFound = true;
                            //string primeArray = string.Join(",", primesList.ToArray());
                            //TextOutput.AppendText(Number + " is not prime\n");
                            //primesList.Clear();
                            break;
                        }
                        else if (Number % iterate == 0 && iterate != Number && iterate != 1)
                        {
                            divisorFound = true;
                            primesList.Add(Convert.ToString(iterate));
                            iterate += 1;
                        }

                        else if (divisorFound is false && iterate >= fastNumber || Number == 2)
                        {
                            resultFound = true;
                            totalPrimesFound = true;
                            primesThread3.Add(Number + " is prime.");
                            break;
                        }
                        else
                        {
                            iterate += 1;
                        }
                    }
                }
            }
        }
        public void findPrimes4(int[] fourthThreadLoad)
        {
            int Number = 1;
            int iterate = 1;
            for (Number = fourthThreadLoad[0]; Number < fourthThreadLoad[1]; Number++)
            {
                bool resultFound = false;
                bool divisorFound = false;
                int fastNumber = Convert.ToInt32(Math.Ceiling(Number / 2.0));
                int lastDigit = Number % 10;
                for (iterate = 1; iterate < fastNumber + 1; iterate++)
                {
                    while ((iterate <= fastNumber && resultFound is false) || fastNumber == 1)
                    {

                        if ((divisorFound is true && iterate >= fastNumber) || lastDigit % 2 == 0 || lastDigit % 5 == 0 || lastDigit % 10 == 0)
                        {
                            resultFound = true;
                            //string primeArray = string.Join(",", primesList.ToArray());
                            //TextOutput.AppendText(Number + " is not prime\n");
                            //primesList.Clear();
                            break;
                        }
                        else if (Number % iterate == 0 && iterate != Number && iterate != 1)
                        {
                            divisorFound = true;
                            primesList.Add(Convert.ToString(iterate));
                            iterate += 1;
                        }

                        else if (divisorFound is false && iterate >= fastNumber || Number == 2)
                        {
                            resultFound = true;
                            totalPrimesFound = true;
                            primesThread4.Add(Number + " is prime.");
                            break;
                        }
                        else
                        {
                            iterate += 1;
                        }
                    }
                }
            }
        }

        public void findPrimesandDivisors(int startNumber, int endNumber)
        
        {
            int Number = 1;
            for (Number = startNumber; Number < endNumber; Number++)
            {
                resultFound = false;
                divisorFound = false;
                int iterate = 1;
                while (iterate <= Number && resultFound is false)
                {
                    for (iterate = 1; iterate < Number + 1; iterate++)
                    {
                        if (Number % iterate == 0 && iterate != Number - 1 && iterate != 1)
                        {
                            divisorFound = true;
                            primesList.Add(Convert.ToString(iterate));

                        }
                        else if (divisorFound is true && iterate == Number - 1)
                        {
                            resultFound = true;
                            string primeArray = string.Join(",", primesList.ToArray());
                            TextOutput.AppendText(Number + " is not prime, it is divisible by " + primeArray + "\n");
                            primesList.Clear();
                            break;
                        }
                        else if (divisorFound is false && iterate == Number - 1)
                        {
                            resultFound = true;
                            totalPrimesFound = true;
                            finalPrimes.Add(Number);
                            TextOutput.AppendText(Number + " is prime.\n");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        
        public void enteringNumbers()
        {
            if (firstNumberEntered is false)
            {

                if (TextInput.Text == "")
                {
                    TextOutput.AppendText("Please enter a number number.\n");
                }
                else
                {
                    firstNumber = Convert.ToInt32(TextInput.Text);
                    TextOutput.AppendText("Please enter your second number.\n");
                    firstNumberEntered = true;
                    TextInput.Clear();

                }
            }
            else if (firstNumberEntered is true && secondNumberEntered is false)
            {
                
                if (TextInput.Text == "")
                {
                    TextOutput.AppendText("Please enter a number number.\n");
                }
                else
                {
                    
                    secondNumber = (Convert.ToInt32(TextInput.Text) + 1);
                    secondNumberEntered = true;
                    threadDivision();
                    Thread T1 = new Thread(o => findPrimes1(firstThreadLoad));
                    Thread T2 = new Thread(o => findPrimes2(secondThreadLoad));
                    Thread T3 = new Thread(o => findPrimes3(thirdThreadLoad));
                    Thread T4 = new Thread(o => findPrimes4(fourthThreadLoad));
                    long tick1 = Environment.TickCount;
                    TextInput.Clear();
                    T1.Start();
                    T2.Start();
                    T3.Start();
                    T4.Start();
                    List<string> totalPrimesList = new List<string>();
                    while (T1.IsAlive || T2.IsAlive || T3.IsAlive || T4.IsAlive);
                    long tick2 = Environment.TickCount;
                    long duration = tick2 - tick1;
                    totalPrimesList = primesThread1.Concat(primesThread2).Concat(primesThread3).Concat(primesThread4).ToList();
                    string str_totalPrimesList = string.Join(System.Environment.NewLine, totalPrimesList);

                    TextOutput.AppendText(str_totalPrimesList + System.Environment.NewLine + System.Environment.NewLine);                   
                    TextOutput.AppendText("The calculation took: " + duration.ToString() +" miliseconds."+ System.Environment.NewLine);
                    TextOutput.AppendText("There were " + totalPrimesList.Count() + " primes found.");
                    


                }
            }
        }
        public  void threadDivision()
        {
            int perThreadLoad = (secondNumber - firstNumber) / totalThreads;
            firstThreadLoad =  new int[] { firstNumber,  perThreadLoad};
            secondThreadLoad = new int[] { perThreadLoad+1, 2 *(perThreadLoad) };
            thirdThreadLoad = new int[] { (2 * perThreadLoad) + 1, 3 * perThreadLoad };

            fourthThreadLoad = new int[] { (3 * perThreadLoad) + 1, 4 * perThreadLoad };
        }
        private void TextInputEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton.PerformClick();
            }
        }


            private void currentThread_TextChanged(object sender, EventArgs e)
            {

            }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphButtonClicked(object sender, EventArgs e)
        {
            //calculationPanel.Controls.Add(TextInput);
           // calculationPanel.Controls.Add(TextOutput);
           // calculationPanel.Controls.Add(SendButton);

            calculationPanel.Visible = false;
            graphPanel.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
  

}
        
    