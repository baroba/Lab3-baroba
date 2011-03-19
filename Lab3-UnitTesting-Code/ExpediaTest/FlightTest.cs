using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(System.DateTime.Now,System.DateTime.Now,100);
            Assert.IsNotNull(target); 
        }

        [Test()]
        public void TestFlightPrice()
        {
            var target = new Flight(System.DateTime.Now, System.DateTime.Now, 100);
            Assert.AreEqual(200, target.getBasePrice()); 
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOp()
        {
            var target = new Flight(System.DateTime.MaxValue, System.DateTime.MinValue, 100);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRange()
        {
            
            var target = new Flight(System.DateTime.MinValue, System.DateTime.MaxValue, -100); 

        }
	}
}
