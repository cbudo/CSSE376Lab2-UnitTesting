using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        private Flight target;
        private readonly DateTime StartDate = new DateTime(2009, 11, 1);
        private readonly DateTime EndDate = new DateTime(2009, 11, 30);

        [SetUp()]
        public void Setup()
        {
            target = new Flight(StartDate, EndDate, 10);
        }
        [Test()]
        public void TestThatFlightInitializes()
        {
            Assert.AreEqual(10, target.Miles);
        }
        [Test()]
        public void TestOverideEquals()
        {
            Assert.True(target.Equals((object)target));
        }
        [Test()]
        public void TestFlightEquals()
        {
            Assert.True(target.Equals(new Flight(StartDate,EndDate,10)));
        }
        [Test()]
        public void TestFlightNotEquals()
        {
            Assert.False(target.Equals(new Flight(StartDate, EndDate, 15)));
        }
        [Test()]
        public void TestBasePrice()
        {
            Assert.AreEqual(target.getBasePrice().CompareTo(780),0);
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadLength()
        {
            new Flight(StartDate,EndDate,-5);
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnIncorrectDate()
        {
            new Flight(EndDate, StartDate, 5);
        }
        [TearDown()]
        public void TearDown()
        {
            target = null; // this is entirely unnecessary.. but I'm just showing a usage of the TearDown method here
        }
	}
}
