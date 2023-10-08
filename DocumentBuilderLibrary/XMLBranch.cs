/**
	 * Class Name:	XMLBranch and The child of IComposite	
	 * Purpose:	the process to create leaf.				
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class XMLBranch : IComposite
    {
        string _value;
        private List<IComposite> _children;
        public XMLBranch(string value)
        {
            this._value = value;
            _children = new List<IComposite>();
        }
        public void AddChild(IComposite child)
        {
            _children.Add(child);
        }

        public string Print(int depth)
        {
            string result = "";
            
            result += "" + "<" + _value + ">" + "\n";
            foreach (IComposite child in _children)
            {
                result += child.Print(depth);  
            }
            result += "\n</"+ _value + ">";

            return result;
        }
    }
}
