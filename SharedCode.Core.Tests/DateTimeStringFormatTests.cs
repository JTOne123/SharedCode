﻿// <copyright file="DateTimeStringFormatTests.cs" company="improvGroup, LLC">
//     Copyright © improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace SharedCode.Core.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Class DateTimeStringFormatTests.
    /// </summary>
    [TestClass]
    public class DateTimeStringFormatTests
    {
        /// <summary>
        /// The original date time
        /// </summary>
        private DateTime originalDateTime;

        /// <summary>
        /// Initializes the test case.
        /// </summary>
        [TestInitialize]
        public void InitTestCase() => this.originalDateTime = new DateTime(1984, 3, 11, 2, 30, 58);

        /// <summary>
        /// Determines whether this instance [can get short date string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Short_Date_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.ShortDate);
            Assert.AreEqual(this.originalDateTime.ToShortDateString(), result);
        }

        /// <summary>
        /// Determines whether this instance [can get long date string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Long_Date_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.LongDate);
            Assert.AreEqual("11 March 1984", result);
        }

        /// <summary>
        /// Determines whether this instance [can get short time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Short_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.ShortTime);
            Assert.AreEqual("02:30", result);
        }

        /// <summary>
        /// Determines whether this instance [can get long time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Long_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.LongTime);
            Assert.AreEqual("02:30:58", result);
        }

        /// <summary>
        /// Determines whether this instance [can get full short date time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Full_Short_Date_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.FullShortDateTime);
            Assert.AreEqual("11 March 1984 02:30", result);
        }

        /// <summary>
        /// Determines whether this instance [can get full long date time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Full_Long_Date_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.FullLongDateTime);
            Assert.AreEqual("11 March 1984 02:30:58", result);
        }

        /// <summary>
        /// Determines whether this instance [can get general short date time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_General_Short_Date_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.GeneralShortDateTime);
            Assert.AreEqual("11/03/1984 02:30", result);
        }

        /// <summary>
        /// Determines whether this instance [can get general long date time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_General_Long_Date_Time_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.GeneralLongDateTime);
            Assert.AreEqual("11/03/1984 02:30:58", result);
        }

        /// <summary>
        /// Determines whether this instance [can get month day lower case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Month_Day_Lower_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.MonthDayLowerCase);
            Assert.AreEqual("11 March", result);
        }

        /// <summary>
        /// Determines whether this instance [can get month day upper case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Month_Day_Upper_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.MonthDayUpperCase);
            Assert.AreEqual("11 March", result);
        }

        /// <summary>
        /// Determines whether this instance [can get RFC1123 lower case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Rfc1123_Lower_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.Rfc1123LowerCase);
            Assert.AreEqual("Sun, 11 Mar 1984 02:30:58 GMT", result);
        }

        /// <summary>
        /// Determines whether this instance [can get RFC1123 upper case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Rfc1123_Upper_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.Rfc1123UpperCase);
            Assert.AreEqual("Sun, 11 Mar 1984 02:30:58 GMT", result);
        }

        /// <summary>
        /// Determines whether this instance [can get sortable date time iso8601 string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Sortable_DateTime_Iso8601_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.SortableDateTimeIso8601);
            Assert.AreEqual("1984-03-11T02:30:58", result);
        }

        /// <summary>
        /// Determines whether this instance [can get universal sortable date time string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Universal_Sortable_DateTime_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.UniversalSortableDateTime);
            Assert.AreEqual("11 March 1984 02:30:58", result);
        }

        /// <summary>
        /// Determines whether this instance [can get year month lower case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Year_Month_Lower_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.YearMonthLowerCase);
            Assert.AreEqual("March 1984", result);
        }

        /// <summary>
        /// Determines whether this instance [can get year month upper case string].
        /// </summary>
        [TestMethod]
        public void Can_Get_Year_Month_Upper_Case_String()
        {
            var result = this.originalDateTime.ToStringFormat(() => DateTimeFormat.YearMonthUpperCase);
            Assert.AreEqual("March 1984", result);
        }

        /// <summary>
        /// Teardowns the test case.
        /// </summary>
        [TestCleanup]
        public void TeardownTestCase()
        {
            if (this.originalDateTime != default)
            {
                GC.SuppressFinalize(this.originalDateTime);
            }
        }
    }
}