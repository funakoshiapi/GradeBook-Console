using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class NameObject
    {
       private String BookName;
        public NameObject(string name)
        {
            Name = name;
        }
        public string Name 
        {
            //get; set;
            
            
            get
            {
                return BookName ;
            }
            
            set
            {
                BookName = value;
            }
            
            
            
        }
    }

}