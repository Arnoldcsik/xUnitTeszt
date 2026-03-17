namespace Program1
{

    using System;

    public class SimpleProgram
    {
        public int Method1(string text)
        {
            return text.Length;
        }

        public string Method2(string text)
        {
            return text.ToUpper();
        }

        public string Method3(string text)
        {
            return text.ToLower();
        }

        public bool Method4(string text)
        {
            return text.Contains("a");
        }

        public int Method5(string text)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c == 'a')
                {
                    count++;
                }
            }

            return count;
        }

        public string Method6(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public bool Method7(int number)
        {
            return number > 0;
        }

        public bool Method8(int number)
        {
            return number % 2 == 0;
        }

        public string Method9(string text)
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        public int Method10(int[] numbers)
        {
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 10)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
