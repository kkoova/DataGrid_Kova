using System;
using System.Linq;
using System.Threading.Tasks;
using DataGridCar.Contracts;
using DataGridCar.Contracts.Models;
using DataGridCar.MemoryStorage;
using FluentAssertions;
using Xunit;

namespace DataGridCar.MemotyStorage.Test
{
    /// <summary>
    /// Тест для <see cref="MemoryCarStorage"/>
    /// </summary>
    public class MemoryCarStorageTest
    {
        public readonly ICarStorage carStorage;

        /// <summary>
        /// Конструтор 
        /// </summary>
        public MemoryCarStorageTest()
        {
            carStorage = new MemoryCarStorage();
        }

        /// <summary>
        /// Удаление определенной машины
        /// </summary>
        [Fact]
        public async Task DeleteTourNeedToBeCorrect()
        {
            // Arrange
            var cars = new Car
            {
                Id = Guid.NewGuid(),
                Carbrand = Brand.Ladavesta.ToString(),
                Number = "AA33",
                Mileage = 32,
                AverageFuelConsumption = 1643,
                FuelVolume = 32,
                CostRent = 32,
            };

            // Act
            await carStorage.AddAsync(cars);
            var result = await carStorage.DeleteAsync(cars.Id);
            var dellRes = await carStorage.GetAllAsync();

            // Assert
            result.Should().BeTrue();
            dellRes.Should().NotContain(p => p.Id == cars.Id);
        }

        /// <summary>
        /// Изменение определенного списка машин
        /// </summary>
        [Fact]
        public async Task EditAsyncShouldUpdate()
        {
            // Arrange
            var carId = Guid.NewGuid();
            var cars = new Car
            {
                Id = carId,
                Carbrand = Brand.Ladavesta.ToString(),
                Number = "AA33",
                Mileage = 32,
                AverageFuelConsumption = 1643,
                FuelVolume = 32,
                CostRent = 32,
            };

            var updatedCars = new Car
            {
                Id = carId,
                Carbrand = Brand.HyundaiCross.ToString(),
                Number = "dDD33",
                Mileage = 52,
                AverageFuelConsumption = 1653,
                FuelVolume = 2,
                CostRent = 325,
            };

            // Act
            await carStorage.AddAsync(cars);
            await carStorage.EditAsync(updatedCars);
            var result = await carStorage.GetAllAsync();
            var product = result.FirstOrDefault(x => x.Id == carId);

            // Assert
            product.Should().BeEquivalentTo(new
            {
                updatedCars.Carbrand,
                updatedCars.Number,
                updatedCars.Mileage,
                updatedCars.AverageFuelConsumption,
                updatedCars.FuelVolume,
                updatedCars.CostRent,
            });
        }

        /// <summary>
        /// Получение машин - пусто
        /// </summary>
        [Fact]
        public async Task GetAllEmptyToursNeedToReturnEmpty()
        {
            var result = await carStorage.GetAllAsync();
            result.Should()
                .NotBeNull()
                .And.BeEmpty();
        }
    }
}
