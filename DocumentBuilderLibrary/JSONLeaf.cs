/**
	 * Class Name:	JSONLeaf and The child of IComposite	
	 * Purpose:	the process to create leaf.				
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class JSONLeaf : IComposite
    {
        //private int _index;
        private string _value;
        private string _type;
        public JSONLeaf(string type, string value) 
        { 
            this._type = type;
            this._value = value;    
        }
        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
            string result = "\n\t";
            result += "     '" + _type + "'" +" : " + "'" + _value +"' ";
            return result;

        }
    }
}
