/**
	 * Interface Name:	IBuilder	
	 * Purpose:	Contains BuildBranch(string name),BuildLeaf(string name, string content),CloseBranch() and GetDocument().			
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public interface IBuilder
    {
        public void BuildBranch(string name);
        public void BuildLeaf(string name, string content);
        public void CloseBranch();
        public IComposite GetDocument();
    }
}
