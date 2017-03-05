using System;
using System.Globalization;


namespace ClassExperiments_2
{
    public class Genre
    {
        private string _name;
        public string Name
        {

            get
            {
                return _name;
            }
            set
            {
                _name = value.ToUpperInvariant();
                
            }
        }

    }
    
      }

   
