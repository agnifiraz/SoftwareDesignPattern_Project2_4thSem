/**
	 * Interface Name:	IDirector	
	 * Purpose:	Contains BuildBranch(), BuildLeaf() and CloseBranch().			
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public interface IDirector
    {
        public void BuildBranch();
        public void BuildLeaf();
        public void CloseBranch();
    }
}
