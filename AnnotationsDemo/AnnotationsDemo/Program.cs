using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnotationTest annotationTest = new AnnotationTest();
            annotationTest.Annotation();
            Console.ReadLine();
        }
    }
}
