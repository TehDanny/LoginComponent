using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestInitialize]
        public void Initialize()
        {
            // add connectionstring
        }

        [TestMethod]
        public void U_Login_LoginUser_AllInputOK_Void()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_LoginUser_InvalidEmail_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_LoginUser_InvalidPassword_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_AllInputOK_Void()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_PasswordsArentMatching_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_InvalidPassword_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_InvalidEmail_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_EmailAlreadyInUse_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_DeleteUser_AllInputOK_Void()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_DeleteUser_UserDoesntExist_Exception()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_ChangeEmail_AllInputOK_Void()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_ChangePassword_AllInputOK_Void()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_ChangePassword_PasswordsArentMatching_Exception()
        {
            Assert.Fail();
        }

        [TestCleanup]
        public void Cleanup()
        {
            // delete added users or tables
        }
    }
}
