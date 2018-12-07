using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClasses.Tests
{
    [TestClass]
    public class FileProcessTests
    {
        [TestMethod]
        public void FileNameDoesExist_Test()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileExists;

            //Act
            fileExists = fp.FileExists(@"C:\Windows\regedit.exe");

            //Assert
            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void FileNameDoesNotExists_Test()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileExists;

            //Act
            fileExists = fp.FileExists(@"C:\nofilehere.exe");

            //Arrange
            Assert.IsFalse(fileExists);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumenNullException_Test()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumenNullException_WithTryCatch_Test()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Call to FileExsits with empty string as parameter does not throw an ArgumentNullException");
        }
    }
}
