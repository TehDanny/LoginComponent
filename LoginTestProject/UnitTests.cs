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
        public void U_Login_LoginUser_AllDataOK_Void()
        {
        }

        [TestMethod]
        public void U_Login_LoginUser_InvalidEmail_Exception()
        {
        }

        [TestMethod]
        public void U_Login_LoginUser_InvalidPassword_Exception()
        {
        }

        [TestMethod]
        public void U_Login_CreateUser_AllDataOK_Void()
        {
        }

        [TestMethod]
        public void U_Login_CreateUser_PasswordsArentMatching_Exception()
        {
        }

        [TestMethod]
        public void U_Login_CreateUser_EmailAlreadyInUse_Exception()
        {
        }

        [TestMethod]
        public void U_Login_DeleteUser_AllDataOK_Void()
        {
        }

        [TestMethod]
        public void U_Login_DeleteUser_UserDoesntExist_Exception()
        {
        }

        [TestMethod]
        public void U_Login_ChangeEmail_AllDataOK_Void()
        {
        }

        [TestMethod]
        public void U_Login_ChangePassword_AllDataOK_Void()
        {
        }

        [TestMethod]
        public void U_Login_ChangePassword_PasswordsArentMatching_Exception()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
            // delete added users or tables
        }
    }
}
