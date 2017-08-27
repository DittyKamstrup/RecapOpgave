using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RecapOpgaveUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgePartinioningTest()
        {
            //Arrange
            RecapOpgave.Member member = new RecapOpgave.Member("Søs", 14);
            //Act
            member.AgePartitioning();
            //Assert
            Assert.AreEqual(member.Team,"Pandaholdet");
        }
    }
}
