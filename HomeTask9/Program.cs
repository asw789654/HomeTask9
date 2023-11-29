using Task1;

Car defaultCar = new Car();
Car myCar = new Car(50, 30, 4, "бензин");
ElectricCar fullDefaultElectricCar = new ElectricCar(-10, -10, -10, -10, -10);
ElectricCar myElectricCar = new ElectricCar(10, 10, 10, 10, 10);
Truck myTruck = new Truck(100, 20, 50, 20);
Car testElectricCar = new ElectricCar(10, 10, 10, 10, 10);
defaultCar.DisplayInfo();
Console.WriteLine();
myCar.DisplayInfo();
Console.WriteLine();
fullDefaultElectricCar.DisplayInfo();
myElectricCar.DisplayInfo();
testElectricCar.DisplayInfo(); //вызывает метод базового класса
Console.WriteLine();
myTruck.DisplayInfo();


