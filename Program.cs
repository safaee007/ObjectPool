// See https://aka.ms/new-console-template for more information
using ObjectPool_SampleProject;

Console.WriteLine("Hello, World!");

var personPool = new ObjectPoolService<Person>();

// دریافت یک شخص
Person person1 = personPool.GetObject();
person1.GetPerson();

// بازگرداندن شخص به استخر
personPool.ReleaseObject(person1);

// دریافت مجدد شخص
Person person2 = personPool.GetObject();
person2.GetPerson();


var addressPool = new ObjectPoolService<Address>();
Address address = addressPool.GetObject();
address.GetAddress(1);

addressPool.ReleaseObject(address);