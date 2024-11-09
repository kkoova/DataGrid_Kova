
using System;
using System.Threading.Tasks;
using Contracts;
using Contracts.Models;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CarManagerData.Test
{
    public class CarManagerTest
    {
        private readonly ICarManager carManager;
        private readonly Mock<ICarStorage> carStorageMock;
        private readonly Mock<ILogger> loggerMocK;

        public CarManagerTest()
        {
            carStorageMock = new Mock<ICarStorage>();
            carManager = new CarManager(carStorageMock.Object,
                Mock.Of<ILogger>());

            loggerMocK.Setup(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()));
        }

        [Fact]
        public async Task AddShoudWork()
        {
            // Arrage
            var model = new Car
            {
                Id = Guid.NewGuid(),
                Carbrand = Brand.Ladavesta.ToString(),
                Number = "FF33",
                Mileage = 32,
                AverageFuelConsumption = 1643,
                FuelVolume = 32,
                CostRent = 32,
            };

            carStorageMock.Setup(x => x.AddAsync(It.IsAny<Car>()))
                .ReturnsAsync(new Car());

            // Act
            var result = await carManager.AddAsync(model);

            // Assert
            result.Should().NotBeNull()
                .And.Be(model);
            carStorageMock.Verify(x => x.AddAsync(It.Is<Car>(y => y.Id == model.Id)),
                Times.Once);

            carStorageMock.VerifyNoOtherCalls();
            loggerMocK.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Exactly(2));

            loggerMocK.VerifyNoOtherCalls();
        }
    }
}
