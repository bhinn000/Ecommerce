For encapsulation , 
	Lets try to make product details hidden ,
	Applying encapsulation in Product class so that the order and customer way  is not known 
	as name is encapsulated , Customer.name is unaccessible
	CS0122	'Customer.name' is inaccessible due to its protection level	Ecommerce	H:\.NET Learn\Ecommerce\Program.cs	33
	BUT , Customer.Name is accessible and we can update it , checking its validation rules

For inheritance , 
	Make it in Product class ,
	Product can be cosmetics , food related , stationery
	So the "order" which is expecting list of "product" , we can also add "foodproduct and stationery"

For abstraction, 
	We use main parent class as its type but while initialisation , we use different derived class type(concrete)

For polymorphism, 
	different sub class or class will have same objects (base class or reference) but will run method on the basis of its actual method(derived class type)
