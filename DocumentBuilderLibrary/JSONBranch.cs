/**
	 * Class Name:	JSONBranch and The child of IComposite	
	 * Purpose:	the process to create branch.				
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class JSONBranch : IComposite
    {
        string _value;
        private List<IComposite> _children;
        public JSONBranch(string value) 
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

            if (_value != "Branch")
            {
                result += "{\n\t'" + _value + "' :" + "\n\t{";
            }

            //result += "{\n\t'" + _value + "' :" + "\n\t{";

            int i = 0;
            foreach (var child in _children)
            {
                i++;
                result+=child.Print(depth) ;
                if (i<_children.Count)
                {
                    result += ", ";
                }
            }
             result += "\n\t}"  ;

            return result;
        }
    }
}
