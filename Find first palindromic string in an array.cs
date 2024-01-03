public class Solution {
    public string FirstPalindrome(string[] words) {
      int len, numberOfComparison;
      string checkword;
      bool isPalindrome = false;
      
      for(int i = 0; i< words.Length ; i++)
      { 
        isPalindrome = true;
        checkword = words[i];
        len = checkword.Length;//ToCharArray().Count;       
       
        numberOfComparison = len/2; 
        for(int j=0; j < numberOfComparison; j++)
        {
            len = len-1;
            Console.WriteLine(checkword[j] + " compares with "+ checkword[len]);
            if(checkword[j] != checkword[len])
            {
                isPalindrome = false;
                break;
            } 
        }
        if(isPalindrome)
        {
            Console.WriteLine(words[i] + " is a palindrome");
            return words[i];           
        }
        else{
            Console.WriteLine(words[i] + " is not a palindrome");
        }       
      }
      if(!isPalindrome)
        {
            return "";           
        }
        return "";  
    }
}