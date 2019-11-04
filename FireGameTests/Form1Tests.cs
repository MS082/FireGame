using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            ///calling the constructor method to execute the whole task so thus every task of the game is working properly 
            Form1 instance = new Form1();
            Assert.Fail();
        }

        // this method is used to get the result of the game and display on the screen
        [TestMethod()]
        public void Form1Load()
        {
            ///calling the constructor method to execute the whole task so thus every task of the game is working properly 
            Form1 instance = new Form1();
            instance.result(0);
            Assert.Fail();
        }



    }

}