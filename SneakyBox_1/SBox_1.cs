using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SneakyBox_1
{ 
    public class SBox_1
    {
        protected delegate string kitas(string value);
        protected IList<kitas> _functions { get; set; } = new List<kitas>();


        public int _functionsCount()
        {           
            return  _functions.Count;
        }

        public string Action(string value )
        {  
            var result = _functions.Aggregate(String.Empty, (current, function) => current + function.Invoke(value));
            return String.IsNullOrEmpty(result) ? value.ToString(CultureInfo.InvariantCulture) : result;
        }
    }
}
