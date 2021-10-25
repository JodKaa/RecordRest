using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordRest.Models;

namespace RecordRest.Managers.Tests
{
    [TestClass()]
    public class RecordManagerTests
    {
        private readonly RecordManager _manager = new RecordManager();

        [TestMethod()]
        public void GetAllRecordsTest()
        {
            List<Record> list = _manager.GetAllRecords();

            Assert.AreEqual(2, list.Count);
        }
    }
}