$(document).on('click', '.editCarButton', function () {
    const carId = $(this).data('id');
    $('#carModalLabel').text('Редактировать машину');
    $('#carForm').attr('action', '/Car/Edit'); // URL для редактирования

    // Загрузка данных машины через fetch
    fetch(`/Car/GetCar?id=${carId}`)
        .then(response => response.json())
        .then(car => {
            $('#carId').val(car.id);
            $('#carBrand').val(car.carbrand);
            $('#carNumber').val(car.number);
            $('#carMileage').val(car.mileage);
            $('#carAverageFuelConsumption').val(car.averageFuelConsumption);
            $('#carFuelVolume').val(car.fuelVolume);
            $('#carCostRent').val(car.costRent);
            $('#carModal').modal('show');
        })
        .catch(error => console.error('Ошибка при загрузке данных машины:', error));
});

