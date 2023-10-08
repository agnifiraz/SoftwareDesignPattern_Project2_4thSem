/**
	 * Class Name:	JSONIBuilder and The child of IBuilder	
	 * Purpose:	the process to marge branch and leaf in a formate			
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class JSONIBuilder : IBuilder
    {
       // private Vehicle _vehicle;
        private JSONBranch _branch;
        //stack
        private Stack<JSONBranch> _stack;

        public JSONIBuilder()
        {
           // _vehicle = new Vehicle();
            _branch = new JSONBranch("Branch");
            _stack = new Stack<JSONBranch>();
            _stack.Push(_branch);
        }
        public void BuildBranch(string name)
        {
            JSONBranch _addingBranch = new JSONBranch(name);
            //recieve info from the top of the Stack.
            _stack.Peek().AddChild(_addingBranch);
            _stack.Push(_addingBranch);
        }

        public void BuildLeaf(string name, string content)
        {
            JSONLeaf _addingLeaf = new JSONLeaf(name, content);
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
           // return _vehicle;
            return _branch;
        }

        //public Vehicle BuildVehicle(IVehicleBuilder builder)
        //{
        //    builder.BuildVehicle();
        //    builder.BuildDoors();
        //    builder.BuildEngine();
        //    builder.BuildSeats();
        //    builder.BuildWheels();
        //    return builder.GetVehicle();
        //}
    }
}
