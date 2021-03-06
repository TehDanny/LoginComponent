﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginComponent;

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
            // Arrange
            ILoginDataMapper fdm = new FakeLoginDataMapper();
            Login l = new Login(fdm);

            // Act
            l.CreateUser("test@eal.dk", "Testing1", "Testing1");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEqualPasswordsException))]
        public void U_Login_CreateUser_NotEqualPasswords_NotEqualPasswordsException()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void U_Login_CreateUser_InvalidPassword_InvalidPasswordException()
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
