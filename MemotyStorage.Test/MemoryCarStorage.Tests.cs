using System;
using System.Threading.Tasks;
using Contracts;
using Contracts.Models;
using FluentAssertions;
using MemoryStorage;
using Xunit;

namespace MemotyStorage.Test
{
    /// <summary>
    /// Тест для <see cref="MemoryCarStorage"/>
    /// </summary>
    public class MemoryCarStorageTest
    {
        public readonly ICarStorage carStorage;

        public MemoryCarStorageTest()
        {
            carStorage = new MemoryCarStorage();
        }

        /// <summary>
        /// Получает пустой список
        /// </summary>
        [Fact]
        public async Task GetAllShoudReturnEmpty()
        {
            // Act
            Func<Task> act = () => carStorage.GetAllAsync();

            // Assert
            await act.Should().NotThrowAsync();
        }

        /// <summary>
        /// При пустом списке не падает
        /// </summary>
        [Fact]
        public async Task GetAllShoudNotThrow()
        {
            //
            var result = await carStorage.GetAllAsync();

            // Assert
            result.Should()
                .NotBeEmpty()
                .And.BeEmpty();
        }

        /// <summary>
        /// При пустом списке не падает
        /// </summary>
        [Fact]
        public async Task GetAllShoudReturnValue()
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

            var result = await carStorage.AddAsync(model);

            // Assert
            result.Should().NotBeNull()
                .And.BeEquivalentTo(new
                {
                    Id = model.Id,
                    Brend = model.Carbrand,
                });
        }
    }
}
