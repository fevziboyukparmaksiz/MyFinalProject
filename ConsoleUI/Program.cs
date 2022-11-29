using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName); 
}
