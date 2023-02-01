// namespace DAL;
// using BOL;

// public  static class ProductsRepository
// {
//     public static  List<Product> GetAll()
//     {
//             List<Product> allProducts=new List<Product>();
//             allProducts.Add(new Product { ProductId = 1, Title = "Pagani", Description = "Bahut Sasti hai", UnitPrice = 6, Category = "Car", StockAvailable = 5000 });
//             allProducts.Add(new Product { ProductId = 2, Title = "Ferrari", Description = "White mein milegi", UnitPrice = 15, Category = "Car", StockAvailable = 7000 });
//             allProducts.Add(new Product { ProductId = 3, Title = "McLaren", Description = "Average ", UnitPrice = 26, Category = "Car", StockAvailable = 3400 });
//             allProducts.Add(new Product { ProductId = 4, Title = "Nissan GTR", Description = "Tun tun tun Tokyo Drift", UnitPrice = 16, Category = "Car", StockAvailable = 27000 });
//             allProducts.Add(new Product { ProductId = 5, Title = "Mustang", Description = "Dom taklu ki gaadi", UnitPrice = 6, Category = "Car", StockAvailable = 1000 });
//             allProducts.Add(new Product { ProductId = 6, Title = "Lamborghini", Description = "Ambani ke paas toh hogi", UnitPrice = 26, Category = "Car", StockAvailable = 2000 });
//             allProducts.Add(new Product { ProductId = 7, Title = "Toyota Supra", Description = "yeh gaadi nahi pata mereko", UnitPrice = 36, Category = "Car", StockAvailable = 159 });
//             allProducts.Add(new Product { ProductId = 8, Title = "Boeing 747", Description = "Bahut faila hua business hai humara", UnitPrice = 16, Category = "Car", StockAvailable = 67 });
//             allProducts.Add(new Product { ProductId = 9, Title = "Buggati Veyron", Description = "Fastest car in the world 330 MPH YO. Tire ded", UnitPrice = 6, Category = "Car", StockAvailable = 5000 });
//             allProducts.Add(new Product { ProductId = 10, Title = "Rolls Royce Phantom", Description = "Ambani bhi 10 baar sochega", UnitPrice = 7, Category = "Car", StockAvailable = 0 });
//             allProducts.Add(new Product { ProductId = 11, Title = "Porche Maybach", Description = "Pune mein thi humne picha kiya tha.", UnitPrice = 12, Category = "Car", StockAvailable = 0 });
//             allProducts.Add(new Product { ProductId = 12, Title = "Audi R8", Description = "Audi=best", UnitPrice = 10, Category = "Car", StockAvailable = 700 });
//             allProducts.Add(new Product { ProductId = 13, Title = "Maruti 800", Description = "Sachin Tendulkar ki first car. abb woh plane mein ghumta hai", UnitPrice = 16, Category = "Car", StockAvailable = 1500 });
//             allProducts.Add(new Product { ProductId = 14, Title = "Jaguar", Description = "Tata YO", UnitPrice = 8, Category = "Car", StockAvailable = 2300 });
//             allProducts.Add(new Product { ProductId = 15, Title = "Mercedes C-class", Description = "mehenga gaadi par usmein tax lag jaata bahut", UnitPrice = 17, Category = "Car", StockAvailable = 10000 });
//             return allProducts;
//     }

//     public static Product GetById(int id){

//           List<Product> products=GetAll();
//           var theProduct= (from prod in products
//                           where prod.ProductId == id
//                           select prod);

          
//           return theProduct.First<Product>();
//     }

//     public  static bool  Insert(Product product){
//          bool status=false;
//          List<Product> products=GetAll();
//          products.Add(product);
//          status=true;
//          return status;
//     }


//     public  static bool Delete(int id){
//          bool status=false;
//          List<Product> products=GetAll();
//          Product theProduct=GetById(id);
//          products.Remove(theProduct);
//          status=true;
//          return status;
//     }


//     public static bool Update(Product product){
//          bool status=false;
//          List<Product> products=GetAll();
//         //Logic to Update existing Product from products collection

//          status=true;
//          return status;
//     }

// }
