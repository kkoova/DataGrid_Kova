
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace DataGridCar.CarManagerData.Test
{
    /// <summary>
    /// Тесты для <see cref="CarManager"/>
    /// </summary>
    public class CarManagerTest
    {

        private readonly Mock<ICarStorage> carStorageMock;
        private readonly Mock<ILogger<ICarManager>> loggerMocK;
        private readonly ICarManager carManager;

        /// <summary>
        /// Конструктор <see cref="CarManagerTest"/>
        /// </summary>
        public CarManagerTest()
        {
            carStorageMock = new Mock<ICarStorage>();
            loggerMocK = new Mock<ILogger<ICarManager>>();
            loggerMocK.Setup(x => x.Log(
                It.IsAny<LogLevel>(),
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                (Func<It.IsAnyType, Exception, string>)It.IsAny<object>()
            ));

            carManager = new CarManager(carStorageMock.Object, loggerMocK.Object);
        }

        /// <summary>
        /// Добавление в хранилище
        /// </summary>
        [Fact]
        public async Task AddCarNeedToBeCorrect()
        {
            // Arrange
            var cars = new Car
            {
                Id = Guid.NewGuid(),
                Carbrand = Brand.Ladavesta.ToString(),
                Number = "FF33",
                Mileage = 32,
                AverageFuelConsumption = 1643,
                FuelVolume = 32,
                CostRent = 32,
            };

            // Act
            carStorageMock.Setup(x => x.AddAsync(It.IsAny<Car>()))
                .ReturnsAsync(cars);

            var result = await carManager.AddAsync(cars);

            // Assert
            result.Should().NotBeNull().And.Be(cars);
            carStorageMock.Verify(x => x.AddAsync(It.Is<Car>(y => y.Id == cars.Id)), Times.Once);
            carStorageMock.VerifyNoOtherCalls();
            loggerMocK.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Once);
        }

        /// <summary>
        /// Удаление из хранилища
        /// </summary>
        [Fact]
        public async Task DeleteAsyncShouldWork()
        {
            // Arrange
            var modelID = Guid.NewGuid();

            carStorageMock.Setup(x => x.DeleteAsync(It.IsAny<Guid>()))
                .ReturnsAsync(true);

            // Act
            var result = await carManager.DeleteAsync(modelID);

            // Assert
            result.Should().Be(true);
            carStorageMock.Verify(x => x.DeleteAsync(modelID), Times.Once);
            carStorageMock.VerifyNoOtherCalls();

            loggerMocK.Verify(
                x => x.Log(LogLevel.Information, It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
            loggerMocK.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Изменение данных в хранилище
        /// </summary>
        [Fact]
        public async Task EditAsyncShouldWork()
        {
            // Arrange
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

            carStorageMock.Setup(x => x.EditAsync(It.IsAny<Car>()));

            // Act
            await carManager.EditAsync(model);

            // Assert
            carStorageMock.Verify(x => x.EditAsync(It.Is<Car>(y => y.Id == model.Id)), Times.Once);
            carStorageMock.VerifyNoOtherCalls();

            loggerMocK.Verify(
                x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);

            loggerMocK.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Должна возвращаться коллекция продуктов
        /// </summary>
        [Fact]
        public async Task GetAllAsyncShouldReturnAllProducts()
        {
            // Arrange
            var cars = new List<Car>
            {
                new Car { Id = Guid.NewGuid(), Carbrand = Brand.MitsubishiOutlander.ToString(), Number = "GGG45" },
                new Car { Id = Guid.NewGuid(), Carbrand = Brand.HyundaiCross.ToString(), Number = "JJ734" }
            };
            carStorageMock.Setup(x => x.GetAllAsync()).ReturnsAsync(cars);

            // Act
            var result = await carManager.GetAllAsync();

            // Assert
            result.Should().BeEquivalentTo(cars);
            carStorageMock.Verify(x => x.GetAllAsync(), Times.Once);
            carStorageMock.VerifyNoOtherCalls();
            loggerMocK.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Once);
        }
    }
}
