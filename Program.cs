using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter a secret message: ");
            string message = Console.ReadLine().ToLower();
            //convert the captured string to an array of characters 
            char[] secretMessage = message.ToCharArray();
            //create empty array of char 
            char[] encryptedMessage = new char[secretMessage.Length];
            char[] decryptedMessage = new char[secretMessage.Length];
            //Console.WriteLine(encryptedMessage);
            Encrypt(alphabet, secretMessage, encryptedMessage);
           // Decrypt(alphabet, secretMessage, decryptedMessage);

        }
        //loop through each secretmsg char 
        public static void Encrypt(char[] alphabet, char[] secretMessage, char[] encryptedMessage)
        {
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //access char at position i
                char msg = secretMessage[i];
                //find position of the char on the alphabet array
                int index = Array.IndexOf(alphabet, msg);
                //add three to the letter position 
                int indexTwo = (index + 3) % alphabet.Length;
                //find the new encrypted char. get the char in the alphabet array with the new position
                char newEncryptedChar = alphabet[indexTwo];
                //add it to the encrypted msg array and store at the index i
                encryptedMessage[i] = newEncryptedChar;
                //convert the array of chars to a string
                string encryptedString = String.Join("", newEncryptedChar);
                Console.WriteLine(encryptedString);
            }
        }
        //Decrypt method
        public static void Decrypt(char[] alphabet, char[] secretMessage, char[] decryptedMessage)
        {
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //access char at position i
                char msg = secretMessage[i];
                int index = Array.IndexOf(alphabet, msg);

                int indexTwo = (index - 3) % alphabet.Length;
                char newDecryptedChar = alphabet[indexTwo];
                decryptedMessage[i] = newDecryptedChar;
                string decryptedString = String.Join("", newDecryptedChar);
                Console.WriteLine(decryptedString);
            }
        }
    }
}
