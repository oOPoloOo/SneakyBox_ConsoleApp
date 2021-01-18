using System;
using System.Collections.Generic;
using System.Text;


namespace SneakyBox_1
{   
    public class SBox_1Modifier : SBox_1
    {   
        //String to print out then input is not correct
        public string badInputType { get; set; } = "Bad input type. | ";

        private int? IsInt(string eilute)
        {
            var isNumeric = int.TryParse(eilute, out int n);
            if (isNumeric) return n;
            else return null;
        }

        public void ClearList()
        {
            _functions.Clear();
        }

        /// <summary>
        /// This class anables to change,
        /// add, switch places functions. 
        /// </summary>
        /// <param name="useCase">Parameter show which ruleset to use</param>
        public void PopulateWithData(int useCase)
        {
            switch (useCase)
            {
                case 0:
                    _functions.Add(x => IsInt(x) != null ? (IsInt(x) % 3 == 0 ? "Sneaky" : "") : badInputType);
                    _functions.Add(x => IsInt(x) != null ? (IsInt(x) % 5 == 0 ? "Box" : "") : badInputType);
                    break;
                case 1:
                    _functions.Add(x => IsInt(x) != null ? (IsInt(x) == 7 ? "7 is lucky number" : "") : badInputType);
                    break;
                case 2:
                    ClearList();
                    _functions.Add(x => IsInt(x) != null ? (IsInt(x) % 5 == 0 ? "Box" : "") : badInputType);
                    _functions.Add(x => IsInt(x) != null ? (IsInt(x) % 3 == 0 ? "Sneaky" : "") : badInputType);
                    break;
            }
        }
    }
}
