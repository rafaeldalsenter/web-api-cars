using System;
using WebApiCars.Domain.Builder;
using Xunit;

namespace WebApiCars.Domain.Tests
{
    public class AutoMakerTests
    {
        [Fact]
        public void IsValid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("Brazil")
                .WithName("name example")
                .WithId(Guid.NewGuid())
                .Build();

            Assert.True(domain.IsValid());
        }

        [Fact]
        public void WithCountryIsEmpty_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("")
                .WithName("name example")
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithIdIsEmpty_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("Brazil")
                .WithName("name example")
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithNameIsEmpty_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("Brazil")
                .WithName(string.Empty)
                .WithId(Guid.NewGuid())
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutCountry_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithName("name example")
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutId_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("Brazil")
                .WithName("name example")
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutName_IsInvalid()
        {
            var domain = new AutoMakerBuilder()
                .WithCountry("Brazil")
                .WithId(Guid.NewGuid())
                .Build();

            Assert.False(domain.IsValid());
        }
    }
}