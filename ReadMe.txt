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
	Done through "Order" class : CustomisedOrder and RegularOrder

For polymorphism, 
	=>		different sub class or class will have same objects (base class or reference) but will run method on the basis of its actual
	method(derived class type)
	Done in "Customer" class : OldCustomer which has different methods than the base

	=>		Now, as per task : For 'Product' class
	Base class : Product , which has virtual method : CalculateShippingCost()
	Derived class : PhysicalProduct and DigitalProduct , overriding CalculateShippingCost()
	Now make different implementation (logic) of the functions according to the type of Product

For binary search ,
	Only these ID are valid , 1 ,2,3,4,33,37

