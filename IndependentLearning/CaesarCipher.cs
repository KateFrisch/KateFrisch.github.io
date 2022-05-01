// using System;

// namespace CaesarCipher
// {
//     class CaesarCipher
//     {
//         public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

//         static void Start()
//         {
//             string secretMsg = Console.ReadLine();
//             secretMsg = secretMsg.ToLower();
//             char[] secretMessage = secretMsg.ToCharArray();

//             char[] encryptedMessage = Encrypt(secretMessage, 3);
            

//             string output = String.Join("", encryptedMessage);
//             Console.WriteLine(output);

//             char[] decryptedMessage = Decrypt(encryptedMessage, 3);

//             string output2 = String.Join("", decryptedMessage);
//             Console.WriteLine(output2);

            
//         }

//         public static char[] Encrypt(char[] inputArray, int key){
//             char[] encryptedMessage = new char[inputArray.Length];

//             for (int i = 0; i < inputArray.Length; i++)
//             {
//                 char temp = inputArray[i];
//                 int index = Array.IndexOf(alphabet, temp);
//                 if (index > -1)
//                 {
//                     int newIndex = Math.Abs((index + 26 + key) % 26);
//                     char newEncrypt = alphabet[newIndex];
//                     encryptedMessage[i] = newEncrypt;
//                 }
//             }
//             return encryptedMessage;
//         }

//          public static char[] Decrypt(char[] inputArray, int key){
//             int newKey = key * -1;
//             return Encrypt(inputArray, newKey);
//         }
//     }
// }