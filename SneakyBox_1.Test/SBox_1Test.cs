using System.Text;
using System.Threading.Tasks;
using SneakyBox_1;
using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SneakyBox_1.Test 
{
    public class SBox_1Test
    {
        SBox_1Modifier sneakyBoxMod = new SBox_1Modifier();
        
        public SBox_1Test()
        {
            //sneakyBox = new SBox_1();
            sneakyBoxMod.PopulateWithData(0);
        }

        [Fact]
        public void SBox_1_ShouldUseStandartRulesetOnlyIfInt()
        {
            //Arrange
            string Expected =  new StringBuilder().Insert(0, sneakyBoxMod.badInputType, sneakyBoxMod._functionsCount()).ToString();
          
            //Act
            string Actual = sneakyBoxMod.Action("A");

            //Assert
            Assert.True(Expected == Actual);
        }

        [Fact]
        public void SBox_1_ShouldWorkCorrectlyWhenGivenEmptyString()
        {
            //Arrange
            string Expected = new StringBuilder().Insert(0, sneakyBoxMod.badInputType, sneakyBoxMod._functionsCount()).ToString();

            //Act
            string Actual = sneakyBoxMod.Action("");

            //Assert
            Assert.True(Expected == Actual);
        }

        [Fact]
        public void SBox_1_ShouldWorkWithNewDifferentRuleWithInt()
        {
            //Arrange
            sneakyBoxMod.PopulateWithData(1);
            string Expected = "7 is lucky number";

            //Act
            string Actual = sneakyBoxMod.Action("7");

            //Assert
            Assert.True(Expected == Actual);
        }

        [Fact]
        public void SBox_1_ShouldGiveSneakyIfNumber3WithStandartRuleset()
        {
            //Arrange
            string Expected = "Sneaky";

            //Act
            string Actual = sneakyBoxMod.Action("3");

            //Assert
            Assert.True(Expected == Actual);
        }
       
        [Fact]
        public void SBox_1_ShouldGiveBoxIfNumber5WithStandartRuleset()
        {
            //Arrange
            string Expected = "Box";

            //Act
            string Actual = sneakyBoxMod.Action("5");

            //Assert
            Assert.True(Expected == Actual);
        }

        [Fact]
        public void SBox_1_ShouldGiveSneakyBoxIfNumber15WithStandartRuleset()
        {
            //Arrange
            string Expected = "SneakyBox";

            //Act
            string Actual = sneakyBoxMod.Action("15");

            //Assert
            Assert.True(Expected == Actual);
        }
       
        [Fact]
        public void SBox_1_ShouldMatch15FirstCasesWithStandartRuleset()
        {
            //Arrange
            ICollection Expected = new ArrayList
                {"1", "2", "Sneaky", "4", "Box", "Sneaky", "7", "8", "Sneaky", "Box", "11", "Sneaky", "13", "14", "SneakyBox"};

            //Act
            var Actual = Enumerable.Range(1, 15).Select(x => sneakyBoxMod.Action(x.ToString())).ToList();

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void SBox_1_OutputsAndInputsNumberShouldBeEqualWithStandartRuleset()
        {
            //Arrange
            int Expected = 100;

            //Act
            var Actual = Enumerable.Range(1, 100).Select(x => sneakyBoxMod.Action(x.ToString())).ToList();

            //Assert
            Assert.Equal(Expected, Actual.Count);
        }

        [Fact]
        public void SBox_1_ShouldWorkWithStandartRulesetInDifferentOrder()
        {
            //Arrange
            ICollection Expected = new ArrayList
                {"1", "2", "Sneaky", "4", "Box", "Sneaky", "7", "8", "Sneaky", "Box", "11", "Sneaky", "13", "14", "SneakyBox"};   

            //Act
            var Actual = Enumerable.Range(1, 15).Select(x => sneakyBoxMod.Action(x.ToString())).ToList();

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void SBox_1_ShouldWorkInLoop()
        {
            //Arrange
            ArrayList Expected = new ArrayList
                {"1", "2", "Sneaky", "4", "Box", "Sneaky", "7", "8", "Sneaky", "Box", "11", "Sneaky", "13", "14", "SneakyBox"};



            //Act
            ArrayList Actual = new ArrayList();
            for (int i = 1; i <= 15; i++)
                Actual.Add(sneakyBoxMod.Action(i.ToString()));

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void SBox_1_ShouldWorkWithNewAddedRuleWithInt()
        {
            //Arrange
            sneakyBoxMod.PopulateWithData(1);
            ICollection Expected = new ArrayList
                {"1", "2", "Sneaky", "4", "Box", "Sneaky", "7 is lucky number", "8", "Sneaky", "Box", "11", "Sneaky", "13", "14", "SneakyBox"};

            //Act
            var Actual =  Enumerable.Range(1, 15).Select(x => sneakyBoxMod.Action(x.ToString())).ToList();            

            //Assert
            Assert.Equal(Expected, Actual);
        }
    }
}
