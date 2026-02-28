using System;

namespace IMissHerThoughtsProcessing.Services
{
    public class StringService
    {
        private string currentText;
        
        public StringService
        {
            currentText = string.Empty;
        }
        
        public string CurrentText => currentText;
        
        public void setText(string text)
        {
            currentText = text;
        }
        
        public string ConvertToUpper()
        {
            return currentText.ToUpper();
        }
        
        public string ConvertToLower()
        {
            return currentText.ToLower();
        }
        
        public int CountCharacters()
        {
            return currentText.Length;
        }
        
        public bool ContainsWord(string word)
        {
            return currentText.Contains(word);
        }
        
        public string ReplaceWord(string oldWord, string newWord)
        {
            return currentText.Replace(oldWord, newWord);
        }
        
        public string ExtractSubstring(int startindex, int length)
        {
            if(startIndex < 0 || startIndex + length > currentText.Length)
        {
            return "Invalid substring range!";
        }
        return currentText.Substring(startindex, length);
        }
        
        public string TrimSpaces()
        {
            return currentText.Trim();
        }
        
        public void ResetText()
        {
            currentText = string.Empty;
        }
    }
}
