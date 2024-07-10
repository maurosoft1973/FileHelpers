﻿#if !NETCOREAPP
//using NUnit.Framework;

//namespace FileHelpers.Tests.Tests.DataLink
//{
//    [TestFixture]
//    public class ExcelStorageNPOITests
//    {
//        [Test]
//        public void ReadExcelStorageWithNoEmptyRows_ShouldReadAll()
//        {
//            var res = ReadFromExcelStorage("ExcelWithNoEmptyRows.xlsx", stopAfterEmptyRows: 1);
//            AssertExpectedResults(res, expectedResultCount: 4);
//        }

//        [Test]
//        public void ReadExcelStorageWithOneEmptyRows_StopAfterOneEmpty_ShouldStopEarly()
//        {
//            var res = ReadFromExcelStorage("ExcelWithOneEmptyRows.xlsx", stopAfterEmptyRows: 1);
//            AssertExpectedResults(res, expectedResultCount: 2);
//        }

//        [Test]
//        public void ReadExcelStorageWithOneEmptyRows_StopAfterTwoEmpty_ShouldNotStopEarly()
//        {
//            var res = ReadFromExcelStorage("ExcelWithOneEmptyRows.xlsx", stopAfterEmptyRows: 2);
//            AssertExpectedResults(res, expectedResultCount: 4);
//        }

//        [Test]
//        public void ReadExcelStorageWithTwoEmptyRows_StopAfterTwoEmpty_ShouldStopEarly()
//        {
//            var res = ReadFromExcelStorage("ExcelWithTwoEmptyRows.xlsx", stopAfterEmptyRows: 2);
//            AssertExpectedResults(res, expectedResultCount: 2);
//        }

//        [Test]
//        public void ReadExcelStorageWithTwoEmptyRows_StopAfterThreeEmpty_ShouldNotStopEarly()
//        {
//            var res = ReadFromExcelStorage("ExcelWithTwoEmptyRows.xlsx", stopAfterEmptyRows: 3);
//            AssertExpectedResults(res, expectedResultCount: 4);
//        }

//        [Test]
//        public void ReadExcelStorageWithNoEmptyRows_ShouldHandleStressTest()
//        {
//            // This will not perform well as it looks 100 rows ahead on each row for empty rows
//            // not an expected use case but thought I'd test the edge case anyway
//            var res = ReadFromExcelStorage("ExcelWithNoEmptyRows.xlsx", stopAfterEmptyRows: 100);
//            AssertExpectedResults(res, expectedResultCount: 4);
//        }

//        [Test]
//        public void ReadExcelStorageWithMissingCellsTest()
//        {
//            var res = ReadFromExcelStorage("ExcelWithEmptyCells.xlsx", stopAfterEmptyRows: 4);

//            Assert.AreEqual(4, res.Length);

//            Assert.AreEqual("AllwaysOnTop", res[0].OrganizationName);
//            Assert.AreEqual("COMPUTERS, HARDWARE", res[1].OrganizationName);
//            Assert.AreEqual(null, res[2].OrganizationName);
//            Assert.AreEqual("SmartSolutions", res[3].OrganizationName);

//            Assert.AreEqual("Test 1,", res[0].TestField);
//            Assert.AreEqual("Test, 2", res[1].TestField);
//            Assert.AreEqual(" Test 3", res[2].TestField);
//            Assert.AreEqual(null, res[3].TestField);

//            Assert.AreEqual(11, res[0].Id);
//            Assert.AreEqual(null, res[1].Id);
//            Assert.AreEqual(33, res[2].Id);
//            Assert.AreEqual(44, res[3].Id);
//        }

//        private static void AssertExpectedResults(ExcelXlsType[] res, int expectedResultCount)
//        {
//            Assert.AreEqual(expectedResultCount, res.Length);

//            Assert.AreEqual("AllwaysOnTop", res[0].OrganizationName);
//            Assert.AreEqual("COMPUTERS, HARDWARE", res[1].OrganizationName);
//            Assert.AreEqual("Test 1,", res[0].TestField);
//            Assert.AreEqual("Test, 2", res[1].TestField);

//            // cases where there is no blank row (or blank row was skipped)
//            if (expectedResultCount != 2)
//            {
//                Assert.AreEqual("4S Consulting, Inc.", res[2].OrganizationName);
//                Assert.AreEqual("SmartSolutions", res[3].OrganizationName);
//                Assert.AreEqual(" Test 3", res[2].TestField);
//                Assert.AreEqual("Test 4", res[3].TestField);
//            }
//        }

//        private static ExcelXlsType[] ReadFromExcelStorage(string fileName, int stopAfterEmptyRows)
//        {
//            var provider = new ExcelNPOIStorage.ExcelNPOIStorage(typeof(ExcelXlsType));

//            provider.FileName = TestCommon.GetPath("Excel", fileName);
//            provider.SheetName = "Sheet1";
//            provider.StartRow = 0;
//            provider.StartColumn = 0;

//            provider.ExcelReadStopAfterEmptyRows = stopAfterEmptyRows;

//            return (ExcelXlsType[])provider.ExtractRecords();
//        }

//        [DelimitedRecord("|")]
//        public sealed class ExcelXlsType
//        {
//            public int? Id;

//            [FieldQuoted('"', QuoteMode.OptionalForBoth)]
//            public string OrganizationName;

//            [FieldQuoted('"', QuoteMode.OptionalForBoth)]
//            public string TestField;
//        }
//    }
//}
#endif
