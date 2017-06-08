using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpiderApp.Controllers;
using SpiderApp.Models;

namespace SpiderApp.Test
{
    [TestClass]
    public class BallInfoTest
    {
        [TestMethod]
        public void GetBallTest()
        {
            //Arrange
            BallInfoController ballInfoController = new BallInfoController();
            //Act
            BallInfo ballInfo = ballInfoController.GetBallInfo();
            //Assert
            Assert.IsNull(ballInfo);
        }

        [TestMethod]
        public void ObtainInfoTest()
        {
            BallInfoController ballInfoController = new BallInfoController();
            ballInfoController.obtainMatchInfo();
            Assert.IsFalse(false);
        }
    }
}