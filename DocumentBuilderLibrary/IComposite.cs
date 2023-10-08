/**
	 * Interface Name:	IComposite	
	 * Purpose:	Contains AddChild(IComposite child),and Print(int depth).			
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public interface IComposite
    {
        public void AddChild(IComposite child);
        public string Print(int depth);
    }
}
