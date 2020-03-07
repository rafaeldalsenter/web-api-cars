using System;
using WebApiCars.Domain.Builder;
using Xunit;

namespace WebApiCars.Domain.Tests
{
    public class CarTests
    {
        [Fact]
        public void IsValid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithFeatures("features example")
                .WithYear(1990)
                .WithId(Guid.NewGuid())
                .Build();

            Assert.True(domain.IsValid());
        }

        [Fact]
        public void WithIdIsEmpty_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithFeatures("features example")
                .WithYear(1990)
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithModelIsEmpty_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithModel(string.Empty)
                .WithFeatures("features example")
                .WithYear(1990)
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutFeatures_IsValid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithYear(1990)
                .WithId(Guid.NewGuid())
                .Build();

            Assert.True(domain.IsValid());
        }

        [Fact]
        public void WithoutId_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithFeatures("features example")
                .WithYear(1990)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutModel_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithFeatures("features example")
                .WithYear(1990)
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithoutYear_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithFeatures("features example")
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }

        [Fact]
        public void WithYearIsStranger_IsInvalid()
        {
            var domain = new CarBuilder()
                .WithModel("model example")
                .WithFeatures("features example")
                .WithYear(105)
                .WithId(Guid.Empty)
                .Build();

            Assert.False(domain.IsValid());
        }
    }
}