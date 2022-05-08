﻿using NUnit.Framework;
using FluentAssertions;
using Exercises.Models;

namespace Exercises.Tests
{
    public class Exercise002Tests
    {
        private Exercise002 Exercise002;

        [SetUp]
        public void Setup()
        {
            Exercise002 = new Exercise002();
        }

        [Test]
        public void IsFromManchester_Should_Return_True_If_Person_Is_From_Manchester()
        {
            Person p1 = new Person("Peter", "Smith", "Manchester", 23);
            Exercise002.IsFromManchester(p1).Should().Be(true);
        }

        [Test]
        public void IsFromManchester_Should_Return_False_If_Person_Is_Not_From_Manchester()
        {
            Person p2 = new Person("Susan", "Farmer", "Leeds", 23);
            Exercise002.IsFromManchester(p2).Should().Be(false);

            p2 = new Person("Susan", "Farmer", null, 23);
            Exercise002.IsFromManchester(p2).Should().Be(false);

            Exercise002.IsFromManchester(null).Should().Be(false);
        }


        [Test]
        public void CanWatchFilm_Should_Return_False_If_Age_Is_Below_The_Age_Limit()
        {
            Person p1 = new Person("Peter", "Smith", "Manchester", 17);
            Exercise002.CanWatchFilm(p1, 18).Should().Be(false);
        }

        [Test]
        public void CanWatchFilm_Should_Return_True_If_Age_Is_EqualTo_Or_Above_The_Age_Limit()
        {
            Person p2 = new Person("Susan", "Farmer", "Leeds", 18);
            Exercise002.CanWatchFilm(p2, 15).Should().Be(true);

            p2 = new Person("Susan", "Farmer", "Leeds", 15);
            Exercise002.CanWatchFilm(p2, 15).Should().Be(true);
        }
    }
}
