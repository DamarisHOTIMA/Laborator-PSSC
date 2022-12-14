using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Workflow_LivrareComanda
{
    

        public record PostalCode
        {
            private static readonly Regex ValidPattrern = new("^[0-9]{6}$");

            public string Value { get; }

            public PostalCode(string value)
            {
                if (ValidPattrern.IsMatch(value))
                {
                    Value = value;
                }
                else
                {
                    throw new Exception($"{value} is invalid");
                }
            }
            public override string ToString()
            {
                return Value;
            }
        }
    
}
