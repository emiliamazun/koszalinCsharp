﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        //        /// <summary>
        //        /// String is diffrent then previues types we talk about
        //        /// values of string we are passing in quotation marks
        //        /// 
        //        /// Create new string with your name and then add them together
        //        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string Example = "This is example string";

            string myName = " Emilia";

            string output = Example + myName;

            Assert.That(output, Is.EqualTo("This is example string Emilia"));

        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()
        {
            int x = 3;
            double y = 3.01;
            string itsEmpty = string.Empty;

            string errormessageFORMAT = string.Format("MY texts values {0} i {1}", x, y);

            string errorMessageWithDolar = string.Format($"MY texts values {x} i {y}");

            Console.WriteLine(errormessageFORMAT);
            Console.WriteLine(errorMessageWithDolar);
            Assert.That(itsEmpty, Is.Not.Null);
        }

        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like";

            string restult = second + " "+ first;

            Assert.AreEqual(restult, "I like pancakes.");
        }

        //        /// <summary>
        //        /// There is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        //        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        //        /// create string with both x and y insed
        //        /// </summary>
        [Test]
        public void String_Format()
        {
            int x = 500;
            int y = 453;
            string result1=string.Format("{0} {1}",x,y);

            StringAssert.Contains(x.ToString(), result1);
            StringAssert.Contains(y.ToString(), result1);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";

            string result = theString.Substring(16, 5);

            Assert.AreEqual(result, "thing");
        }


    }
}
