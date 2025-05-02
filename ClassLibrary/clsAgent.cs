using System;

namespace ClassLibrary
{
    public class clsAgent
    {
        public string Description { get; set; }

        public string Valid(string nDescription)
        {
            if (nDescription.Length < 1)
            {
                return "Description cannot be blank";
            }
            if (nDescription.Length > 50)
            {
                return " Description cannot be more than 50 char";
            }
            else
            {
                return "";
            }
            
        }
    }
}
