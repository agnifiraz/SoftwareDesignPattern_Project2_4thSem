/**
	 * Class Name:	Director and The child of IDirector	
	 * Purpose:	the process to get proper output and Console clien own a Director that calls all neccessary classes.				
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public class Director : IDirector
    {
        // builder is to pass all values to Json files (JsonBuilder) and Xml files (XMLbuilder)
        private IBuilder builder;
        //variables for branches and leaf as they contain thier own parameter.
        public string _value { set; get; }
        public string _type { set; get; }

        //mode indicates the process should be in json or xml. so I passed a string value in constructor
        public Director(string mode)
        {
            if (mode == "json")
            {
                builder = new JSONIBuilder();
            }
            else if (mode == "xml")
            {
                builder = new XMLIBuilder();
            }
        }


        public void BuildBranch()
        {
            builder.BuildBranch(_type);
        }

        public void BuildLeaf()
        {
            builder.BuildLeaf(_type ,_value);
        }

        public void CloseBranch()
        {
            builder.CloseBranch();
        }

        //print
        public void Print()
        {
            Console.Write(builder.GetDocument().Print(0));
        }

        /*  *Method Name: PrintUsage()
            *Purpose: to guide users. 
            *Accepts: no parameter
            *Returns: void
        */
        public static void PrintUsage()
        {
            Console.WriteLine("Document Builder Console Client \n");
            Console.WriteLine("Usage: ");
            Console.WriteLine("\t \t help                        -Prints Usage (this page)");
            Console.WriteLine("\t \t mode: <JSON|XML>            -Sets mode to JSON or XML. Must be set before creating or closing.");
            Console.WriteLine("\t \t branch: <name>              -Creates a new branch, assigningit the passed name.");
            Console.WriteLine("\t \t leaf:<name>:<content>       -Create a new leaf, assigning the passed name and content.");
            Console.WriteLine("\t \t close                       -Closes the current branch, as long as it is not the root.");
            Console.WriteLine("\t \t print                       -Prints the doc in its current state to the console.");
            Console.WriteLine("\t \t exit                        -Exits the application. \n");

        }

    }
}
