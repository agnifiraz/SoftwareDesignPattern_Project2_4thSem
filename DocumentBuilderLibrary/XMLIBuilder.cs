/**
	 * Class Name:	XMLIBuilder and The child of IBuilder	
	 * Purpose:	the process to marge branch and leaf for XML			
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class XMLIBuilder : IBuilder
    {
        private XMLBranch _branch;
        private Stack<XMLBranch> _stack;

        public XMLIBuilder()
        {
            // _vehicle = new Vehicle();
            _branch = new XMLBranch("root");
            _stack = new Stack<XMLBranch>();
            _stack.Push(_branch);
        }
        public void BuildBranch(string name)
        {
            XMLBranch _addingBranch = new XMLBranch(name);
            _stack.Peek().AddChild(_addingBranch);
            _stack.Push(_addingBranch);
        }

        public void BuildLeaf(string name, string content)
        {
            XMLLeaf _addingLeaf = new XMLLeaf(name, content);
            _stack.Peek().AddChild(_addingLeaf);
        }

        public void CloseBranch()
        {
            if (_stack.Count != 1)
            {
                _stack.Pop();
            }
        }

        public IComposite GetDocument()
        {
            return _branch;
        }
    }
}
