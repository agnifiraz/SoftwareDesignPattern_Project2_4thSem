/**
	 * Class Name:	XMLLeaf and The child of IComposite	
	 * Purpose:	the process to create leaf.				
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class XMLLeaf : IComposite
    {
        private string _value;
        private string _type;
        public XMLLeaf(string type, string value)
        {
            this._type = type;
            this._value = value;
        }
        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
            string result = "";
            result += "<" + _type + ">"+ _value + "</" + _type + ">";
            return result;
        }
    }
}
